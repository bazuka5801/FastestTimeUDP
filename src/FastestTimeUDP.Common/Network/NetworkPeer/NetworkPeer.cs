using System;
using System.Net.Sockets;
using System.Threading;
using SapphireEngine;

namespace FastestTimeUDP.Common.Network
{
    public enum StatusE
    {
        None         = 0,
        Reconnecting = 1,
        Connected    = 2,
        Disconnected = 3,
        Listening    = 4,
    }

    public class ClientStatusEventArgs : EventArgs
    {
        public StatusE Status;

        public ClientStatusEventArgs(StatusE status)
        {
            this.Status = status;
        }
    }

    public delegate void ClientStatusHandler(object sender, ClientStatusEventArgs e);

    public abstract partial class NetworkPeer : SapphireType, IDisposable
    {
        protected static Byte[]    _Data = new Byte[65507];
        protected      Socket _Net;

        public DateTime LastReceiveActivityTime;

        public  ClientStatusHandler StatusUpdate;
        private StatusE             _Status;

        protected object lockObject = new object();
        
        public StatusE Status
        {
            get => _Status;
            set
            {
                _Status = value;
                StatusUpdate?.Invoke(this, new ClientStatusEventArgs(value));
            }
        }

        public String IP   { get; protected set; }
        public Int32  Port { get; protected set; }

        public bool IsConnected()
        {
            return _Net != null;
        }

        public void InitPeer(Socket client)
        {
            lock (lockObject)
            {
                this._Net = client;
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

        public override void Dispose()
        {
            base.Dispose();

            Disconnect();
        }
    }
}