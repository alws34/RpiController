using RPICommander;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using System.IO;

namespace PiController
{
    public enum LogType
    {
        Warning,
        Error,
        Success,
        Normal,
        Information
    }
    public interface Icommunicator
    {
        void SendMessageToConsole(string message, LogType logType);
    }
    public partial class frmMain : Form, Icommunicator
    {
        private Serializer.SaveObject sv = new Serializer.SaveObject();
        private List<Command> selected_commands = new List<Command>();
        private List<CheckBox> selected_devices = new List<CheckBox>();
        private Serializer serializer = new Serializer();

        public frmMain()
        {
            InitializeComponent();
        }

        private void TbAddNewCommand_KeyUp(object sender, KeyEventArgs e)
        {
            //catch enter 
            //add new command
        }

        #region ICommunicator
        public void SendMessageToConsole(string message, LogType logType)
        {
            Color color = Color.Black;
            switch (logType)
            {
                case LogType.Warning:
                    color = Color.Orange;
                    break;
                case LogType.Error:
                    color = Color.Red;
                    break;
                case LogType.Success:
                    color = Color.Green;
                    break;
                case LogType.Normal:
                    color = Color.Black;
                    break;
                case LogType.Information:
                    color = Color.LightBlue;
                    break;
            }
            string dtformat = "HH:mm:ss tt:  ";
            Action action = () =>
            {
                rtbConsole.SelectionStart = rtbConsole.TextLength;
                rtbConsole.SelectionLength = 0;
                rtbConsole.SelectionColor = color;
                rtbConsole.AppendText($"{DateTime.Now.ToString(dtformat)}{message}{Environment.NewLine}");
                rtbConsole.SelectionColor = rtbConsole.ForeColor;
            };

            INVOKER.InvokeControl(rtbConsole, action);
        }
        #endregion ICommunicator

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
                SendMessageToConsole("Invalid Port", LogType.Warning);
                tbDevicePort.Clear();
            }
        }

        private void ClearDevicePnl()
        {
            tbDeviceName.Clear();
            tbDevicePort.Clear();
            tbDevicePassword.Clear();
            tbDeviceUserName.Clear();
            tbDeviceIP.Clear();
            tbDeviceDescription.Clear();
            tbDeviceLocation.Clear();
        }
        private void cbAddDevice_CheckedChanged(object sender, EventArgs e)
        {
            pnlAddNewDevice.Visible = cbAddDevice.Checked;
            if (!pnlAddNewDevice.Visible)
                ClearDevicePnl();
        }

        private void cbAddCommand_CheckedChanged(object sender, EventArgs e)
        {
            pnlAddNewCommand.Visible = cbAddCommand.Checked;
            if (!pnlAddNewCommand.Visible)
                tbCommand.Clear();//clear command panel
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            Device device = new Device()
            {
                DeviceHostName = tbDeviceName.Text,
                Description = tbDeviceDescription.Text,
                UserName = tbDeviceUserName.Text,
                DeviceLocation = tbDeviceLocation.Text,
                Port = tbDevicePort.Text,
                DeviceIP = tbDeviceIP.Text,
                EncryptionKey = Utils.GenerateEncryptionKey(),
                DeviceId = Utils.GetUniqueID()
            };
            device.Password = Utils.EncryptPassword(tbDevicePassword.Text, device.EncryptionKey);

            CheckBox cb = new CheckBox()
            {
                Tag = device,
                Text = device.DeviceHostName,
            };

            cb.CheckedChanged += DeviceCheckedChanged;
            sv.Devices.Add(device);
            flpCommands.Controls.Add(cb);

            serializer.JsonSerialize_(sv);
        }
        private void DeviceCheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb == null)
                return;

            if (cb.Checked)
                selected_devices.Add(cb);
            else
                selected_devices.Remove(cb);
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

        private void btnRun_Click(object sender, EventArgs e)
        {
            foreach (CheckBox c in selected_devices)
            {
                Device device = c.Tag as Device;
                if (device == null)
                {
                    SendMessageToConsole($"Error Casting Device! @BtnStart_Click", LogType.Error);
                    continue;
                }
                var client = new SshClient(device.DeviceHostName, int.Parse(device.Port), device.UserName, Utils.DecryptPassword(device.Password, device.EncryptionKey));
                client.Connect();
                if (!client.IsConnected)
                {
                    SendMessageToConsole($"couldn't connect to client {device.DeviceHostName} over port {device.Port}\n", LogType.Error);
                    continue;
                }
                SendMessageToConsole($"\r\nconnected to client {device.DeviceHostName} over port {device.Port}\n", LogType.Success);
                foreach (Command command in selected_commands)
                {
                    SshCommand cmd = client.CreateCommand(command.CommandDescription);
                    string result = cmd.Execute();
                    StreamReader reader = new StreamReader(cmd.ExtendedOutputStream);
                    string stderr = reader.ReadToEnd();

                    SendMessageToConsole($"\r\n\tExecuted command ''{command.CommandName}'' on {device.DeviceHostName}\r", LogType.Information);

                    if (!string.IsNullOrWhiteSpace(result))
                        SendMessageToConsole($"Command output: {result}", LogType.Information);
                    if (!string.IsNullOrWhiteSpace(stderr))
                        SendMessageToConsole($"\t{stderr}\n", LogType.Error);
                }
                client.Disconnect();
            }
        }
    }
}
