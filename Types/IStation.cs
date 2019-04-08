using System;
using System.Threading.Tasks;

namespace Loko.Station
{
    public interface IStation
    {
        IMessageSender Send(Loko.Station.MsgType type, String message);
        event EventListener Signaled;
        event EventListener Linked;
        event EventListener Blocked;

        void Log(String message);
    }

    public interface IMessageSender
    {
        Task<Metro.Api.Response> To(StationDesc destination);
    }
}
