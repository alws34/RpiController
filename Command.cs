using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiController
{
    public class Command
    {
        public string CommandName { get; set; }
        public string CommandDescription { get; set; }
        public string CommandID { get; set; }
        public string ShellCommand { get; set; }
        public Command() { }

        public Command(string commandName, string commandDescription, string commandID, string shellCommand)
        {
            CommandName = commandName;
            CommandDescription = commandDescription;
            CommandID = commandID;
            ShellCommand = shellCommand;

        }
    }
}
