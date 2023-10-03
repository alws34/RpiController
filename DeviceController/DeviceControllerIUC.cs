using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiController.DeviceController
{
    public partial class DeviceControllerUC : UserControl
    {
        public bool IsPasswordEdited { get; set; } = false;
        public bool IsAllFieldsOK { get; set; } = false;
        public IDeviceController DeviceController { get; set; } = null;
        public DeviceControllerUC()
        {
            InitializeComponent();
        }

        public string GetDeviceName() { return tbDeviceName.Text; }
        public void SetDeviceName(string name) { tbDeviceName.Text = name; }

        public string GetDeviceUserName() { return tbDeviceUserName.Text; }
        public void SetDeviceUserName(string userName) { tbDeviceUserName.Text = userName; }

        public string GetDevicePassword() { return tbDevicePassword.Text; }
        public void SetDevicePassword(string password) { tbDevicePassword.Text = password; }

        public string GetDevicePort() { return tbDevicePort.Text; }
        public void SetDevicePort(string port) { tbDevicePort.Text = port; }

        public string GetDeviceIP() { return tbDeviceIP.Text; }
        public void SetDeviceIP(string ip) { tbDeviceIP.Text = ip; }

        public string GetDeviceLocation() { return tbDeviceLocation.Text; }
        public void SetDeviceLocation(string location) { tbDeviceLocation.Text = location; }

        public string GetDeviceDescription() { return tbDeviceDescription.Text; }
        public void SetDeviceDescription(string description) { tbDeviceDescription.Text = description; }

        private void cbShowDevicePassword_CheckedChanged(object sender, EventArgs e)
        {
            tbDevicePassword.UseSystemPasswordChar = !cbShowDevicePassword.Checked;
        }

        private void tbDevicePort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            int num;
            if (!int.TryParse(tbDevicePort.Text, out num))
                return;
            if (num <= 0 || num > 65535)
            {
                tbDevicePort.Text = "Invalid Port!";
                //tbDevicePort.Clear();
            }
        }

        private void tbDevice_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb == null) return;

            string tbName = tb.Name.ToString();
            switch (tbName)
            {
                case "tbDeviceName":
                    if (string.IsNullOrEmpty(tbDeviceName.Text))
                        lblDeviceNameMust.Visible = true;
                    else
                        lblDeviceNameMust.Visible = false;
                    break;
                case "tbDeviceUserName":
                    if (string.IsNullOrEmpty(tbDeviceUserName.Text))
                        lbldeviceUserNameMust.Visible = true;
                    else
                        lbldeviceUserNameMust.Visible = false;
                    break;
                case "tbDevicePassword":
                    if (string.IsNullOrEmpty(tbDevicePassword.Text))
                        lblDevicePasswordMust.Visible = true;
                    else
                        lblDevicePasswordMust.Visible = false;

                    IsPasswordEdited = true;
                    break;
            }
            if (DeviceController != null)
            {
                DeviceController.SetAllFieldsOK(!lblDeviceNameMust.Visible && !lbldeviceUserNameMust.Visible && !lblDevicePasswordMust.Visible);
            }

        }
    }
}
