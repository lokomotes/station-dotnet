﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;

using Ctrl = Loko.Metro.Api.Signal.Types.Control;

namespace Loko
{
    class Program
    {
        static private void _sigHandler(Metro.Api.Signal sig)
        {
            var srcSt = sig.Src;
            var dstSt = sig.Dst;

            if (dstSt == null)
            {
                Console.WriteLine("Station is undefined");
                return;
            }

            var isExists = Flows.Has(dstSt);


            Func<Flows.StationBody> fetch = () =>
            {
                Flows.TryGet(dstSt, out var body);
                return body;
            };

            Func<Flows.StationBody> start = () =>
            {
                var body = Flows.Create(dstSt);
                var msg = sig.Message;

                (AppLoader.CreateInstance() as IApp).Open(body.Station, null);

                return body;
            };

            var ctrl = sig.Control;
            switch (ctrl)
            {
                default:
                    Console.WriteLine("Unmanaged control flag: " + ctrl);
                    break;

                case Ctrl.Start:
                    if (isExists) Console.WriteLine("Already opened `Station`: " + dstSt.Name);
                    else start();
                    break;

                case Ctrl.Terminate:
                    if (!isExists) Console.WriteLine("`Station` does not exist: " + dstSt.Name);
                    else Flows.Del(dstSt);
                    break;

                case Ctrl.Linked:
                    {
                        var listeners = (isExists ? fetch() : start()).Emitter[EventName.Linked].GetInvocationList();
                        Parallel.ForEach(listeners, listener => (listener as ReceiveListener).Invoke(sig.Message, new StationDesc(srcSt)));
                    }
                    break;

                case Ctrl.Message:
                    if (!isExists) Console.WriteLine("`Station` does not exist: " + dstSt.Name);
                    else
                    {
                        var listeners = fetch().Emitter[EventName.Signaled].GetInvocationList();
                        Parallel.ForEach(listeners, listener => (listener as ReceiveListener).Invoke(sig.Message, new StationDesc(srcSt)));
                    }
                    break;

                case Ctrl.Blocked:
                    if (!isExists) Console.WriteLine("`Station` does not exist: " + dstSt.Name);
                    else
                    {
                        var listeners = fetch().Emitter[EventName.Blocked].GetInvocationList();
                        Parallel.ForEach(listeners, listener => (listener as ReceiveListener).Invoke(sig.Message, new StationDesc(srcSt)));
                    }
                    break;
            }

            return;
        }

        static async Task Main(String[] args)
        {
            (AppLoader.CreateInstance() as IApp).Open(null, null);

            var listenReq = new Metro.Api.ListenRequest();
            listenReq.Token = Token.Create();

            using (var call = RouterConn.Client.Listen(listenReq, new Grpc.Core.CallOptions().WithWaitForReady(true)))
            {
                var resSteram = call.ResponseStream;

                await Task.Delay(1000);

                // TODO?: handle RPCException
                while (await resSteram.MoveNext())
                {
                    var _ = Task.Run(() => _sigHandler(resSteram.Current)).ConfigureAwait(false);
                }
            }
        }
    }
}