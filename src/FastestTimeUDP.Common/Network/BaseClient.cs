using System;
using System.Net;
using System.Net.Sockets;
using SapphireEngine;
using SapphireEngine.Functions;

namespace FastestTimeUDP.Common.Network
{
    public class BaseClient : NetworkPeer
    {
        private int receivedPacketsPerSecond = 0;
        private DateTime lastPacketsUpdate = DateTime.Now;
        
        public void Connect(string ip, int port)
        {
            if (_Net != null)
            {
                throw new Exception($"{nameof(_Net)} is not null!");
            }
            
            InitPeer(new UdpClient(ip, port));

            Timer.SetInterval(SendAlive, 1f);
        }

        public void Disconnect()
        {
            base.Dispose();
        }

        protected override void OnNetworkData(byte[] data, IPEndPoint senderIP)
        {
            var receivedDate = DateTime.FromBinary(BitConverter.ToInt64(data));
            
            receivedPacketsPerSecond++;
        }

        public override void OnUpdate()
        {
            base.OnUpdate();

            if (DateTime.Now.Subtract(lastPacketsUpdate).TotalSeconds >= 1)
            {
                lastPacketsUpdate = DateTime.Now;
                
                ConsoleSystem.Log($"Packets per second: {receivedPacketsPerSecond}");
                receivedPacketsPerSecond = 0;
            }
        }


        private byte[] alivePacket = new byte[] {255};
        public void SendAlive()
        {
            _Net.Send(alivePacket, 1);
        }
    }
}