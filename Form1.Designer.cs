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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbConsole
            // 
            this.rtbConsole.BackColor = System.Drawing.Color.White;
            this.rtbConsole.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtbConsole.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.rtbConsole.Location = new System.Drawing.Point(436, 0);
            this.rtbConsole.Margin = new System.Windows.Forms.Padding(2);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.ReadOnly = true;
            this.rtbConsole.Size = new System.Drawing.Size(438, 672);
            this.rtbConsole.TabIndex = 0;
            this.rtbConsole.Text = "";
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddDevice.FlatAppearance.BorderSize = 2;
            this.btnAddDevice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnAddDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDevice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddDevice.Location = new System.Drawing.Point(5, 474);
            this.btnAddDevice.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(93, 54);
            this.btnAddDevice.TabIndex = 25;
            this.btnAddDevice.Text = "Add New Device";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // btnRemoveDevice
            // 
            this.btnRemoveDevice.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemoveDevice.FlatAppearance.BorderSize = 2;
            this.btnRemoveDevice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnRemoveDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRemoveDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDevice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveDevice.Location = new System.Drawing.Point(5, 538);
            this.btnRemoveDevice.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveDevice.Name = "btnRemoveDevice";
            this.btnRemoveDevice.Size = new System.Drawing.Size(93, 54);
            this.btnRemoveDevice.TabIndex = 26;
            this.btnRemoveDevice.Text = "Remove Device";
            this.btnRemoveDevice.UseVisualStyleBackColor = true;
            this.btnRemoveDevice.Click += new System.EventHandler(this.btnRemoveDevice_Click);
            // 
            // btnEditDevice
            // 
            this.btnEditDevice.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditDevice.FlatAppearance.BorderSize = 2;
            this.btnEditDevice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnEditDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEditDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDevice.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditDevice.Location = new System.Drawing.Point(107, 474);
            this.btnEditDevice.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditDevice.Name = "btnEditDevice";
            this.btnEditDevice.Size = new System.Drawing.Size(93, 54);
            this.btnEditDevice.TabIndex = 29;
            this.btnEditDevice.Text = "Edit Device";
            this.btnEditDevice.UseVisualStyleBackColor = true;
            this.btnEditDevice.Click += new System.EventHandler(this.btnEditDevice_Click);
            // 
            // btnAddNewCommand
            // 
            this.btnAddNewCommand.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddNewCommand.FlatAppearance.BorderSize = 2;
            this.btnAddNewCommand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewCommand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAddNewCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCommand.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddNewCommand.Location = new System.Drawing.Point(229, 474);
            this.btnAddNewCommand.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewCommand.Name = "btnAddNewCommand";
            this.btnAddNewCommand.Size = new System.Drawing.Size(93, 54);
            this.btnAddNewCommand.TabIndex = 27;
            this.btnAddNewCommand.Text = "Add New Command";
            this.btnAddNewCommand.UseVisualStyleBackColor = true;
            this.btnAddNewCommand.Click += new System.EventHandler(this.btnAddNewCommand_Click);
            // 
            // btnRemoveCommand
            // 
            this.btnRemoveCommand.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRemoveCommand.FlatAppearance.BorderSize = 2;
            this.btnRemoveCommand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnRemoveCommand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRemoveCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCommand.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRemoveCommand.Location = new System.Drawing.Point(229, 538);
            this.btnRemoveCommand.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveCommand.Name = "btnRemoveCommand";
            this.btnRemoveCommand.Size = new System.Drawing.Size(93, 54);
            this.btnRemoveCommand.TabIndex = 28;
            this.btnRemoveCommand.Text = "Remove Command";
            this.btnRemoveCommand.UseVisualStyleBackColor = true;
            this.btnRemoveCommand.Click += new System.EventHandler(this.btnRemoveCommand_Click);
            // 
            // btnEditCommand
            // 
            this.btnEditCommand.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditCommand.FlatAppearance.BorderSize = 2;
            this.btnEditCommand.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnEditCommand.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEditCommand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCommand.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditCommand.Location = new System.Drawing.Point(331, 474);
            this.btnEditCommand.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCommand.Name = "btnEditCommand";
            this.btnEditCommand.Size = new System.Drawing.Size(93, 54);
            this.btnEditCommand.TabIndex = 30;
            this.btnEditCommand.Text = "Edit Command";
            this.btnEditCommand.UseVisualStyleBackColor = true;
            this.btnEditCommand.Click += new System.EventHandler(this.btnEditCommand_Click);
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRun.FlatAppearance.BorderSize = 2;
            this.btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.btnRun.Location = new System.Drawing.Point(5, 596);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(93, 54);
            this.btnRun.TabIndex = 10;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // flpDevices
            // 
            this.flpDevices.BackColor = System.Drawing.Color.White;
            this.flpDevices.Location = new System.Drawing.Point(5, 22);
            this.flpDevices.Name = "flpDevices";
            this.flpDevices.Size = new System.Drawing.Size(195, 447);
            this.flpDevices.TabIndex = 11;
            // 
            // flpcommands
            // 
            this.flpcommands.BackColor = System.Drawing.Color.White;
            this.flpcommands.Location = new System.Drawing.Point(229, 22);
            this.flpcommands.Name = "flpcommands";
            this.flpcommands.Size = new System.Drawing.Size(195, 447);
            this.flpcommands.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(2, 3);
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
            this.label5.Location = new System.Drawing.Point(226, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Commands";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label4);
            this.pnlMain.Controls.Add(this.btnEditCommand);
            this.pnlMain.Controls.Add(this.btnRun);
            this.pnlMain.Controls.Add(this.btnRemoveCommand);
            this.pnlMain.Controls.Add(this.flpDevices);
            this.pnlMain.Controls.Add(this.btnAddNewCommand);
            this.pnlMain.Controls.Add(this.btnAddDevice);
            this.pnlMain.Controls.Add(this.label5);
            this.pnlMain.Controls.Add(this.btnEditDevice);
            this.pnlMain.Controls.Add(this.flpcommands);
            this.pnlMain.Controls.Add(this.btnRemoveDevice);
            this.pnlMain.Location = new System.Drawing.Point(1, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(430, 660);
            this.pnlMain.TabIndex = 31;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(874, 672);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.rtbConsole);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Rpi Controller";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbConsole;
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
        private System.Windows.Forms.Panel pnlMain;
    }
}

