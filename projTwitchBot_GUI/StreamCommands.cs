using System;
using System.Collections.Generic;
using System.Media;
using WMPLib;
using System.IO;

namespace ProjTwitchBotVisual
{
    static class StreamCommands
    {
        public static void PingPong(string buf, TextWriter output)
        {
            //Send pong reply to any ping messages
            if (buf.Contains("PING"))
            {
                output.Write(buf.Replace("PING", "PONG") + "\r\n");
                output.Flush();
            }
        }

        public static void addCommand(string buf)
        {
            if (Filter(buf).Contains("!NewCommand"))
            {
                List<string> Com = new List<string>();
                int cmdLenght = Filter(buf).Length;
                cmdLenght = cmdLenght - 13;
                string newCommand = Filter(buf).Substring(13, cmdLenght);
                Com = DynamicCommands.CommandAdd(newCommand);

                FileReaderWriter.ComWriter("dyCommands.txt", Com);
                Console.Write(newCommand);
            }
        }

        public static void dynamCommands(string buf)
        {
            List<string> Com = new List<string>();

            Com = DynamicCommands.rt;
            if (Filter(buf).Contains("!ListCommands"))
            {
                for (int i = 0; Filter(buf).Contains(Com[i]); i++)
                {
                    Console.Write(Com[i]);
                }
                Com = null;
            }

        }

        public static void Ding(string buf)
        {
            if (Filter(buf).Contains("!Ding"))
            {
                System.Media.SystemSounds.Beep.Play();
            }
        }

        public static void Dong(string buf)
        {
            if (Filter(buf).Contains("!Dong"))
            {
                new SoundPlayer(@"Sounds\WTD.wav").Play();
                //WMPLib.WindowsMediaPlayer a = new WMPLib.WindowsMediaPlayer(); //.mp3
                // a.URL = @"Sounds\WTD.mp3";
                //a.controls.play();
            }
        }

        public static string Filter(string buf)//Removes all irc server related text
        {
            int i = 0, j = 0;
            List<char> charList = new List<char>();
            charList.AddRange(buf.ToCharArray());
            charList.RemoveAt(0);
            do
            {
                if (charList[i].Equals(':') & (j < 1))
                {
                    break;
                }
                else
                {
                    charList.RemoveAt(0);
                }

            } while (i < charList.Count);

            char[] text = charList.ToArray();
            buf = new string(text);
            charList = null;
            text = null;
            return buf;
        }
    }
}
