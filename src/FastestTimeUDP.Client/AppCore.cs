using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using FastestTimeUDP.Client.Forms;
using SapphireEngine;

namespace FastestTimeUDP.Client
{
    public class AppCore : SapphireType
    {
        public override void OnAwake()
        {
            base.OnAwake();

            StartThreadUI();
        }

        void StartThreadUI()
        {
            Thread uiThread = new Thread(o =>
            {
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ConnectForm());
            }) {Name = "UI Thread", IsBackground = true};

            uiThread.Start();
        }
    }
}