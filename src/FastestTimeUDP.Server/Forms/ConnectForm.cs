using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FastestTimeUDP.Client.Forms
{
    public class ConnectModel
    {
        public string IP;
        public int    Port;

        public bool Success;
    }

    public partial class ConnectForm : Form
    {
        private readonly ConnectModel _Model;

        public ConnectForm(ConnectModel model)
        {
            _Model = model;
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _Model.IP = tbIP.Text;

            var ipRegex =
                "^(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";

            if (Regex.IsMatch(_Model.IP, ipRegex) == false)
            {
                MessageBox.Show("IP должен быть IP :)");
                return;
            }

            if (int.TryParse(tbPort.Text, out _Model.Port) == false)
            {
                MessageBox.Show("Поле PORT должно содержать число");
                return;
            }

            if (_Model.Port < 1024 || _Model.Port > 65535)
            {
                MessageBox.Show("Число PORT должно быть больше 1024 и меньше 65536");
                return;
            }

            _Model.Success = true;
            Close();
        }
    }
}