using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Bridge
{ 
    class Tcp : IProtocol
    {
        public void Recv()
        {
            Console.WriteLine("TCP Recv");
        }

        public void Send()
        {
            Console.WriteLine("TCP Send");
        }
    }
}
