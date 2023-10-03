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
    public partial class frmCommandController : Form
    {
        IController controller;
        Icommunicator communicator;
        bool IsEdit = false;
        Command Command = null;

        public frmCommandController(IController con, Icommunicator com, Command command = null, bool isEdit = false)
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
            deviceControllerUC.SetCommandName(command.CommandName);
            deviceControllerUC.SetCommandDescription(command.CommandDescription);
            deviceControllerUC.SetCommand(command.ShellCommand);
        }

        private Command GetCommand(Command comm = null)
        {

            if (!IsEdit)
            {
                comm = new Command()
                {
                    CommandName = deviceControllerUC.GetCommandName(),
                    CommandDescription = deviceControllerUC.GetCommandDescription(),
                    ShellCommand = deviceControllerUC.GetCommand()
                };

                comm.CommandID = Utils.GetUniqueID();
            }
            else
            {
                comm.CommandName = deviceControllerUC.GetCommandName();
                comm.CommandDescription = deviceControllerUC.GetCommandDescription();
                comm.ShellCommand = deviceControllerUC.GetCommand();
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
