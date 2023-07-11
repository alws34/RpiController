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
using System.Collections.Concurrent;
using System.Xml.Linq;

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
    public interface IController
    {
        void EditDevice(Device device);
        void AddDevice(Device device);
        void DeleteDevice(Device device);
        void AddCommand(Command command);
        void EditCommand(Command command);
        void DeleteCommand(Command command);
    }

    public partial class frmMain : Form, Icommunicator, IController
    {
        private SaveObject sv;
        private List<Command> selected_commands = new List<Command>();
        private List<Device> selected_devices = new List<Device>();
        private Serializer serializer;
        Device CurrentDevice = null;
        Command currentCommand = null;

        public frmMain()
        {
            InitializeComponent();
            CenterToScreen();
            sv = new SaveObject();
            serializer = new Serializer();
            LoadFromDB();
            if (sv.Devices.Count > 0)
                LoadDevices();
            if (sv.Commands.Count > 0)
                LoadCommands();
        }
        private void SaveDB()
        {
            serializer.JsonSerialize_(sv);
        }
        private void LoadDevices()
        {
            foreach (Device device in sv.Devices)
                flpDevices.Controls.Add(GetDeviceCB(device));
        }
        private void LoadCommands()
        {
            foreach (Command command in sv.Commands)
                flpcommands.Controls.Add(GetCommandCB(command));
        }
        private void LoadFromDB()
        {
            try
            {
                string path = serializer.GetDBPath();
                if (!Directory.Exists(Path.GetDirectoryName(path)))
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                if (!File.Exists(path))
                    File.Create(path).Close();

                sv = (SaveObject)serializer.JsonDeserialize_(sv.GetType(), path);

                if (sv == null)
                {
                    SendMessageToConsole($"Could not read from DB file", LogType.Information);
                    sv = new SaveObject();
                    return;
                }
                if (sv.Devices == null)
                {
                    SendMessageToConsole($"No devices were read from DB", LogType.Information);
                    sv.Devices = new ConcurrentBag<Device>();
                    return;
                }
                if (sv.Commands == null)
                {
                    sv.Commands = new ConcurrentBag<Command>();
                    SendMessageToConsole($"No commands were read from DB", LogType.Information);
                    return;
                }
                else
                {
                    SendMessageToConsole($"Read {sv.Devices.Count} Devices and {sv.Commands.Count} Commands from DB", LogType.Information);
                }

            }
            catch (Exception e) { SendMessageToConsole($"{e}", LogType.Error); }

        }
        private void TbAddNewCommand_KeyUp(object sender, KeyEventArgs e)
        {
            //catch enter 
            //add new command
        }

        private void ReloadDevices()
        {
            LoadFromDB();
            flpDevices.Controls.Clear();
            LoadDevices();
        }
        private void ReloadCommands()
        {
            LoadFromDB();
            flpcommands.Controls.Clear();
            LoadCommands();
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
                    color = Color.Blue;
                    break;
            }
            string dtformat = "HH:mm:ss tt ";
            Action action = () =>
            {
                rtbConsole.SelectionStart = rtbConsole.TextLength;
                rtbConsole.SelectionLength = 0;
                rtbConsole.SelectionColor = color;
                rtbConsole.AppendText($"{DateTime.Now.ToString(dtformat)}:{message}{Environment.NewLine}");
                rtbConsole.SelectionColor = rtbConsole.ForeColor;
            };

            INVOKER.InvokeControl(rtbConsole, action);
        }
        #endregion ICommunicator

        #region IController
        public void EditDevice(Device device)
        {
            Device oldDevice = sv.Devices.FirstOrDefault(dev => dev.DeviceId == device.DeviceId);
            if (oldDevice != null)
            {
                sv.Devices.TryTake(out oldDevice);
                sv.Devices.Add(device);
            }
            SaveDB();
            ReloadDevices();
        }

        public void AddDevice(Device device)
        {
            sv.Devices.Add(device);
            SaveDB();
            flpDevices.Controls.Add(GetDeviceCB(device));
        }

        public void DeleteDevice(Device device)
        {
            foreach (TextBox tb in flpDevices.Controls)
            {
                if (((Device)tb.Tag).Equals(device))
                {
                    tb.Dispose();
                    return;
                }
            }
        }

        public void AddCommand(Command command)
        {
            sv.Commands.Add(command);
            SaveDB();
            flpcommands.Controls.Add(GetCommandCB(command));
            ReloadCommands();
        }

        public void EditCommand(Command command)
        {
            Command oldCommand = sv.Commands.FirstOrDefault(com => com.CommandID == command.CommandID);
            if (oldCommand != null)
            {
                sv.Commands.TryTake(out oldCommand);
                sv.Commands.Add(command);
            }
            SaveDB();
            ReloadCommands();
        }

        public void DeleteCommand(Command command)
        {
            foreach (TextBox tb in flpcommands.Controls)
            {
                if (((Command)tb.Tag).Equals(command))
                {
                    tb.Dispose();
                    return;
                }
            }
        }

        #endregion IController

        CheckBox GetCB(object obj)
        {
            CheckBox cb = new CheckBox()
            {
                Tag = obj,
            };
            cb.CheckedChanged += Cb_CheckedChanged;
            cb.MouseEnter += Cb_MouseEnter;

            cb.ForeColor = Color.Black;
            return cb;
        }

        CheckBox GetCommandCB(Command command)
        {
            CheckBox cb = GetCB(command);
            cb.Name = "CommandCB";
            cb.Text = command.CommandName;
            return cb;
        }

        CheckBox GetDeviceCB(Device device)
        {
            CheckBox cb = GetCB(device);
            cb.Name = "DeviceCB";
            cb.Text = device.DeviceHostName;
            return cb;
        }

        private void Cb_MouseEnter(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            CheckBox cb = sender as CheckBox;

            switch (cb.Name)
            {
                case "DeviceCB":
                    t.SetToolTip(cb, ((Device)(cb.Tag)).Description);
                    break;
                case "CommandCB":
                    t.SetToolTip(cb, ((Command)(cb.Tag)).CommandDescription);
                    break;
            }
        }

        private void Cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb == null)
                return;

            switch (cb.Name)
            {
                case "DeviceCB":
                    if (cb.Checked)
                    {
                        selected_devices.Add((Device)cb.Tag);
                        CurrentDevice = (Device)cb.Tag;
                    }
                    else
                    {
                        selected_devices.Remove((Device)cb.Tag);
                        CurrentDevice = null;
                    }
                    break;
                case "CommandCB":
                    if (cb.Checked)
                    {
                        selected_commands.Add((Command)cb.Tag);
                        currentCommand = (Command)cb.Tag;
                    }
                    else
                    {
                        selected_commands.Remove((Command)cb.Tag);
                        currentCommand = null;
                    }
                    break;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            Thread runCommands = new Thread(RunCommands);
            runCommands.Start();
        }

        private void RunCommands()
        {
            foreach (Device device in selected_devices)
            {
                string password = Utils.DecryptPassword(device.Password, device.EncryptionKey);
                var client = new SshClient(device.DeviceHostName, int.Parse(device.Port), device.UserName, password);
                client.Connect();
                if (!client.IsConnected)
                {
                    SendMessageToConsole($"couldn't connect to client {device.DeviceHostName} over port {device.Port}\n", LogType.Error);
                    continue;
                }
                SendMessageToConsole($"\r\nconnected to client {device.DeviceHostName} over port {device.Port}\n", LogType.Success);
                pnlMain.Enabled = false;
                foreach (Command command in selected_commands)
                {
                    try
                    {
                        SshCommand cmd = client.CreateCommand(command.ShellCommand);

                        // Start asynchronous execution of the command
                        IAsyncResult result = cmd.BeginExecute();

                        // Create async readers for output and error streams
                        StreamReader outputReader = new StreamReader(cmd.OutputStream);
                        StreamReader errorReader = new StreamReader(cmd.ExtendedOutputStream);

                        // Read output and error streams asynchronously
                        while (!result.IsCompleted || !outputReader.EndOfStream || !errorReader.EndOfStream)
                        {
                            if (!outputReader.EndOfStream)
                            {
                                string output = outputReader.ReadLine();
                                if (!string.IsNullOrEmpty(output))
                                    SendMessageToConsole(output, LogType.Normal);
                            }
                            if (!errorReader.EndOfStream)
                            {
                                string error = errorReader.ReadLine();
                                if (!string.IsNullOrEmpty(error))
                                    SendMessageToConsole(error, LogType.Error);
                            }
                        }
                        // Wait for command execution to complete
                        cmd.EndExecute(result);

                        SendMessageToConsole($"\r\n\tExecuted command \"{command.CommandName}\" Successfully on {device.DeviceHostName}", LogType.Success);
                    }
                    catch (Exception ex)
                    {
                        SendMessageToConsole($"Error while running Command \"{command.CommandName}\" on {device.DeviceHostName}\n\t{ex}", LogType.Error);
                        continue;
                    }

                }
                pnlMain.Enabled = true;
                client.Disconnect();
            }
        }

        #region DevicesButtons
        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            frmAddDevice addDevicefrm = new frmAddDevice(this, this);
            addDevicefrm.Show();
        }

        private void btnRemoveDevice_Click(object sender, EventArgs e)
        {
            if (CurrentDevice == null)
            {
                SendMessageToConsole("No Device Selected", LogType.Warning);
                return;
            }

            foreach (CheckBox tb in flpDevices.Controls)
            {
                if (((Device)tb.Tag).Equals(CurrentDevice))
                {
                    tb.Dispose();
                    break;
                }
            }
            sv.Devices.TryTake(out CurrentDevice);
            CurrentDevice = null;
            SaveDB();
        }

        private void btnEditDevice_Click(object sender, EventArgs e)
        {
            if (CurrentDevice == null)
            {
                SendMessageToConsole("No Device Selected to edit", LogType.Warning);
                return;
            }

            frmAddDevice addDevicefrm = new frmAddDevice(this, this, CurrentDevice);
            addDevicefrm.Show();
        }
        #endregion DevicesButtons

        private void btnAddNewCommand_Click(object sender, EventArgs e)
        {
            frmAddCommand AddCommandfrm = new frmAddCommand(this, this);
            AddCommandfrm.Show();
        }

        private void btnRemoveCommand_Click(object sender, EventArgs e)
        {
            if (currentCommand == null)
            {
                SendMessageToConsole("No Device Selected", LogType.Warning);
                return;
            }

            foreach (CheckBox tb in flpcommands.Controls)
            {
                if (((Command)tb.Tag).Equals(currentCommand))
                {
                    tb.Dispose();
                    break;
                }
            }
            sv.Commands.TryTake(out currentCommand);
            currentCommand = null;
            SaveDB();
        }

        private void btnEditCommand_Click(object sender, EventArgs e)
        {
            if (currentCommand == null)
            {
                SendMessageToConsole("No Command Selected to edit", LogType.Warning);
                return;
            }

            frmAddCommand AddCommandfrm = new frmAddCommand(this, this, currentCommand, true);
            AddCommandfrm.Show();
        }
    }
}
