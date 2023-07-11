using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiController
{
    public partial class frmAddCommand : Form
    {
        IController controller;
        Icommunicator communicator;
        bool IsEdit = false;
        Command Command = null;
        public frmAddCommand(IController con, Icommunicator com, Command command = null, bool isEdit = false)
        {
            InitializeComponent();
            controller = con;
            communicator = com;
            IsEdit = isEdit;
            Command = command;

            if (isEdit)
            {
                btnAddCommand.Text = "Save Changes";
                Text = "Edit Command";
            }
           
            if (command != null)
                SetCommandToScreen(command);
            CenterToScreen();
        }

        private void SetCommandToScreen(Command command)
        {
            tbCommandName.Text = command.CommandName;
            tbCommandDescription.Text = command.CommandDescription;
            tbCommand.Text = command.ShellCommand;
        }

        private Command GetCommand(Command comm = null)
        {
            if (!IsEdit)
            {
                comm = new Command()
                {
                    CommandName = tbCommandName.Text,
                    CommandDescription = tbCommandDescription.Text,
                    ShellCommand = tbCommand.Text
                };

                comm.CommandID = Utils.GetUniqueID();
            }
            else
            {
                comm.CommandName = tbCommandName.Text;
                comm.CommandDescription = tbCommandDescription.Text;
                comm.ShellCommand = tbCommand.Text;
            }
            return comm;
        }

        private void btnAddCommand_Click(object sender, EventArgs e)
        {
            Command comm;
            string msg;

            if (!IsEdit)
            {
                comm = GetCommand();
                msg = $"Successfully Added {comm.CommandName}";
                controller.AddCommand(comm);
            }
            else
            {
                comm = GetCommand(Command);
                msg = $"Successfully Edited {comm.CommandName}";
                controller.EditCommand(comm);
            }
            communicator.SendMessageToConsole(msg, LogType.Success);

            Dispose();
        }
    }
}
