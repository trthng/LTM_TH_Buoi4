using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_Server
{
    class Program
    {
        private static DHCPServer dhcpd;

        static void Main(string[] args)
        {
            dhcpd = new DHCPServer(100, 150);
            while (true)
                dhcpd.startListening();
        }
    }
}
