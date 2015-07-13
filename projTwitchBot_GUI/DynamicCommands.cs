using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projTwitchBotVisual
{
    class DynamicCommands
    {
        private List<String> Commands = new List<string>(); 

        public List<String> CommandAdd(string NCommand)
        {
            Commands.Add(NCommand);
            return Commands;
        }

        public List<string> rt() { return Commands; }
    }
}
