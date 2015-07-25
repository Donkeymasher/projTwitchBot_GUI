using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

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

        public static void WriteBinary(string path, DynamicCommands a)
        {
            // To serialize the hashtable and its key/value pairs,   
            // you must first open a stream for writing.  
            // In this case, use a file stream.
            FileStream fs = new FileStream(path, FileMode.Create);

            // Construct a BinaryFormatter and use it to serialize the data to the stream.
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, a);
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        public static DynamicCommands ReadBinary(string path)
        {
            if (!(path == ""))
            {
                DynamicCommands a = null;

                // Open the file containing the data that you want to deserialize.
                FileStream fs = new FileStream(path, FileMode.Open);
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    // Deserialize the hashtable from the file and  
                    // assign the reference to the local variable.
                    a = (DynamicCommands)formatter.Deserialize(fs);
                }
                catch (SerializationException e)
                {
                    Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                    throw;
                }
                finally
                {
                    fs.Close();
                }
                return a;
            }
            else
            {
                return null;
            }
        }
    }
}

