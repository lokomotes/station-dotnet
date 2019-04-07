using System;
using System.Threading.Tasks;

namespace Loko
{
    public interface IStation
    {
        IMessageSender Send(Loko.MsgType type, String message);
        event ReceiveListener Signaled;
        event ReceiveListener Linked;
        event ReceiveListener Blocked;

        void Log(String message);
    }

    public interface IMessageSender
    {
        Task<Metro.Api.Response> To(StationDesc destination);
    }
}
