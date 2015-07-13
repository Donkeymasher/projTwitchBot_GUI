using System;
using System.Collections.Generic;
using System.IO;

namespace ProjTwitchBotVisual
{
    static class FileReaderWriter
    {
        public static void ComWriter(string Path, List<string> command)
        {
            File.Delete(Path);

            if (!File.Exists(Path))
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                using (StreamWriter sw = File.CreateText(Path))
                {
                    int i = 0;
                    while (i != command.Count)
                    {
                        sw.WriteLine(command[i]);
                        Console.Write(command[i]);
                        i++;
                    }
                    i = 0;
                }
            }
        }

        public static void ConWriter(int port, string nick, string server, string chan, String Path)
        {
            if (!File.Exists(Path))
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                using (StreamWriter sw = File.CreateText(Path))
                {
                    //Write a line of text
                    sw.WriteLine(nick);
                    sw.WriteLine(server);
                    sw.WriteLine(port);
                    sw.WriteLine(chan);

                }
            }
        }

        public static string[] reader(string Path)
        {
            //String[] ConData = new string[4];
            // Read the file and display it line by line.
            //using (System.IO.StreamReader sr = File.OpenText(Path))
            //{
            //string s = "";
            //int i = 0;
            //while ((s = sr.()) != null)
            //{
            //ConData[i] = s;
            //i++;
            //}
            // sr.Close();
            return File.ReadAllLines(Path);
        }

    }
}
