using System;
using System.Windows.Forms;
using FastestTimeUDP.Common.Extensions;
using FastestTimeUDP.Common.Network;
using FastestTimeUDP.Server;

namespace FastestTimeUDP.Client.Forms
{
    public partial class MainForm : Form
    {
        private ConnectModel _Model;

        public MainForm()
        {
            InitializeComponent();

            AppCore.Server.StatusUpdate += StatusUpdate;
            AppCore.Server.ServerPPS    += ServerPps;
        }

        private void ServerPps(object sender, ClientPPSEventArgs e)
        {
            this.RunInUI(() => { lblPPS.Text = e.PPS.ToString(); });
        }

        private void StatusUpdate(object sender, ClientStatusEventArgs e)
        {
            var baseServer = (BaseServer) sender;
            this.RunInUI(() =>
            {
                if (e.Status == StatusE.Listening)
                    lblStatus.Text = "Активен";
                else
                    lblStatus.Text = e.Status.ToString();
            });
        }


        private void InitConnect()
        {
            var connectModel = new ConnectModel();
            new ConnectForm(connectModel).ShowDialog();

            if (connectModel.Success)
            {
                msConnect.Enabled = false;
                AppCore.Server.Host(connectModel.IP, connectModel.Port);
            }
        }

        private void msConnect_Click(object sender, EventArgs e)
        {
            InitConnect();
        }

        private void msInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Автор: github.com/bazuka5801", "Информация");
        }
    }
}