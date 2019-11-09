using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using SapphireEngine;
using Timer = SapphireEngine.Functions.Timer;

namespace FastestTimeUDP.Common.Network
{
    public class ClientPPSEventArgs : EventArgs
    {
        /// <summary>
        ///   Packets Per Second
        /// </summary>
        public int PPS;

        public ClientPPSEventArgs(int pps)
        {
            this.PPS = pps;
        }
    }

    public delegate void ClientPPSHandler(object sender, ClientPPSEventArgs e);
    
    public class BaseClient : NetworkPeer
    {
        private int receivedPacketsPerSecond = 0;
        private DateTime lastPacketsUpdate = DateTime.Now;
        private Timer reconnectTimer;

        private Timer sendAliveTimer;

        public ClientPPSHandler ClientPPS;
        
        public void Connect(string ip, int port)
        {
            if (_Net != null)
            {
                throw new Exception($"{nameof(_Net)} is not null!");
            }
            
            this.IP   = ip;
            this.Port = port;
            
            var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            socket.Connect(new IPEndPoint(IPAddress.Parse(ip), port));
            InitPeer(socket);
            if (Status != StatusE.Reconnecting)
            {
                Status = StatusE.Reconnecting;
            }

            sendAliveTimer = Timer.SetInterval(SendAlive, 1f);
        }

        public void Reconnect()
        {
            Disconnect();
            Connect(IP, Port);
            Timer.SetTimeout(() =>
            {
                if (IsConnected() == false) Reconnect();
            }, 5f);
        }

        public override void Disconnect()
        {
            if (sendAliveTimer != null)
            {
                // Destroy timer
                sendAliveTimer.Enable   = false;
                sendAliveTimer.Callback = null;
                sendAliveTimer          = null;
            }

            base.Disconnect();

            Status = StatusE.Disconnected;
        }
    

        protected override void OnNetworkData(int length, EndPoint senderIP)
        {
            base.OnNetworkData(length, senderIP);
            
            if (Status != StatusE.Connected)
            {
                Status = StatusE.Connected;
            }
            
            var receivedDate = DateTime.FromBinary(BitConverter.ToInt64(_Data[..length]));
            
            receivedPacketsPerSecond++;
        }

        public override void OnUpdate()
        {
            base.OnUpdate();
            
            
            if (IsConnected() == false)
            {
                return;
            }

            if (DateTime.Now.Subtract(LastReceiveActivityTime).TotalSeconds > 1)
            {
                if (reconnectTimer == null && Status !=  StatusE.Reconnecting)
                {
                    Status         = StatusE.Reconnecting;
                    reconnectTimer = Timer.SetTimeout(Reconnect, 5f);
                }

                return;
            }
            
            if (DateTime.Now.Subtract(lastPacketsUpdate).TotalSeconds >= 1)
            {
                lastPacketsUpdate = DateTime.Now;
                
                ClientPPS?.Invoke(this, new ClientPPSEventArgs(receivedPacketsPerSecond));
                receivedPacketsPerSecond = 0;
            }
        }


        private byte[] alivePacket = new byte[] {255};
        public void SendAlive()
        {
            _Net.Send(alivePacket);
        }
    }
}