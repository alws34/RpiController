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
            flpDevices.Controls.Clear();
            Dictionary<string, int> textCounts = new Dictionary<string, int>();

            foreach (Device device in sv.Devices.Values)
            {
                string deviceText = device.DeviceHostName;

                if (textCounts.ContainsKey(deviceText))
                {
                    int count = textCounts[deviceText] + 1;
                    textCounts[deviceText] = count;
                    deviceText = $"{deviceText}_({count})";
                }

                CheckBox checkBox = GetDeviceCB(device);
                checkBox.Text = deviceText;
                flpDevices.Controls.Add(checkBox);
            }
        }



        private void LoadCommands()
        {
            flpcommands.Controls.Clear();
            foreach (Command command in sv.Commands.Values)
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
                    sv.Commands = new ConcurrentDictionary<string, Command>();
                    sv.Devices = new ConcurrentDictionary<string, Device>();
                    return;
                }

                if (sv.Devices == null)
                {
                    SendMessageToConsole($"No devices were read from DB", LogType.Information);
                    sv.Devices = new ConcurrentDictionary<string, Device>();
                    return;
                }
                if (sv.Commands == null)
                {
                    sv.Commands = new ConcurrentDictionary<string, Command>();
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
            LoadDevices();
        }
        private void ReloadCommands()
        {
            LoadFromDB();
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

        private Task SendMessageToConsoleAsync(string message, LogType logType)
        {
            return Task.Run(() =>
            {
                SendMessageToConsole(message, logType);
            });
        }

        #region IController
        public void EditDevice(Device device)
        {
            if (device != null)
            {
                sv.Devices.AddOrUpdate(device.DeviceId, device, (key, oldValue) => device);

                SaveDB();
                ReloadDevices();
            }
        }

        public void AddDevice(Device device)
        {
            if (device != null)
            {
                sv.Devices.AddOrUpdate(device.DeviceId, device, (key, oldValue) => device);

                SaveDB();
                flpDevices.Controls.Add(GetDeviceCB(device));
            }
        }

        public void DeleteDevice(Device device)
        {
            TextBox textBoxToDelete = flpDevices.Controls
                .OfType<TextBox>()
                .FirstOrDefault(tb => ((Device)tb.Tag).Equals(device));

            if (textBoxToDelete != null)
            {
                textBoxToDelete.Dispose();
            }
        }


        public void AddCommand(Command command)
        {
            sv.Commands.AddOrUpdate(command.CommandID, command, (key, oldValue) => command);
            SaveDB();
            flpcommands.Controls.Add(GetCommandCB(command));
            ReloadCommands();
        }

        public void EditCommand(Command command)
        {
            if (command != null)
            {
                sv.Commands.AddOrUpdate(command.CommandID, command, (key, oldValue) => command);
                SaveDB();
                ReloadCommands();
            }
        }

        public void DeleteCommand(Command command)
        {
            TextBox textBoxToDelete = flpcommands.Controls
                .OfType<TextBox>()
                .FirstOrDefault(tb => ((Command)tb.Tag).Equals(command));

            if (textBoxToDelete != null)
            {
                textBoxToDelete.Dispose();
            }
        }


        #endregion IController

        CheckBox GetCB(object obj)
        {
            CheckBox cb = new CheckBox
            {
                Tag = obj,
                ForeColor = Color.Black
            };
            cb.CheckedChanged += Cb_CheckedChanged;
            cb.MouseEnter += Cb_MouseEnter;

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

            if (cb == null || cb.Tag == null)
            {
                return;
            }

            if (cb.Name == "DeviceCB" && cb.Tag is Device device)
            {
                t.SetToolTip(cb, device.Description);
            }
            else if (cb.Name == "CommandCB" && cb.Tag is Command command)
            {
                t.SetToolTip(cb, command.CommandDescription);
            }
        }


        private void Cb_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb == null || cb.Tag == null)
                return;

            if (cb.Name == "DeviceCB" && cb.Tag is Device device)
            {
                HandleCheckboxChange(device, ref selected_devices, ref CurrentDevice, cb.Checked);
            }
            else if (cb.Name == "CommandCB" && cb.Tag is Command command)
            {
                HandleCheckboxChange(command, ref selected_commands, ref currentCommand, cb.Checked);
            }
        }

        private void HandleCheckboxChange<T>(T item, ref List<T> selectedItems, ref T currentItem, bool isChecked)
        {
            if (isChecked)
            {
                selectedItems.Add(item);
                currentItem = item;
            }
            else
            {
                selectedItems.Remove(item);
                currentItem = default(T);
            }
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {

            await RunCommandsAsync();
        }

        private Task ExecuteCommandAsync(SshClient client, SshCommand cmd)
        {
            return Task.Run(() =>
            {
                if (!client.IsConnected)
                {
                    SendMessageToConsole("SSH client is not connected.", LogType.Error);
                    return;
                }

                cmd.Execute();
            });
        }

        private SshClient ConnectToDevice(Device device, string password)
        {
            SshClient sshClient = null;

            try
            {
                sshClient = new SshClient(device.DeviceHostName, int.Parse(device.Port), device.UserName, password);
                sshClient.Connect();
            }
            catch (Exception e)
            {
                if (!string.IsNullOrEmpty(device.DeviceIP))
                {
                    SendMessageToConsole($"Couldn't connect to client {device.DeviceHostName}. Retrying using the given IP: {device.DeviceIP}", LogType.Error);
                    sshClient = ConnectToDeviceWithIP(device, password);
                }
                else
                {
                    SendMessageToConsole($"Couldn't connect to client {device.DeviceHostName} and no IP to fall back to", LogType.Error);
                }
            }

            return sshClient;
        }

        private SshClient ConnectToDeviceWithIP(Device device, string password)
        {
            SshClient sshClient = null;

            try
            {
                sshClient = new SshClient(device.DeviceIP, int.Parse(device.Port), device.UserName, password);
                sshClient.Connect();
            }
            catch (Exception ex)
            {
                SendMessageToConsole($"Couldn't connect to client {device.DeviceHostName} using IP: {device.DeviceIP}", LogType.Error);
            }

            return sshClient;
        }

        private async Task RunCommandsAsync()
        {
            INVOKER.InvokeControl(pnlMain, () => SetUiToBusyState());

            foreach (Device device in selected_devices)
            {
                string password = Utils.DecryptPassword(device.Password, device.EncryptionKey, device.Salt);

                if (password == null)
                {
                    SendMessageToConsole($"Couldn't Decrypt {device.DeviceHostName}'s Password. Cannot continue with this device!", LogType.Error);
                    continue;
                }

                var client = ConnectToDevice(device, password);

                if (!client.IsConnected)
                {
                    SendMessageToConsole($"Couldn't connect to client {device.DeviceHostName} over port {device.Port}", LogType.Error);
                    continue;
                }

                SendMessageToConsole($"Connected to client {device.DeviceHostName} successfully over port {device.Port}", LogType.Success);

                foreach (Command command in selected_commands)
                {
                    try
                    {
                        SshCommand cmd = client.CreateCommand(command.ShellCommand);
                        Task executionTask = ExecuteCommandAsync(client, cmd);

                        using (var outputReader = new StreamReader(cmd.OutputStream))
                        using (var errorReader = new StreamReader(cmd.ExtendedOutputStream))
                        {
                            Task outputTask = StreamOutputAsync(outputReader);
                            Task errorTask = StreamOutputAsync(errorReader);

                            await executionTask;
                            await Task.WhenAll(outputTask, errorTask);
                        }

                        SendMessageToConsole($"Executed command \"{command.CommandName}\" Successfully on {device.DeviceHostName}", LogType.Success);
                    }
                    catch (Exception ex)
                    {
                        SendMessageToConsole($"Error while running Command \"{command.CommandName}\" on {device.DeviceHostName}\n\t{ex}", LogType.Error);
                    }
                }
                client.Disconnect();
            }

            INVOKER.InvokeControl(pnlMain, () => SetUiToNormalState());
        }

        private async Task StreamOutputAsync(StreamReader reader)
        {
            while (!reader.EndOfStream)
            {
                try
                {
                    string output = await reader.ReadLineAsync();
                    if (!string.IsNullOrEmpty(output))
                        await SendMessageToConsoleAsync(output, LogType.Normal);
                }
                catch (Exception ex)
                {
                    await SendMessageToConsoleAsync($"{ex}", LogType.Error);
                }
            }
        }

        private void SetUiToBusyState()
        {
            pnlMain.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
        }

        private void SetUiToNormalState()
        {
            pnlMain.Enabled = true;
            Cursor.Current = Cursors.Default;
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

            // Find and remove the CheckBox from flpDevices
            CheckBox checkBoxToRemove = flpDevices.Controls
                .OfType<CheckBox>()
                .FirstOrDefault(tb => ((Device)tb.Tag).Equals(CurrentDevice));

            if (checkBoxToRemove != null)
            {
                flpDevices.Controls.Remove(checkBoxToRemove);
                checkBoxToRemove.Dispose();
            }

            // Remove the device from sv.Devices
            if (sv.Devices.TryRemove(CurrentDevice.DeviceId, out _))
                CurrentDevice = null;
            else
            {
                SendMessageToConsole($"Error while trying to remove Device {CurrentDevice.DeviceHostName}", LogType.Error);
                return;
            }
            SaveDB();
        }

        private void btnEditDevice_Click(object sender, EventArgs e)
        {
            if (CurrentDevice == null)
            {
                SendMessageToConsole("No Device Selected to edit", LogType.Warning);
                return;
            }

            frmAddDevice addDevicefrm = new frmAddDevice(this, this, CurrentDevice, true);
            addDevicefrm.Show();
        }
        #endregion DevicesButtons

        private void btnAddNewCommand_Click(object sender, EventArgs e)
        {
            frmCommandController AddCommandfrm = new frmCommandController(this, this);
            AddCommandfrm.Show();
        }

        private void btnRemoveCommand_Click(object sender, EventArgs e)
        {
            if (currentCommand == null)
            {
                SendMessageToConsole("No Command Selected", LogType.Warning);
                return;
            }

            // Find and remove the CheckBox from flpcommands
            CheckBox checkBoxToRemove = flpcommands.Controls
                .OfType<CheckBox>()
                .FirstOrDefault(cb => ((Command)cb.Tag).Equals(currentCommand));

            if (checkBoxToRemove != null)
            {
                flpcommands.Controls.Remove(checkBoxToRemove);
                checkBoxToRemove.Dispose();
            }

            // Remove the command from sv.Commands
            if (sv.Commands.TryRemove(currentCommand.CommandID, out _))
                currentCommand = null;
            else
            {
                SendMessageToConsole($"Error while trying to remove Command {currentCommand.CommandName}", LogType.Error);
                return;
            }
            SaveDB();
        }

        private void btnEditCommand_Click(object sender, EventArgs e)
        {
            if (currentCommand == null)
            {
                SendMessageToConsole("No Command Selected to edit", LogType.Warning);
                return;
            }

            frmCommandController AddCommandfrm = new frmCommandController(this, this, currentCommand, true);
            AddCommandfrm.Show();
        }
    }
}
