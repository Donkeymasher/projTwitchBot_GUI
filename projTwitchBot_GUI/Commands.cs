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
        protected string name; 
        protected bool playMusic;
        protected bool respondToChat;

        public Commands()
        {

        }

        public Commands(string name, bool playMusic, bool respondToChat)
        {

        }

        public bool getChatStatus()
        {
            return respondToChat;
        }

        public bool getMusicStatus()
        {
            return playMusic;
        }

        public string Getname()
        {
            return name;
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
            base.name = name;
            base.playMusic = playMusic;
            base.respondToChat = respondToChat;
        }

        public void display()
        {
            Console.WriteLine(Creator);
            Console.WriteLine(DateCreated.ToString());
            Console.WriteLine(base.Getname());
        }


    }
}