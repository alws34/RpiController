namespace PiController
{
    partial class frmAddDevice
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
            this.pnlAddNewDevice.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlAddNewDevice.Location = new System.Drawing.Point(6, 6);
            this.pnlAddNewDevice.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAddNewDevice.Name = "pnlAddNewDevice";
            this.pnlAddNewDevice.Size = new System.Drawing.Size(360, 239);
            this.pnlAddNewDevice.TabIndex = 6;
            // 
            // btnRemoveDevice
            // 
            this.btnRemoveDevice.Enabled = false;
            this.btnRemoveDevice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveDevice.Location = new System.Drawing.Point(263, 107);
            this.btnRemoveDevice.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveDevice.Name = "btnRemoveDevice";
            this.btnRemoveDevice.Size = new System.Drawing.Size(78, 54);
            this.btnRemoveDevice.TabIndex = 24;
            this.btnRemoveDevice.Text = "Remove Device";
            this.btnRemoveDevice.UseVisualStyleBackColor = true;
            this.btnRemoveDevice.Click += new System.EventHandler(this.btnRemoveDevice_Click);
            // 
            // lblDevicePasswordMust
            // 
            this.lblDevicePasswordMust.AutoSize = true;
            this.lblDevicePasswordMust.Location = new System.Drawing.Point(88, 58);
            this.lblDevicePasswordMust.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDevicePasswordMust.Name = "lblDevicePasswordMust";
            this.lblDevicePasswordMust.Size = new System.Drawing.Size(12, 16);
            this.lblDevicePasswordMust.TabIndex = 23;
            this.lblDevicePasswordMust.Text = "*";
            // 
            // lbldeviceUserNameMust
            // 
            this.lbldeviceUserNameMust.AutoSize = true;
            this.lbldeviceUserNameMust.Location = new System.Drawing.Point(88, 32);
            this.lbldeviceUserNameMust.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldeviceUserNameMust.Name = "lbldeviceUserNameMust";
            this.lbldeviceUserNameMust.Size = new System.Drawing.Size(12, 16);
            this.lbldeviceUserNameMust.TabIndex = 22;
            this.lbldeviceUserNameMust.Text = "*";
            // 
            // lblDeviceNameMust
            // 
            this.lblDeviceNameMust.AutoSize = true;
            this.lblDeviceNameMust.Location = new System.Drawing.Point(88, 5);
            this.lblDeviceNameMust.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeviceNameMust.Name = "lblDeviceNameMust";
            this.lblDeviceNameMust.Size = new System.Drawing.Size(12, 16);
            this.lblDeviceNameMust.TabIndex = 21;
            this.lblDeviceNameMust.Text = "*";
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Enabled = false;
            this.btnAddDevice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddDevice.Location = new System.Drawing.Point(263, 179);
            this.btnAddDevice.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(78, 54);
            this.btnAddDevice.TabIndex = 20;
            this.btnAddDevice.Text = "Add Device";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // lblDeviceDescription
            // 
            this.lblDeviceDescription.AutoSize = true;
            this.lblDeviceDescription.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeviceDescription.Location = new System.Drawing.Point(2, 187);
            this.lblDeviceDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeviceDescription.Name = "lblDeviceDescription";
            this.lblDeviceDescription.Size = new System.Drawing.Size(88, 16);
            this.lblDeviceDescription.TabIndex = 17;
            this.lblDeviceDescription.Text = "Description";
            // 
            // tbDeviceDescription
            // 
            this.tbDeviceDescription.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbDeviceDescription.Location = new System.Drawing.Point(105, 165);
            this.tbDeviceDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tbDeviceDescription.Multiline = true;
            this.tbDeviceDescription.Name = "tbDeviceDescription";
            this.tbDeviceDescription.Size = new System.Drawing.Size(154, 68);
            this.tbDeviceDescription.TabIndex = 16;
            // 
            // lblDeviceLocation
            // 
            this.lblDeviceLocation.AutoSize = true;
            this.lblDeviceLocation.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeviceLocation.Location = new System.Drawing.Point(2, 137);
            this.lblDeviceLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeviceLocation.Name = "lblDeviceLocation";
            this.lblDeviceLocation.Size = new System.Drawing.Size(67, 16);
            this.lblDeviceLocation.TabIndex = 15;
            this.lblDeviceLocation.Text = "Location";
            // 
            // tbDeviceLocation
            // 
            this.tbDeviceLocation.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbDeviceLocation.Location = new System.Drawing.Point(105, 138);
            this.tbDeviceLocation.Margin = new System.Windows.Forms.Padding(2);
            this.tbDeviceLocation.Name = "tbDeviceLocation";
            this.tbDeviceLocation.Size = new System.Drawing.Size(154, 23);
            this.tbDeviceLocation.TabIndex = 14;
            // 
            // cbShowDevicePassword
            // 
            this.cbShowDevicePassword.AutoSize = true;
            this.cbShowDevicePassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.cbShowDevicePassword.Location = new System.Drawing.Point(263, 53);
            this.cbShowDevicePassword.Margin = new System.Windows.Forms.Padding(2);
            this.cbShowDevicePassword.Name = "cbShowDevicePassword";
            this.cbShowDevicePassword.Size = new System.Drawing.Size(94, 36);
            this.cbShowDevicePassword.TabIndex = 13;
            this.cbShowDevicePassword.Text = "Show\r\nPassword";
            this.cbShowDevicePassword.UseVisualStyleBackColor = true;
            this.cbShowDevicePassword.CheckedChanged += new System.EventHandler(this.cbShowDevicePassword_CheckedChanged);
            // 
            // lblDeviceIP
            // 
            this.lblDeviceIP.AutoSize = true;
            this.lblDeviceIP.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeviceIP.Location = new System.Drawing.Point(2, 110);
            this.lblDeviceIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeviceIP.Name = "lblDeviceIP";
            this.lblDeviceIP.Size = new System.Drawing.Size(20, 16);
            this.lblDeviceIP.TabIndex = 12;
            this.lblDeviceIP.Text = "IP";
            // 
            // tbDeviceIP
            // 
            this.tbDeviceIP.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbDeviceIP.Location = new System.Drawing.Point(105, 111);
            this.tbDeviceIP.Margin = new System.Windows.Forms.Padding(2);
            this.tbDeviceIP.Name = "tbDeviceIP";
            this.tbDeviceIP.Size = new System.Drawing.Size(154, 23);
            this.tbDeviceIP.TabIndex = 11;
            // 
            // lblDevicePort
            // 
            this.lblDevicePort.AutoSize = true;
            this.lblDevicePort.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDevicePort.Location = new System.Drawing.Point(2, 85);
            this.lblDevicePort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDevicePort.Name = "lblDevicePort";
            this.lblDevicePort.Size = new System.Drawing.Size(36, 16);
            this.lblDevicePort.TabIndex = 10;
            this.lblDevicePort.Text = "Port";
            // 
            // tbDevicePort
            // 
            this.tbDevicePort.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbDevicePort.Location = new System.Drawing.Point(105, 86);
            this.tbDevicePort.Margin = new System.Windows.Forms.Padding(2);
            this.tbDevicePort.Name = "tbDevicePort";
            this.tbDevicePort.Size = new System.Drawing.Size(154, 23);
            this.tbDevicePort.TabIndex = 9;
            this.tbDevicePort.Tag = "22";
            this.tbDevicePort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDevicePort_KeyPress);
            // 
            // lblDevicePassword
            // 
            this.lblDevicePassword.AutoSize = true;
            this.lblDevicePassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDevicePassword.Location = new System.Drawing.Point(2, 58);
            this.lblDevicePassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDevicePassword.Name = "lblDevicePassword";
            this.lblDevicePassword.Size = new System.Drawing.Size(75, 16);
            this.lblDevicePassword.TabIndex = 8;
            this.lblDevicePassword.Text = "Password";
            // 
            // tbDevicePassword
            // 
            this.tbDevicePassword.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbDevicePassword.Location = new System.Drawing.Point(105, 59);
            this.tbDevicePassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbDevicePassword.Name = "tbDevicePassword";
            this.tbDevicePassword.Size = new System.Drawing.Size(154, 23);
            this.tbDevicePassword.TabIndex = 7;
            this.tbDevicePassword.UseSystemPasswordChar = true;
            this.tbDevicePassword.TextChanged += new System.EventHandler(this.tbDeviceName_TextChanged);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblUserName.Location = new System.Drawing.Point(2, 32);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(83, 16);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User Name";
            // 
            // tbDeviceUserName
            // 
            this.tbDeviceUserName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbDeviceUserName.Location = new System.Drawing.Point(105, 32);
            this.tbDeviceUserName.Margin = new System.Windows.Forms.Padding(2);
            this.tbDeviceUserName.Name = "tbDeviceUserName";
            this.tbDeviceUserName.Size = new System.Drawing.Size(154, 23);
            this.tbDeviceUserName.TabIndex = 3;
            this.tbDeviceUserName.TextChanged += new System.EventHandler(this.tbDeviceName_TextChanged);
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeviceName.Location = new System.Drawing.Point(2, 5);
            this.lblDeviceName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(82, 16);
            this.lblDeviceName.TabIndex = 2;
            this.lblDeviceName.Text = "Host Name";
            // 
            // tbDeviceName
            // 
            this.tbDeviceName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbDeviceName.Location = new System.Drawing.Point(105, 5);
            this.tbDeviceName.Margin = new System.Windows.Forms.Padding(2);
            this.tbDeviceName.Name = "tbDeviceName";
            this.tbDeviceName.Size = new System.Drawing.Size(154, 23);
            this.tbDeviceName.TabIndex = 1;
            this.tbDeviceName.TextChanged += new System.EventHandler(this.tbDeviceName_TextChanged);
            // 
            // frmAddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(370, 252);
            this.Controls.Add(this.pnlAddNewDevice);
            this.Name = "frmAddDevice";
            this.Text = "Add Device";
            this.pnlAddNewDevice.ResumeLayout(false);
            this.pnlAddNewDevice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddNewDevice;
        private System.Windows.Forms.Button btnRemoveDevice;
        private System.Windows.Forms.Label lblDevicePasswordMust;
        private System.Windows.Forms.Label lbldeviceUserNameMust;
        private System.Windows.Forms.Label lblDeviceNameMust;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.Label lblDeviceDescription;
        private System.Windows.Forms.TextBox tbDeviceDescription;
        private System.Windows.Forms.Label lblDeviceLocation;
        private System.Windows.Forms.TextBox tbDeviceLocation;
        private System.Windows.Forms.CheckBox cbShowDevicePassword;
        private System.Windows.Forms.Label lblDeviceIP;
        private System.Windows.Forms.TextBox tbDeviceIP;
        private System.Windows.Forms.Label lblDevicePort;
        private System.Windows.Forms.TextBox tbDevicePort;
        private System.Windows.Forms.Label lblDevicePassword;
        private System.Windows.Forms.TextBox tbDevicePassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tbDeviceUserName;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.TextBox tbDeviceName;
    }
}