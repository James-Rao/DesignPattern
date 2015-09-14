using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Bridge
{ 
    class Udp : IProtocol
    {
        public void Recv()
        {
            Console.WriteLine("UDP Recv");
        }

        public void Send()
        {
            Console.WriteLine("UDP Send");
        }
    }
}
