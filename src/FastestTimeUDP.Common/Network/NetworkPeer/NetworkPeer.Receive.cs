using System;
using System.Net;
using System.Threading;

namespace FastestTimeUDP.Common.Network
{
    public partial class NetworkPeer
    {
        private void SetupThreadReceive()
        {
            var receiveThread = new Thread(o => ReceiveWorker())
            {
                Name         = "UI Thread",
                IsBackground = true
            };

            receiveThread.Start();
        }

        private void ReceiveWorker()
        {
            EndPoint senderIP = new IPEndPoint(0, 0);

            while (_Net != null)
                lock (lockObject)
                {
                    if (_Net?.Available > 0)
                    {
                        var size = _Net.ReceiveFrom(_Data, ref senderIP);
                        OnNetworkData(size, senderIP);
                    }
                }
        }

        protected virtual void OnNetworkData(int length, EndPoint senderIP)
        {
            LastReceiveActivityTime = DateTime.Now;
        }
    }
}