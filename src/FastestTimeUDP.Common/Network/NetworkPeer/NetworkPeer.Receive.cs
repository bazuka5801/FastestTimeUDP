using System;
using System.Net;
using System.Threading;

namespace FastestTimeUDP.Common.Network
{
    public partial class NetworkPeer
    {
        private void SetupThreadReceive()
        {
            Thread receiveThread = new Thread(o => ReceiveWorker())
            {
                Name = "UI Thread",
                IsBackground = true
            };

            receiveThread.Start();
        }

        private void ReceiveWorker()
        {
            IPEndPoint senderIP = new IPEndPoint(0,0);
            
            while (_Net != null)
            {
                if (_Net.Available > 0)
                {
                    var data = _Net.Receive(ref senderIP);
                    OnNetworkData(data, senderIP);
                }
            }
        }

        protected virtual void OnNetworkData(byte[] data, IPEndPoint senderIP)
        {
            LastActivityTime = DateTime.Now;
        }
    }
}