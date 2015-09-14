using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Template
{ 
    class Udp : MediaProtocol
    {
        public override void Recv()
        {
            Console.WriteLine("UDP Recv");
        }

        public override void Send()
        {
            Console.WriteLine("UDP Send");
        }
    }
}
