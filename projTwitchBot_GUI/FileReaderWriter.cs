using System;
using System.IO;

namespace projTwitchBotVisual
{
    class FileReaderWriter
    {
        public void Writer(int port, string nick, string server, string chan)
        {
            String Path = @"C:\\MyTest.txt";
            if (!File.Exists(Path))
            {
                //Pass the filepath and filename to the StreamWriter Constructor
                using (StreamWriter sw = File.CreateText(Path))
                {
                    //Write a line of text
                    sw.WriteLine(port);
                    sw.WriteLine(nick);
                    sw.WriteLine(server);
                    sw.WriteLine(chan);

                    //Close the file
                    sw.Close();
                }
            }
        }

        public string reader()
        {
            // Read the file and display it line by line.
            using (System.IO.StreamReader sr = File.OpenText(@"MyTest.txt"))
            { 
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                sr.Close();
            }
            return "null";
        }
            
    }
}
