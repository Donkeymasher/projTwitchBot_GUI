using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjTwitchBotVisual
{
    [Serializable]
    public class Commands
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

    [Serializable]
    public class DynamicCommands:Commands
    {
        private string Creator;
        private DateTime DateCreated;

        public DynamicCommands()
        {
            Creator = "UnAssigned";
            DateCreated = DateTime.Now;
        }

        public DynamicCommands(string name, bool playMusic, bool respondToChat, string creator)
            : base(name, respondToChat, playMusic)
        {
            Creator = creator;
        }

    }
}