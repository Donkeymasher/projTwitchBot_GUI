using System;
using System.Net.Sockets;

namespace ProjTwitchBotVisual
{
    static class Connection
    {
        public static TcpClient Con(int port, string server)
        {
            //Connect to irc server and get input and output text streams from TcpClient.
            TcpClient sock = new TcpClient();
            sock.Connect(server, port);
            if (!sock.Connected)
            {
                Console.WriteLine("Failed to connect!");
            }
            return sock;
        }
    }
}
