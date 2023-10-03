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
            this.btnRemoveDevice = new System.Windows.Forms.Button();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.deviceControllerUC = new PiController.DeviceController.DeviceControllerUC();
            this.SuspendLayout();
            // 
            // btnRemoveDevice
            // 
            this.btnRemoveDevice.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemoveDevice.Enabled = false;
            this.btnRemoveDevice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveDevice.Location = new System.Drawing.Point(84, 249);
            this.btnRemoveDevice.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveDevice.Name = "btnRemoveDevice";
            this.btnRemoveDevice.Size = new System.Drawing.Size(78, 54);
            this.btnRemoveDevice.TabIndex = 26;
            this.btnRemoveDevice.Text = "Remove Device";
            this.btnRemoveDevice.UseVisualStyleBackColor = false;
            this.btnRemoveDevice.Click += new System.EventHandler(this.btnRemoveDevice_Click);
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddDevice.Enabled = false;
            this.btnAddDevice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddDevice.Location = new System.Drawing.Point(2, 249);
            this.btnAddDevice.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(78, 54);
            this.btnAddDevice.TabIndex = 25;
            this.btnAddDevice.Text = "Add Device";
            this.btnAddDevice.UseVisualStyleBackColor = false;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // deviceControllerIUC
            // 
            this.deviceControllerUC.IsAllFieldsOK = false;
            this.deviceControllerUC.IsPasswordEdited = false;
            this.deviceControllerUC.Location = new System.Drawing.Point(2, 2);
            this.deviceControllerUC.Name = "deviceControllerIUC";
            this.deviceControllerUC.Size = new System.Drawing.Size(363, 242);
            this.deviceControllerUC.TabIndex = 27;
            // 
            // frmAddDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(361, 308);
            this.Controls.Add(this.deviceControllerUC);
            this.Controls.Add(this.btnRemoveDevice);
            this.Controls.Add(this.btnAddDevice);
            this.Name = "frmAddDevice";
            this.Text = "Add Device";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveDevice;
        private System.Windows.Forms.Button btnAddDevice;
        private DeviceController.DeviceControllerUC deviceControllerUC;
    }
}