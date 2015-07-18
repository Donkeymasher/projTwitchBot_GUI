using System;
using System.Collections.Generic;

namespace ProjTwitchBotVisual
{
    static class DynamicCommands
    {
        private static List<String> Commands = new List<string>();

        public static List<String> CommandAdd(string NCommand)
        {
            Commands.Add(NCommand);
            return Commands;
        }

        public static List<string> rt
        {
            get
            {
                return Commands;
            }
        }
    }
}
