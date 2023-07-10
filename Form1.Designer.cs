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
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.btnRemoveDevice = new System.Windows.Forms.Button();
            this.btnEditDevice = new System.Windows.Forms.Button();
            this.btnAddNewCommand = new System.Windows.Forms.Button();
            this.btnRemoveCommand = new System.Windows.Forms.Button();
            this.btnEditCommand = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.flpDevices = new System.Windows.Forms.FlowLayoutPanel();
            this.flpcommands = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlAddNewCommand.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbConsole
            // 
            this.rtbConsole.BackColor = System.Drawing.Color.White;
            this.rtbConsole.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtbConsole.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.rtbConsole.Location = new System.Drawing.Point(574, 0);
            this.rtbConsole.Margin = new System.Windows.Forms.Padding(2);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.ReadOnly = true;
            this.rtbConsole.Size = new System.Drawing.Size(438, 658);
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
            this.pnlAddNewCommand.Location = new System.Drawing.Point(251, 491);
            this.pnlAddNewCommand.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAddNewCommand.Name = "pnlAddNewCommand";
            this.pnlAddNewCommand.Size = new System.Drawing.Size(328, 161);
            this.pnlAddNewCommand.TabIndex = 3;
            this.pnlAddNewCommand.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Command";
            // 
            // tbCommand
            // 
            this.tbCommand.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbCommand.Location = new System.Drawing.Point(9, 114);
            this.tbCommand.Margin = new System.Windows.Forms.Padding(2);
            this.tbCommand.Multiline = true;
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(317, 41);
            this.tbCommand.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(2, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Command Desription";
            // 
            // tbCommandDescription
            // 
            this.tbCommandDescription.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbCommandDescription.Location = new System.Drawing.Point(6, 50);
            this.tbCommandDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tbCommandDescription.Multiline = true;
            this.tbCommandDescription.Name = "tbCommandDescription";
            this.tbCommandDescription.Size = new System.Drawing.Size(237, 49);
            this.tbCommandDescription.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(2, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Command Name";
            // 
            // tbCommandName
            // 
            this.tbCommandName.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbCommandName.Location = new System.Drawing.Point(110, 5);
            this.tbCommandName.Margin = new System.Windows.Forms.Padding(2);
            this.tbCommandName.Name = "tbCommandName";
            this.tbCommandName.Size = new System.Drawing.Size(134, 23);
            this.tbCommandName.TabIndex = 20;
            // 
            // btnAddCommand
            // 
            this.btnAddCommand.Enabled = false;
            this.btnAddCommand.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCommand.Location = new System.Drawing.Point(247, 0);
            this.btnAddCommand.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.Size = new System.Drawing.Size(78, 54);
            this.btnAddCommand.TabIndex = 19;
            this.btnAddCommand.Text = "Add Command";
            this.btnAddCommand.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.btnAddDevice);
            this.flowLayoutPanel3.Controls.Add(this.btnRemoveDevice);
            this.flowLayoutPanel3.Controls.Add(this.btnEditDevice);
            this.flowLayoutPanel3.Controls.Add(this.btnAddNewCommand);
            this.flowLayoutPanel3.Controls.Add(this.btnRemoveCommand);
            this.flowLayoutPanel3.Controls.Add(this.btnEditCommand);
            this.flowLayoutPanel3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 538);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(248, 118);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddDevice.Location = new System.Drawing.Point(2, 2);
            this.btnAddDevice.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(78, 54);
            this.btnAddDevice.TabIndex = 25;
            this.btnAddDevice.Text = "Add New Device";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // btnRemoveDevice
            // 
            this.btnRemoveDevice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveDevice.Location = new System.Drawing.Point(84, 2);
            this.btnRemoveDevice.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveDevice.Name = "btnRemoveDevice";
            this.btnRemoveDevice.Size = new System.Drawing.Size(78, 54);
            this.btnRemoveDevice.TabIndex = 26;
            this.btnRemoveDevice.Text = "Remove Device";
            this.btnRemoveDevice.UseVisualStyleBackColor = true;
            this.btnRemoveDevice.Click += new System.EventHandler(this.btnRemoveDevice_Click);
            // 
            // btnEditDevice
            // 
            this.btnEditDevice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditDevice.Location = new System.Drawing.Point(166, 2);
            this.btnEditDevice.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditDevice.Name = "btnEditDevice";
            this.btnEditDevice.Size = new System.Drawing.Size(78, 54);
            this.btnEditDevice.TabIndex = 29;
            this.btnEditDevice.Text = "Edit Device";
            this.btnEditDevice.UseVisualStyleBackColor = true;
            this.btnEditDevice.Click += new System.EventHandler(this.btnEditDevice_Click);
            // 
            // btnAddNewCommand
            // 
            this.btnAddNewCommand.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddNewCommand.Location = new System.Drawing.Point(2, 60);
            this.btnAddNewCommand.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewCommand.Name = "btnAddNewCommand";
            this.btnAddNewCommand.Size = new System.Drawing.Size(78, 54);
            this.btnAddNewCommand.TabIndex = 27;
            this.btnAddNewCommand.Text = "Add New Command";
            this.btnAddNewCommand.UseVisualStyleBackColor = true;
            // 
            // btnRemoveCommand
            // 
            this.btnRemoveCommand.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveCommand.Location = new System.Drawing.Point(84, 60);
            this.btnRemoveCommand.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveCommand.Name = "btnRemoveCommand";
            this.btnRemoveCommand.Size = new System.Drawing.Size(78, 54);
            this.btnRemoveCommand.TabIndex = 28;
            this.btnRemoveCommand.Text = "Remove Device";
            this.btnRemoveCommand.UseVisualStyleBackColor = true;
            // 
            // btnEditCommand
            // 
            this.btnEditCommand.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditCommand.Location = new System.Drawing.Point(166, 60);
            this.btnEditCommand.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCommand.Name = "btnEditCommand";
            this.btnEditCommand.Size = new System.Drawing.Size(78, 54);
            this.btnEditCommand.TabIndex = 30;
            this.btnEditCommand.Text = "Add Device";
            this.btnEditCommand.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRun.Location = new System.Drawing.Point(3, 491);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(80, 41);
            this.btnRun.TabIndex = 10;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // flpDevices
            // 
            this.flpDevices.BackColor = System.Drawing.Color.White;
            this.flpDevices.Location = new System.Drawing.Point(5, 39);
            this.flpDevices.Name = "flpDevices";
            this.flpDevices.Size = new System.Drawing.Size(195, 447);
            this.flpDevices.TabIndex = 11;
            // 
            // flpcommands
            // 
            this.flpcommands.BackColor = System.Drawing.Color.White;
            this.flpcommands.Location = new System.Drawing.Point(223, 39);
            this.flpcommands.Name = "flpcommands";
            this.flpcommands.Size = new System.Drawing.Size(195, 447);
            this.flpcommands.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(2, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Devices";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(220, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Commands";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1012, 658);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.flpcommands);
            this.Controls.Add(this.flpDevices);
            this.Controls.Add(this.pnlAddNewCommand);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.rtbConsole);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Rpi Controller";
            this.pnlAddNewCommand.ResumeLayout(false);
            this.pnlAddNewCommand.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.Panel pnlAddNewCommand;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnAddCommand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCommandDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCommandName;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.Button btnRemoveDevice;
        private System.Windows.Forms.Button btnEditDevice;
        private System.Windows.Forms.Button btnAddNewCommand;
        private System.Windows.Forms.Button btnRemoveCommand;
        private System.Windows.Forms.Button btnEditCommand;
        private System.Windows.Forms.FlowLayoutPanel flpDevices;
        private System.Windows.Forms.FlowLayoutPanel flpcommands;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

