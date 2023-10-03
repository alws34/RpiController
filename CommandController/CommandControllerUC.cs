using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiController.CommandController
{
    public partial class CommandControllerUC : UserControl
    {
        public CommandControllerUC()
        {
            InitializeComponent();
        }

        public string GetCommandName() { return tbCommandName.Text; }
        public string GetCommandDescription() { return tbCommandDescription.Text; }
        public string GetCommand() { return tbCommand.Text; }

        public void SetCommandName(string name) { tbCommandName.Text = name; }
        public void SetCommandDescription(string description) { tbCommandDescription.Text = description; }
        public void SetCommand(string command) { tbCommand.Text = command; }
    }
}
