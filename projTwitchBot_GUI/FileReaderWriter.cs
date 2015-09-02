﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.SQLite;

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

        public static void WriteBinary(string path, List<DynamicCommands> a)
        {
            FileStream fs = new FileStream(path, FileMode.Create);

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

        public static List<DynamicCommands> ReadBinary(string path)
        {
            if (!(path == ""))
            {
                List<DynamicCommands> a = null;

                FileStream fs = new FileStream(path, FileMode.Open);
                try
                {
                    BinaryFormatter formatter = new BinaryFormatter();

                    a = (List<DynamicCommands>)formatter.Deserialize(fs);
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

        //public static void CreateSqliteDatabase()
        //{
        //    SQLiteConnection.CreateFile("BotBase.sqlite");
        //    SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=BotBase.sqlite;Version=3;");
        //    string sql = "create table highscores (name Varchar(20), score int)";

        //    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
        //    command.ExecuteNonQuery();

        //    sql = "create table commands (name Varchar(45), score int)";

        //    command = new SQLiteCommand(sql, m_dbConnection);
        //    command.ExecuteNonQuery();

        //    sql = "insert into highscores (name, score) values ('Me', 3000)";
        //    command = new SQLiteCommand(sql, m_dbConnection);
        //    command.ExecuteNonQuery();

        //    sql = "insert into highscores (name, score) values ('Myself', 6000)";
        //    command = new SQLiteCommand(sql, m_dbConnection);
        //    command.ExecuteNonQuery();

        //    sql = "insert into highscores (name, score) values ('And I', 9001)";
        //    command = new SQLiteCommand(sql, m_dbConnection);
        //    command.ExecuteNonQuery();

        //    m_dbConnection.Close();
        //}

        public static SQLiteConnection databaseConnection()
        {
            if (File.Exists("BotBase.sqlite"))
            {
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=BotBase.sqlite;Version=3;");
                return m_dbConnection;
            }
            else
            {
                SQLiteConnection.CreateFile("BotBase.sqlite");
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=BotBase.sqlite;Version=3;");

                string sql = "create table streamMods (" +
                                    "mod_username TEXT(200) NOT NULL PRIMARY KEY," + 
                                    "mod_status TEXT(5)" +
                             ")";
     
                m_dbConnection.Open();
                SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();

                sql = "create table streamCommands (" +
                            "command_id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT," + 
                            "command_name TEXT(75) NOT NULL," + 
                            "creator_name TEXT(200) NOT NULL," +
                            "play_music TEXT(5) NOT NULL," +
                            "chat_response TEXT(5) NOT NULL," +
                            "FOREIGN KEY(creator_name) REFERENCES streamMods(mod_username)" +
                       ")";

                command = new SQLiteCommand(sql, m_dbConnection);
                command.ExecuteNonQuery();
                m_dbConnection.Close();
                return m_dbConnection;
            }
        }

        public static void ExecuteCommand(SQLiteConnection m_dbConnection, string sql)
        {
            m_dbConnection.Open();
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            command.ExecuteNonQuery();
        }
    }
}


