using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Bai2_Test
{
    class Program
    {
        static byte[] receive, send;
        static void Main(string[] args)
        {
            receive = new byte[1];
            send = new byte[1] { 1 };

            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ip = new IPEndPoint(IPAddress.Any, 1724);
            server.Bind(ip);
            Console.WriteLine("Server is waiting...");
            EndPoint Client = (EndPoint)ip;

            server.ReceiveFrom(receive, ref Client);        //receive hello packet
            if (receive[0] == 1)
                server.SendTo(send, Client);        //respond hi back
            Console.WriteLine("Received a hello packet and responded back.");
            Console.ReadKey();
            server.Close();
        }
    }
}
