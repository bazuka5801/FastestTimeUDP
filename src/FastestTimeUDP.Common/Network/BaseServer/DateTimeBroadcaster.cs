using System;
using System.Threading;

namespace FastestTimeUDP.Common.Network
{
    public partial class BaseServer
    {
        void SetupBroadcaster()
        {
            Thread broadcaster = new Thread(o => DateTimeBroadcast_Worker())
            {
                Name = "DateTimeBroadcaster",
                IsBackground = true
            };
            
            broadcaster.Start();
        }

        void DateTimeBroadcast_Worker()
        {
            while (_Net != null)
            {
                SendDateTimeToAllClients();
            }
        }

        void SendDateTimeToAllClients()
        {
            var now = BitConverter.GetBytes(DateTime.Now.ToBinary());
            var list = _SessionStore.GetAllSessions();

            for (int i = 0; i < list.Count; i++)
            {
                _Net.Send(now, now.Length, list[i].RemoteIP);
            }
        }
    }
}