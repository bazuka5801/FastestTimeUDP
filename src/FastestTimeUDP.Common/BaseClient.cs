using System.Net;
using SapphireEngine;

namespace FastestTimeUDP.Common
{
    public abstract class BaseClient : SapphireType
    {
        public abstract void Connect(IPAddress ip, int port);
        public abstract void Disconnect();
    }
}