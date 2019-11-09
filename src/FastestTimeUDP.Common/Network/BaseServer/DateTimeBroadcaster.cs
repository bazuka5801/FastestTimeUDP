using System;
using System.Net.Sockets;
using System.Threading;

namespace FastestTimeUDP.Common.Network
{
    public partial class BaseServer
    {
        private void SetupBroadcaster()
        {
            var broadcaster = new Thread(o => DateTimeBroadcast_Worker())
            {
                Name         = "DateTimeBroadcaster",
                IsBackground = true
            };

            broadcaster.Start();
        }

        private void DateTimeBroadcast_Worker()
        {
            while (_Net != null) SendDateTimeToAllClients();
        }

        private void SendDateTimeToAllClients()
        {
            var now  = BitConverter.GetBytes(DateTime.Now.ToBinary());
            var list = _SessionStore.GetAllSessions();

            lock (lockObject)
            {
                for (var i = 0; i < list.Count; i++)
                {
                    _Net.SendTo(now, now.Length, SocketFlags.None, list[i].RemoteIP);
                    PPS++;
                }
            }
        }
    }
}