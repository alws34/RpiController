using RPICommander;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PiController
{
    public partial class frmAddDevice : Form
    {

        private Icommunicator communicator;
        private IController controller;
        private bool IsEdit = false;
        private Device Device_ = null;
        public frmAddDevice(Icommunicator comm, IController con)
        {
            Init(comm, con);
        }

        public frmAddDevice(Icommunicator comm, IController con, Device device = null, bool isEdit = false)
        {
            Init(comm, con);
            SetDeviceView(device);
            IsEdit = isEdit;

            if (isEdit)
            {
                btnAddDevice.Text = "Save Changes";
                Text = "Edit Device";

            }
            Device_ = device;
        }

        private void Init(Icommunicator comm, IController con)
        {
            InitializeComponent();
            CenterToScreen();
            if (comm == null)
                return;
            communicator = comm;
            controller = con;
        }

        private void SetDeviceView(Device device)
        {
            tbDeviceName.Text = device.DeviceHostName;
            tbDeviceUserName.Text = device.UserName;
            tbDeviceIP.Text = device.DeviceIP;
            tbDevicePort.Text = device.Port;
            tbDeviceLocation.Text = device.DeviceLocation;
            tbDevicePassword.Text = device.Password;
        }

        public void SetName(string text) { Text = text; }

        public Device GetDevice(Device dev = null)
        {
            Device device;
            string port = tbDevicePort.Text;
            if (string.IsNullOrEmpty(tbDevicePort.Text))
                port = "22";

            if (!IsEdit)
            {
                device = new Device()
                {
                    DeviceId = Utils.GetUniqueID(),
                    DeviceHostName = tbDeviceName.Text,
                    Password = tbDevicePassword.Text,
                    UserName = tbDeviceUserName.Text,
                    DeviceIP = tbDeviceIP.Text,
                    DeviceLocation = tbDeviceLocation.Text,
                    Description = tbDeviceDescription.Text,
                    Port = port
                };
                device.EncryptionKey = Utils.GenerateKey();
                device.EncryptionKey = Utils.GenerateKey();
                device.Password = Convert.ToString(Utils.EncryptPassword(tbDevicePassword.Text, device.EncryptionKey));

                return device;
            }
            else
            {
                dev.DeviceHostName = tbDeviceName.Text;
                dev.Password = tbDevicePassword.Text;
                dev.UserName = tbDeviceUserName.Text;
                dev.DeviceIP = tbDeviceIP.Text;
                dev.DeviceLocation = tbDeviceLocation.Text;
                dev.Description = tbDeviceDescription.Text;
                dev.Port = port;
                return dev;
            }
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            Device dev;
            if (!IsEdit)
                dev = GetDevice();
            else
                dev = GetDevice(dev: Device_);

            controller.AddDevice(dev);
            communicator.SendMessageToConsole($"Successfully added {dev.DeviceHostName}", LogType.Success);

            Dispose();
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
                communicator.SendMessageToConsole("Invalid Port", LogType.Warning);
                tbDevicePort.Clear();
            }
        }

        private void cbShowDevicePassword_CheckedChanged(object sender, EventArgs e)
        {
            tbDevicePassword.UseSystemPasswordChar = !cbShowDevicePassword.Checked;
        }

        private void tbDeviceName_TextChanged(object sender, EventArgs e)
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
                    break;
            }
            if (!lblDeviceNameMust.Visible && !lbldeviceUserNameMust.Visible && !lblDevicePasswordMust.Visible)
                btnAddDevice.Enabled = true;
            else
                btnAddDevice.Enabled = false;
        }

        private void btnRemoveDevice_Click(object sender, EventArgs e)
        {
            controller.DeleteDevice(GetDevice());
            communicator.SendMessageToConsole($"Successfully added {GetDevice().DeviceHostName} to DB", LogType.Success);
            Dispose();
        }
    }
}
