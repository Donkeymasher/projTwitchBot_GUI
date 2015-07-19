using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjTwitchBotVisual
{
    class Commands
    {
        private string name;
        private bool playMusic;
        private bool respondToChat;

        public Commands()
        {

        }

        public Commands(string name, bool playMusic, bool respondToChat)
        {

        }
    }

    class DynamicCommands:Commands
    {
        private string Creator;
        private DateTime DateCreated;

        public DynamicCommands()
        {
            Creator = "UnAssigned";
            DateCreated = DateTime.Now;
        }

        public DynamicCommands(string creator)
        {
            Creator = creator;
        }

    }
}