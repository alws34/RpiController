namespace PiController
{
    partial class frmCommandController
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
            this.btnAddCommand = new System.Windows.Forms.Button();
            this.deviceControllerUC = new PiController.CommandController.CommandControllerUC();
            this.SuspendLayout();
            // 
            // btnAddCommand
            // 
            this.btnAddCommand.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCommand.Location = new System.Drawing.Point(5, 250);
            this.btnAddCommand.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.Size = new System.Drawing.Size(79, 49);
            this.btnAddCommand.TabIndex = 19;
            this.btnAddCommand.Text = "Add Command";
            this.btnAddCommand.UseVisualStyleBackColor = true;
            this.btnAddCommand.Click += new System.EventHandler(this.btnAddCommand_Click);
            // 
            // deviceControllerUC
            // 
            this.deviceControllerUC.Location = new System.Drawing.Point(2, -2);
            this.deviceControllerUC.Name = "deviceControllerUC";
            this.deviceControllerUC.Size = new System.Drawing.Size(333, 247);
            this.deviceControllerUC.TabIndex = 20;
            // 
            // frmAddCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 302);
            this.Controls.Add(this.deviceControllerUC);
            this.Controls.Add(this.btnAddCommand);
            this.Name = "frmAddCommand";
            this.Text = "Add Command";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddCommand;
        private CommandController.CommandControllerUC deviceControllerUC;
    }
}