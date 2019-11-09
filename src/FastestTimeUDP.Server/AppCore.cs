using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using FastestTimeUDP.Client.Forms;
using FastestTimeUDP.Common.Network;
using SapphireEngine;

namespace FastestTimeUDP.Server
{
    public class AppCore : SapphireType
    {
        private BaseServer _Server;

        public static AppCore    Instance { get; private set; }
        public static BaseServer Server   => Instance._Server;

        public override void OnAwake()
        {
            Instance = this;
            _Server  = AddType<BaseServer>();

            StartThreadUI();
        }

        private void StartThreadUI()
        {
            var uiThread = new Thread(o =>
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());

                Process.GetCurrentProcess().Kill();
            }) {Name = "UI Thread", IsBackground = true};

            uiThread.Start();
        }
    }
}