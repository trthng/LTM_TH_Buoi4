using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_Client
{
    class Program
    {
        private static DHCPClient client;
        static void Main(string[] args)
        {
            client = new DHCPClient();
            System.Console.WriteLine("Received: " + client.requestAddress());
            System.Console.ReadKey();
        }
    }
}
