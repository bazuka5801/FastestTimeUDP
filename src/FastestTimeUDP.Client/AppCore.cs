using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using FastestTimeUDP.Client.Forms;
using FastestTimeUDP.Common.Network;
using SapphireEngine;

namespace FastestTimeUDP.Client
{
    public class AppCore : SapphireType
    {
        private BaseClient _Client;
        
        
        public override void OnAwake()
        {
            base.OnAwake();

            StartThreadUI();
            
            _Client = this.AddType<BaseClient>();
            _Client.Connect("127.0.0.1", 22540);
        }

        void StartThreadUI()
        {
            Thread uiThread = new Thread(o =>
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ConnectForm());
                
                Process.GetCurrentProcess().Kill();
            }) {Name = "UI Thread", IsBackground = true};

            uiThread.Start();
        }
    }
}