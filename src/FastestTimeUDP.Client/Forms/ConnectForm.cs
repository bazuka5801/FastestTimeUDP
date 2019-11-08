using System;
using System.Windows.Forms;

namespace FastestTimeUDP.Client.Forms
{
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // TODO: Add connection code
            new MainForm().ShowDialog();
        }
    }
}