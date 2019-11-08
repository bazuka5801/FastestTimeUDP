using System;
using System.Net.Sockets;
using System.Threading;
using SapphireEngine;

namespace FastestTimeUDP.Common.Network
{
    public abstract partial class NetworkPeer : SapphireType, IDisposable
    {
        private static Byte[] _Data = new Byte[65507];
        protected UdpClient _Net;

        public DateTime LastActivityTime;

        public bool IsConnected()
        {
            return true;
        }

        public void InitPeer(UdpClient client)
        {
            this._Net = client;
            
            SetupThreadReceive();
        }

        

        public override void Dispose()
        {
            base.Dispose();
            
            _Net?.Dispose();
            _Net = null;
        }
    }
}