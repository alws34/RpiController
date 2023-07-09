namespace PiController
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.pnlAddNewCommand = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCommandDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCommandName = new System.Windows.Forms.TextBox();
            this.btnAddCommand = new System.Windows.Forms.Button();
            this.pnlAddNewDevice = new System.Windows.Forms.Panel();
            this.btnRemoveDevice = new System.Windows.Forms.Button();
            this.lblDevicePasswordMust = new System.Windows.Forms.Label();
            this.lbldeviceUserNameMust = new System.Windows.Forms.Label();
            this.lblDeviceNameMust = new System.Windows.Forms.Label();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.lblDeviceDescription = new System.Windows.Forms.Label();
            this.tbDeviceDescription = new System.Windows.Forms.TextBox();
            this.lblDeviceLocation = new System.Windows.Forms.Label();
            this.tbDeviceLocation = new System.Windows.Forms.TextBox();
            this.cbShowDevicePassword = new System.Windows.Forms.CheckBox();
            this.lblDeviceIP = new System.Windows.Forms.Label();
            this.tbDeviceIP = new System.Windows.Forms.TextBox();
            this.lblDevicePort = new System.Windows.Forms.Label();
            this.tbDevicePort = new System.Windows.Forms.TextBox();
            this.lblDevicePassword = new System.Windows.Forms.Label();
            this.tbDevicePassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbDeviceUserName = new System.Windows.Forms.TextBox();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.tbDeviceName = new System.Windows.Forms.TextBox();
            this.cbAddDevice = new System.Windows.Forms.CheckBox();
            this.cbAddCommand = new System.Windows.Forms.CheckBox();
            this.flpCommands = new System.Windows.Forms.FlowLayoutPanel();
            this.flpDevices = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRun = new System.Windows.Forms.Button();
            this.pnlAddNewCommand.SuspendLayout();
            this.pnlAddNewDevice.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbConsole
            // 
            this.rtbConsole.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.rtbConsole.Location = new System.Drawing.Point(447, 365);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.ReadOnly = true;
            this.rtbConsole.Size = new System.Drawing.Size(583, 254);
            this.rtbConsole.TabIndex = 0;
            this.rtbConsole.Text = "";
            // 
            // pnlAddNewCommand
            // 
            this.pnlAddNewCommand.Controls.Add(this.label3);
            this.pnlAddNewCommand.Controls.Add(this.tbCommand);
            this.pnlAddNewCommand.Controls.Add(this.label2);
            this.pnlAddNewCommand.Controls.Add(this.tbCommandDescription);
            this.pnlAddNewCommand.Controls.Add(this.label1);
            this.pnlAddNewCommand.Controls.Add(this.tbCommandName);
            this.pnlAddNewCommand.Controls.Add(this.btnAddCommand);
            this.pnlAddNewCommand.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.pnlAddNewCommand.Location = new System.Drawing.Point(3, 296);
            this.pnlAddNewCommand.Name = "pnlAddNewCommand";
            this.pnlAddNewCommand.Size = new System.Drawing.Size(437, 198);
            this.pnlAddNewCommand.TabIndex = 3;
            this.pnlAddNewCommand.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(8, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Command";
            // 
            // tbCommand
            // 
            this.tbCommand.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbCommand.Location = new System.Drawing.Point(12, 140);
            this.tbCommand.Multiline = true;
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(421, 50);
            this.tbCommand.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Command Desription";
            // 
            // tbCommandDescription
            // 
            this.tbCommandDescription.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbCommandDescription.Location = new System.Drawing.Point(8, 61);
            this.tbCommandDescription.Multiline = true;
            this.tbCommandDescription.Name = "tbCommandDescription";
            this.tbCommandDescription.Size = new System.Drawing.Size(315, 59);
            this.tbCommandDescription.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Command Name";
            // 
            // tbCommandName
            // 
            this.tbCommandName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbCommandName.Location = new System.Drawing.Point(146, 6);
            this.tbCommandName.Name = "tbCommandName";
            this.tbCommandName.Size = new System.Drawing.Size(177, 27);
            this.tbCommandName.TabIndex = 20;
            // 
            // btnAddCommand
            // 
            this.btnAddCommand.Enabled = false;
            this.btnAddCommand.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCommand.Location = new System.Drawing.Point(329, 0);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.Size = new System.Drawing.Size(104, 66);
            this.btnAddCommand.TabIndex = 19;
            this.btnAddCommand.Text = "Add Command";
            this.btnAddCommand.UseVisualStyleBackColor = true;
            // 
            // pnlAddNewDevice
            // 
            this.pnlAddNewDevice.Controls.Add(this.btnRemoveDevice);
            this.pnlAddNewDevice.Controls.Add(this.lblDevicePasswordMust);
            this.pnlAddNewDevice.Controls.Add(this.lbldeviceUserNameMust);
            this.pnlAddNewDevice.Controls.Add(this.lblDeviceNameMust);
            this.pnlAddNewDevice.Controls.Add(this.btnAddDevice);
            this.pnlAddNewDevice.Controls.Add(this.lblDeviceDescription);
            this.pnlAddNewDevice.Controls.Add(this.tbDeviceDescription);
            this.pnlAddNewDevice.Controls.Add(this.lblDeviceLocation);
            this.pnlAddNewDevice.Controls.Add(this.tbDeviceLocation);
            this.pnlAddNewDevice.Controls.Add(this.cbShowDevicePassword);
            this.pnlAddNewDevice.Controls.Add(this.lblDeviceIP);
            this.pnlAddNewDevice.Controls.Add(this.tbDeviceIP);
            this.pnlAddNewDevice.Controls.Add(this.lblDevicePort);
            this.pnlAddNewDevice.Controls.Add(this.tbDevicePort);
            this.pnlAddNewDevice.Controls.Add(this.lblDevicePassword);
            this.pnlAddNewDevice.Controls.Add(this.tbDevicePassword);
            this.pnlAddNewDevice.Controls.Add(this.lblUserName);
            this.pnlAddNewDevice.Controls.Add(this.tbDeviceUserName);
            this.pnlAddNewDevice.Controls.Add(this.lblDeviceName);
            this.pnlAddNewDevice.Controls.Add(this.tbDeviceName);
            this.pnlAddNewDevice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.pnlAddNewDevice.Location = new System.Drawing.Point(3, 3);
            this.pnlAddNewDevice.Name = "pnlAddNewDevice";
            this.pnlAddNewDevice.Size = new System.Drawing.Size(437, 287);
            this.pnlAddNewDevice.TabIndex = 4;
            this.pnlAddNewDevice.Visible = false;
            // 
            // btnRemoveDevice
            // 
            this.btnRemoveDevice.Enabled = false;
            this.btnRemoveDevice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveDevice.Location = new System.Drawing.Point(330, 144);
            this.btnRemoveDevice.Name = "btnRemoveDevice";
            this.btnRemoveDevice.Size = new System.Drawing.Size(104, 66);
            this.btnRemoveDevice.TabIndex = 24;
            this.btnRemoveDevice.Text = "Remove Device";
            this.btnRemoveDevice.UseVisualStyleBackColor = true;
            // 
            // lblDevicePasswordMust
            // 
            this.lblDevicePasswordMust.AutoSize = true;
            this.lblDevicePasswordMust.Location = new System.Drawing.Point(96, 72);
            this.lblDevicePasswordMust.Name = "lblDevicePasswordMust";
            this.lblDevicePasswordMust.Size = new System.Drawing.Size(16, 19);
            this.lblDevicePasswordMust.TabIndex = 23;
            this.lblDevicePasswordMust.Text = "*";
            // 
            // lbldeviceUserNameMust
            // 
            this.lbldeviceUserNameMust.AutoSize = true;
            this.lbldeviceUserNameMust.Location = new System.Drawing.Point(97, 39);
            this.lbldeviceUserNameMust.Name = "lbldeviceUserNameMust";
            this.lbldeviceUserNameMust.Size = new System.Drawing.Size(16, 19);
            this.lbldeviceUserNameMust.TabIndex = 22;
            this.lbldeviceUserNameMust.Text = "*";
            // 
            // lblDeviceNameMust
            // 
            this.lblDeviceNameMust.AutoSize = true;
            this.lblDeviceNameMust.Location = new System.Drawing.Point(97, 6);
            this.lblDeviceNameMust.Name = "lblDeviceNameMust";
            this.lblDeviceNameMust.Size = new System.Drawing.Size(16, 19);
            this.lblDeviceNameMust.TabIndex = 21;
            this.lblDeviceNameMust.Text = "*";
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Enabled = false;
            this.btnAddDevice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddDevice.Location = new System.Drawing.Point(329, 216);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(104, 66);
            this.btnAddDevice.TabIndex = 20;
            this.btnAddDevice.Text = "Add Device";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // lblDeviceDescription
            // 
            this.lblDeviceDescription.AutoSize = true;
            this.lblDeviceDescription.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeviceDescription.Location = new System.Drawing.Point(3, 230);
            this.lblDeviceDescription.Name = "lblDeviceDescription";
            this.lblDeviceDescription.Size = new System.Drawing.Size(99, 19);
            this.lblDeviceDescription.TabIndex = 17;
            this.lblDeviceDescription.Text = "Description";
            // 
            // tbDeviceDescription
            // 
            this.tbDeviceDescription.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbDeviceDescription.Location = new System.Drawing.Point(119, 199);
            this.tbDeviceDescription.Multiline = true;
            this.tbDeviceDescription.Name = "tbDeviceDescription";
            this.tbDeviceDescription.Size = new System.Drawing.Size(204, 83);
            this.tbDeviceDescription.TabIndex = 16;
            // 
            // lblDeviceLocation
            // 
            this.lblDeviceLocation.AutoSize = true;
            this.lblDeviceLocation.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeviceLocation.Location = new System.Drawing.Point(3, 169);
            this.lblDeviceLocation.Name = "lblDeviceLocation";
            this.lblDeviceLocation.Size = new System.Drawing.Size(77, 19);
            this.lblDeviceLocation.TabIndex = 15;
            this.lblDeviceLocation.Text = "Location";
            // 
            // tbDeviceLocation
            // 
            this.tbDeviceLocation.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbDeviceLocation.Location = new System.Drawing.Point(119, 166);
            this.tbDeviceLocation.Name = "tbDeviceLocation";
            this.tbDeviceLocation.Size = new System.Drawing.Size(204, 27);
            this.tbDeviceLocation.TabIndex = 14;
            // 
            // cbShowDevicePassword
            // 
            this.cbShowDevicePassword.AutoSize = true;
            this.cbShowDevicePassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.cbShowDevicePassword.Location = new System.Drawing.Point(329, 61);
            this.cbShowDevicePassword.Name = "cbShowDevicePassword";
            this.cbShowDevicePassword.Size = new System.Drawing.Size(109, 42);
            this.cbShowDevicePassword.TabIndex = 13;
            this.cbShowDevicePassword.Text = "Show\r\nPassword";
            this.cbShowDevicePassword.UseVisualStyleBackColor = true;
            this.cbShowDevicePassword.CheckedChanged += new System.EventHandler(this.cbShowDevicePassword_CheckedChanged);
            // 
            // lblDeviceIP
            // 
            this.lblDeviceIP.AutoSize = true;
            this.lblDeviceIP.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeviceIP.Location = new System.Drawing.Point(3, 136);
            this.lblDeviceIP.Name = "lblDeviceIP";
            this.lblDeviceIP.Size = new System.Drawing.Size(24, 19);
            this.lblDeviceIP.TabIndex = 12;
            this.lblDeviceIP.Text = "IP";
            // 
            // tbDeviceIP
            // 
            this.tbDeviceIP.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbDeviceIP.Location = new System.Drawing.Point(119, 133);
            this.tbDeviceIP.Name = "tbDeviceIP";
            this.tbDeviceIP.Size = new System.Drawing.Size(204, 27);
            this.tbDeviceIP.TabIndex = 11;
            // 
            // lblDevicePort
            // 
            this.lblDevicePort.AutoSize = true;
            this.lblDevicePort.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDevicePort.Location = new System.Drawing.Point(3, 105);
            this.lblDevicePort.Name = "lblDevicePort";
            this.lblDevicePort.Size = new System.Drawing.Size(43, 19);
            this.lblDevicePort.TabIndex = 10;
            this.lblDevicePort.Text = "Port";
            // 
            // tbDevicePort
            // 
            this.tbDevicePort.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbDevicePort.Location = new System.Drawing.Point(119, 102);
            this.tbDevicePort.Name = "tbDevicePort";
            this.tbDevicePort.Size = new System.Drawing.Size(204, 27);
            this.tbDevicePort.TabIndex = 9;
            this.tbDevicePort.Tag = "22";
            this.tbDevicePort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDevicePort_KeyPress);
            // 
            // lblDevicePassword
            // 
            this.lblDevicePassword.AutoSize = true;
            this.lblDevicePassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDevicePassword.Location = new System.Drawing.Point(3, 72);
            this.lblDevicePassword.Name = "lblDevicePassword";
            this.lblDevicePassword.Size = new System.Drawing.Size(87, 19);
            this.lblDevicePassword.TabIndex = 8;
            this.lblDevicePassword.Text = "Password";
            // 
            // tbDevicePassword
            // 
            this.tbDevicePassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbDevicePassword.Location = new System.Drawing.Point(119, 69);
            this.tbDevicePassword.Name = "tbDevicePassword";
            this.tbDevicePassword.Size = new System.Drawing.Size(204, 27);
            this.tbDevicePassword.TabIndex = 7;
            this.tbDevicePassword.UseSystemPasswordChar = true;
            this.tbDevicePassword.TextChanged += new System.EventHandler(this.tbDeviceName_TextChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserName.Location = new System.Drawing.Point(3, 39);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(95, 19);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User Name";
            // 
            // tbDeviceUserName
            // 
            this.tbDeviceUserName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbDeviceUserName.Location = new System.Drawing.Point(119, 36);
            this.tbDeviceUserName.Name = "tbDeviceUserName";
            this.tbDeviceUserName.Size = new System.Drawing.Size(204, 27);
            this.tbDeviceUserName.TabIndex = 3;
            this.tbDeviceUserName.TextChanged += new System.EventHandler(this.tbDeviceName_TextChanged);
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeviceName.Location = new System.Drawing.Point(3, 6);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(95, 19);
            this.lblDeviceName.TabIndex = 2;
            this.lblDeviceName.Text = "Host Name";
            // 
            // tbDeviceName
            // 
            this.tbDeviceName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbDeviceName.Location = new System.Drawing.Point(119, 3);
            this.tbDeviceName.Name = "tbDeviceName";
            this.tbDeviceName.Size = new System.Drawing.Size(204, 27);
            this.tbDeviceName.TabIndex = 1;
            this.tbDeviceName.TextChanged += new System.EventHandler(this.tbDeviceName_TextChanged);
            // 
            // cbAddDevice
            // 
            this.cbAddDevice.AutoSize = true;
            this.cbAddDevice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.cbAddDevice.Location = new System.Drawing.Point(3, 2);
            this.cbAddDevice.Name = "cbAddDevice";
            this.cbAddDevice.Size = new System.Drawing.Size(119, 23);
            this.cbAddDevice.TabIndex = 5;
            this.cbAddDevice.Text = "Add Device";
            this.cbAddDevice.UseVisualStyleBackColor = true;
            this.cbAddDevice.CheckedChanged += new System.EventHandler(this.cbAddDevice_CheckedChanged);
            // 
            // cbAddCommand
            // 
            this.cbAddCommand.AutoSize = true;
            this.cbAddCommand.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.cbAddCommand.Location = new System.Drawing.Point(3, 28);
            this.cbAddCommand.Name = "cbAddCommand";
            this.cbAddCommand.Size = new System.Drawing.Size(146, 23);
            this.cbAddCommand.TabIndex = 6;
            this.cbAddCommand.Text = "Add Command";
            this.cbAddCommand.UseVisualStyleBackColor = true;
            this.cbAddCommand.CheckedChanged += new System.EventHandler(this.cbAddCommand_CheckedChanged);
            // 
            // flpCommands
            // 
            this.flpCommands.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.flpCommands.Location = new System.Drawing.Point(733, 2);
            this.flpCommands.Name = "flpCommands";
            this.flpCommands.Size = new System.Drawing.Size(294, 357);
            this.flpCommands.TabIndex = 7;
            // 
            // flpDevices
            // 
            this.flpDevices.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.flpDevices.Location = new System.Drawing.Point(447, 2);
            this.flpDevices.Name = "flpDevices";
            this.flpDevices.Size = new System.Drawing.Size(280, 357);
            this.flpDevices.TabIndex = 8;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.pnlAddNewDevice);
            this.flowLayoutPanel3.Controls.Add(this.pnlAddNewCommand);
            this.flowLayoutPanel3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(1, 113);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(446, 506);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRun.Location = new System.Drawing.Point(4, 57);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(80, 50);
            this.btnRun.TabIndex = 10;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 619);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flpDevices);
            this.Controls.Add(this.flpCommands);
            this.Controls.Add(this.cbAddCommand);
            this.Controls.Add(this.cbAddDevice);
            this.Controls.Add(this.rtbConsole);
            this.Name = "frmMain";
            this.Text = "Rpi Controller";
            this.pnlAddNewCommand.ResumeLayout(false);
            this.pnlAddNewCommand.PerformLayout();
            this.pnlAddNewDevice.ResumeLayout(false);
            this.pnlAddNewDevice.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.Panel pnlAddNewCommand;
        private System.Windows.Forms.Panel pnlAddNewDevice;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.TextBox tbDeviceName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tbDeviceUserName;
        private System.Windows.Forms.Label lblDeviceIP;
        private System.Windows.Forms.TextBox tbDeviceIP;
        private System.Windows.Forms.Label lblDevicePort;
        private System.Windows.Forms.TextBox tbDevicePort;
        private System.Windows.Forms.Label lblDevicePassword;
        private System.Windows.Forms.TextBox tbDevicePassword;
        private System.Windows.Forms.CheckBox cbShowDevicePassword;
        private System.Windows.Forms.CheckBox cbAddDevice;
        private System.Windows.Forms.CheckBox cbAddCommand;
        private System.Windows.Forms.Label lblDeviceLocation;
        private System.Windows.Forms.TextBox tbDeviceLocation;
        private System.Windows.Forms.Label lblDeviceDescription;
        private System.Windows.Forms.TextBox tbDeviceDescription;
        private System.Windows.Forms.FlowLayoutPanel flpCommands;
        private System.Windows.Forms.FlowLayoutPanel flpDevices;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnAddCommand;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCommandDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCommandName;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblDevicePasswordMust;
        private System.Windows.Forms.Label lbldeviceUserNameMust;
        private System.Windows.Forms.Label lblDeviceNameMust;
        private System.Windows.Forms.Button btnRemoveDevice;
    }
}

