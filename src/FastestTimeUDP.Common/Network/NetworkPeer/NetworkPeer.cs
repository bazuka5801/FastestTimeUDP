using System;
using System.Net.Sockets;
using SapphireEngine;

namespace FastestTimeUDP.Common.Network
{
    public enum StatusE
    {
        None         = 0,
        Reconnecting = 1,
        Connected    = 2,
        Disconnected = 3,
        Listening    = 4
    }

    public class ClientStatusEventArgs : EventArgs
    {
        public StatusE Status;

        public ClientStatusEventArgs(StatusE status)
        {
            Status = status;
        }
    }

    public delegate void ClientStatusHandler(object sender, ClientStatusEventArgs e);

    public abstract partial class NetworkPeer : SapphireType, IDisposable
    {
        protected static byte[]  _Data = new byte[65507];
        protected        Socket  _Net;
        private          StatusE _Status;

        public DateTime LastReceiveActivityTime;

        protected object lockObject = new object();

        public ClientStatusHandler StatusUpdate;

        public StatusE Status
        {
            get => _Status;
            set
            {
                _Status = value;
                StatusUpdate?.Invoke(this, new ClientStatusEventArgs(value));
            }
        }

        public string IP   { get; protected set; }
        public int    Port { get; protected set; }

        public override void Dispose()
        {
            base.Dispose();

            Disconnect();
        }

        public bool IsConnected()
        {
            return _Net != null;
        }

        public void InitPeer(Socket client)
        {
            lock (lockObject)
            {
                _Net = client;
            }

            SetupThreadReceive();
        }

        public virtual void Disconnect()
        {
            lock (lockObject)
            {
                _Net?.Dispose();
                _Net = null;
            }
        }
    }
}