namespace PiController.CommandController
{
    partial class CommandControllerUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlAddNewCommand = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCommandDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCommandName = new System.Windows.Forms.TextBox();
            this.pnlAddNewCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAddNewCommand
            // 
            this.pnlAddNewCommand.Controls.Add(this.label3);
            this.pnlAddNewCommand.Controls.Add(this.tbCommand);
            this.pnlAddNewCommand.Controls.Add(this.label2);
            this.pnlAddNewCommand.Controls.Add(this.tbCommandDescription);
            this.pnlAddNewCommand.Controls.Add(this.label1);
            this.pnlAddNewCommand.Controls.Add(this.tbCommandName);
            this.pnlAddNewCommand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAddNewCommand.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.pnlAddNewCommand.Location = new System.Drawing.Point(0, 0);
            this.pnlAddNewCommand.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAddNewCommand.Name = "pnlAddNewCommand";
            this.pnlAddNewCommand.Size = new System.Drawing.Size(333, 247);
            this.pnlAddNewCommand.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(6, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Command";
            // 
            // tbCommand
            // 
            this.tbCommand.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbCommand.Location = new System.Drawing.Point(3, 159);
            this.tbCommand.Margin = new System.Windows.Forms.Padding(2);
            this.tbCommand.Multiline = true;
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(323, 82);
            this.tbCommand.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(2, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Command Desription";
            // 
            // tbCommandDescription
            // 
            this.tbCommandDescription.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tbCommandDescription.Location = new System.Drawing.Point(3, 73);
            this.tbCommandDescription.Margin = new System.Windows.Forms.Padding(2);
            this.tbCommandDescription.Multiline = true;
            this.tbCommandDescription.Name = "tbCommandDescription";
            this.tbCommandDescription.Size = new System.Drawing.Size(323, 66);
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
            this.tbCommandName.Location = new System.Drawing.Point(3, 25);
            this.tbCommandName.Margin = new System.Windows.Forms.Padding(2);
            this.tbCommandName.Name = "tbCommandName";
            this.tbCommandName.Size = new System.Drawing.Size(323, 23);
            this.tbCommandName.TabIndex = 20;
            // 
            // DeviceControllerUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlAddNewCommand);
            this.Name = "DeviceControllerUC";
            this.Size = new System.Drawing.Size(333, 247);
            this.pnlAddNewCommand.ResumeLayout(false);
            this.pnlAddNewCommand.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddNewCommand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCommandDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCommandName;
    }
}
