using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SapphireEngine;

namespace FastestTimeUDP.Common.Network
{
    public partial class BaseServer : NetworkPeer
    {
        private static BaseSessionStore _SessionStore = new BaseSessionStore();
        
        public Int32 Port { get; private set; }

        public void Host(int port)
        {
            if (_Net != null)
            {
                throw new Exception($"{nameof(_Net)} is not null!");
            }
            
            this.Port = port;
            
            InitPeer(new UdpClient(port));

            SetupBroadcaster();
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            
            _SessionStore.Cycle();
        }

        protected override void OnNetworkData(byte[] data, IPEndPoint senderIP)
        {
            var session = _SessionStore.GetSession(senderIP);
            session.OnNetworkData(data, data.Length);
        }
    }
}