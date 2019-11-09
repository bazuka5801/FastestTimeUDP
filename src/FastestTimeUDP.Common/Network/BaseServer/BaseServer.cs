﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SapphireEngine;

namespace FastestTimeUDP.Common.Network
{
    
    public class ServerPPSEventArgs : EventArgs
    {
        /// <summary>
        ///   Packets Per Second
        /// </summary>
        public int PPS;

        public ServerPPSEventArgs(int pps)
        {
            this.PPS = pps;
        }
    }

    public delegate void ServerPPSHandler(object sender, ClientPPSEventArgs e);
    
    public partial class BaseServer : NetworkPeer
    {
        private static BaseSessionStore _SessionStore = new BaseSessionStore();
        public int ActiveClientsCount => _SessionStore.GetAllSessions().Count;
        
        
        public  ServerPPSHandler ServerPPS;
        private DateTime         lastPacketsUpdate = DateTime.Now;
        public int              PPS               = 0;

        public void Host(string ip, int port)
        {
            if (_Net != null)
            {
                throw new Exception($"{nameof(_Net)} is not null!");
            }

            this.IP = ip;
            this.Port = port;
            ConsoleSystem.Log(ip + " " + port);

            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Bind(new IPEndPoint(IPAddress.Parse(ip), port));
            InitPeer(socket);

            Status = StatusE.Reconnecting;

            SetupBroadcaster();
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            
            _SessionStore.Cycle();
            
            if (DateTime.Now.Subtract(lastPacketsUpdate).TotalSeconds >= 1)
            {
                lastPacketsUpdate = DateTime.Now;
                
                ServerPPS?.Invoke(this, new ClientPPSEventArgs(PPS));
                PPS = 0;
            }
        }

        protected override void OnNetworkData(int length, EndPoint senderIP)
        {
            if (Status != StatusE.Connected)
            {
                Status = StatusE.Connected;
            }
            base.OnNetworkData(length, senderIP);
            var session = _SessionStore.GetSession(senderIP);
            session.OnNetworkData(_Data, length);
        }
    }
}