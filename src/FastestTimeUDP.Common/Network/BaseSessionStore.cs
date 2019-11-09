using System.Collections.Generic;
using System.Linq;
using System.Net;
using SapphireEngine;

namespace FastestTimeUDP.Common.Network
{
    public class BaseSessionStore
    {
        private List<BaseServerSession> _ActiveSessionList = new List<BaseServerSession>();

        private readonly Dictionary<string, BaseServerSession> _ActiveSessions =
            new Dictionary<string, BaseServerSession>();

        public List<BaseServerSession> GetAllSessions()
        {
            return _ActiveSessionList;
        }

        public BaseServerSession GetSession(EndPoint remoteIP)
        {
            var address = remoteIP.ToString();
            if (_ActiveSessions.TryGetValue(address, out var session)) return session;

            session = CreateSession(remoteIP);
            OnSessionOpen(session, address);
            return session;
        }

        protected virtual BaseServerSession CreateSession(EndPoint client)
        {
            var session = new BaseServerSession();
            session.Disconnected += OnSessionClose;
            session.ServerInit(client);
            return session;
        }

        private void OnSessionOpen(BaseServerSession session, string address)
        {
            _ActiveSessions[address] = session;
            _ActiveSessionList       = _ActiveSessionList.ToList();
            _ActiveSessionList.Add(session);
            ConsoleSystem.Log($"[{address}] connected!");
        }

        private void OnSessionClose(BaseServerSession sender, SessionDisconnectEventArgs e)
        {
            _ActiveSessions.Remove(sender.RemoteIP.ToString());
            _ActiveSessionList = _ActiveSessionList.ToList();
            _ActiveSessionList.Remove(sender);
            ConsoleSystem.Log($"[{sender.RemoteIP}] disconnected!");
        }

        public void Cycle()
        {
            for (var i = 0; i < _ActiveSessionList.Count; i++) _ActiveSessionList[i].Cycle();
        }
    }
}