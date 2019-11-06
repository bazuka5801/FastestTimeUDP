using SapphireEngine;

namespace FastestTimeUDP.Common
{
    public abstract class BaseServer : SapphireType
    {
        public abstract void Host(int port);
        public abstract void Stop();
    }
}