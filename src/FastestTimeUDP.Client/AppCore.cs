using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        
        public static AppCore Instance { get; private set; }
        public static BaseClient Client => Instance._Client;
        
        
        public override void OnAwake()
        {
            base.OnAwake();
            Instance = this;

            StartThreadUI();
            
            _Client = this.AddType<BaseClient>();
        }

        void StartThreadUI()
        {
            Thread uiThread = new Thread(o =>
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