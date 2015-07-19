
namespace ProjTwitchBotVisual
{
    class Commands
    {
        private string Name;

        //private var usage -- TO DO-- 

        public Commands(string initalName)
        {
            Name = initalName;

        }

        public string getName()
        {
            return Name;
        }

        public void setName(string newName)
        {
            Name = newName;
        }
    }
}
