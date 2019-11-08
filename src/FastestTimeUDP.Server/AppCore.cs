using FastestTimeUDP.Common;
using FastestTimeUDP.Common.Network;
using SapphireEngine;

namespace FastestTimeUDP.Server
{
    public class AppCore : SapphireType
    {
        private BaseServer _Server;


        public override void OnAwake()
        {
            _Server = this.AddType<BaseServer>();
            _Server.Host(22540);
        }
    }
}