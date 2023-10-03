using PiController.DeviceController;
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
    public partial class frmAddDevice : Form, IDeviceController
    {

        private Icommunicator communicator;
        private IController controller;
        private bool IsEdit = false;
        private bool didPasswordEdited = false;
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
            deviceControllerUC.DeviceController = this;
        }

        private void SetDeviceView(Device device)
        {
            deviceControllerUC.SetDeviceName(device.DeviceHostName);
            deviceControllerUC.SetDeviceUserName(device.UserName);
            deviceControllerUC.SetDeviceIP(device.DeviceIP);
            deviceControllerUC.SetDevicePort(device.Port);
            deviceControllerUC.SetDeviceLocation(device.DeviceLocation);
            deviceControllerUC.SetDevicePassword(Utils.DecryptPassword(device.Password, device.EncryptionKey, device.Salt));
            deviceControllerUC.SetDeviceDescription(device.Description);
        }

        public void SetName(string text) { Text = text; }

        public Device GetDevice(Device dev = null)
        {
            string port = deviceControllerUC.GetDevicePort() ?? "22"; // Use "22" as default if port is null or empty.

            if (dev == null)
            {
                dev = new Device();
                dev.DeviceHostName = deviceControllerUC.GetDeviceName();
                dev.UserName = deviceControllerUC.GetDeviceUserName();
                dev.DeviceIP = deviceControllerUC.GetDeviceIP();
                dev.DeviceLocation = deviceControllerUC.GetDeviceLocation();
                dev.Description = deviceControllerUC.GetDeviceDescription();
                dev.Port = port;

                if (!IsEdit)
                {
                    dev.Password = Convert.ToString(Utils.EncryptPassword(deviceControllerUC.GetDevicePassword(), dev.EncryptionKey, dev.Salt));
                }
                else if (IsEdit && deviceControllerUC.IsPasswordEdited)
                {
                    // Re-encrypt new password
                    dev.EncryptionKey = Utils.GenerateKey();
                    dev.Salt = Utils.GenerateSalt();
                    dev.Password = Utils.EncryptPassword(deviceControllerUC.GetDevicePassword(), dev.EncryptionKey, dev.Salt);
                }
                else if (IsEdit)
                {
                    // Keep the existing password
                    dev.Password = deviceControllerUC.GetDevicePassword();
                }
            }
            else if (IsEdit)
            {
                // Update the existing device
                dev.DeviceId = dev.DeviceId;
                dev.DeviceHostName = deviceControllerUC.GetDeviceName();
                dev.UserName = deviceControllerUC.GetDeviceUserName();
                dev.DeviceIP = deviceControllerUC.GetDeviceIP();
                dev.DeviceLocation = deviceControllerUC.GetDeviceLocation();
                dev.Description = deviceControllerUC.GetDeviceDescription();
                dev.Port = port;

                if (deviceControllerUC.IsPasswordEdited)
                {
                    // Re-encrypt new password
                    dev.EncryptionKey = Utils.GenerateKey();
                    dev.Salt = Utils.GenerateSalt();
                    dev.Password = Utils.EncryptPassword(deviceControllerUC.GetDevicePassword(), dev.EncryptionKey, dev.Salt);
                }
                else
                {
                    // Keep the existing password
                    dev.Password = deviceControllerUC.GetDevicePassword();
                }
            }
          
            return dev;
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            Device dev;
            if (!IsEdit)
            {
                dev = GetDevice();
                controller.AddDevice(dev);
                communicator.SendMessageToConsole($"Successfully Added new device: {dev.DeviceHostName}", LogType.Success);
            }
            else
            {
                dev = GetDevice(dev: Device_);
                controller.EditDevice(dev);
                communicator.SendMessageToConsole($"Successfully Edited: {dev.DeviceHostName}", LogType.Success);
            }
            Dispose();
        }

        private void btnRemoveDevice_Click(object sender, EventArgs e)
        {
            controller.DeleteDevice(GetDevice());
            communicator.SendMessageToConsole($"Successfully added {GetDevice().DeviceHostName} to DB", LogType.Success);
            Dispose();
        }

        #region IDeviceController
        public void SetAllFieldsOK(bool isFieldOK)
        {
            btnAddDevice.Enabled = isFieldOK;
        }
        #endregion IDeviceController
    }
}
