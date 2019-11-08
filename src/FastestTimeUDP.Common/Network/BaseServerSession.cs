﻿using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using SapphireEngine;

namespace FastestTimeUDP.Common.Network
{
    public class SessionDisconnectEventArgs : EventArgs {
    
    }
    
    public delegate void SessionDisconnectHandler(BaseServerSession sender, SessionDisconnectEventArgs e);

    public class BaseServerSession : IDisposable
    {
        private IPEndPoint _SendEp = null;
        private Socket _UdpSendSocket = null;

        public SessionDisconnectHandler Disconnected;
        
        private DateTime LastPacketTime = DateTime.Now;

        public IPEndPoint RemoteIP => _SendEp;
        
        internal void ServerInit(EndPoint clientEndPoint)
        {
            _SendEp = (IPEndPoint)clientEndPoint;
            _UdpSendSocket ??= new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        }

        public void Dispose()
        {
            _UdpSendSocket?.Dispose();
            _UdpSendSocket = null;
        }

        public void Disconnect()
        {
            if (Disconnected == null)
            {
                // Subscribers must remove it from the session store
                throw new Exception("Disconnected handler - 0 subscribers");
            }

            Disconnected.Invoke(this, new SessionDisconnectEventArgs());
        }

        public void Cycle()
        {
            if (DateTime.Now.Subtract(LastPacketTime).TotalSeconds > 5)
            {
                Disconnect();
            }
        }

        public void OnNetworkData(byte[] data, int size)
        {
            LastPacketTime = DateTime.Now;
        }
    }
}