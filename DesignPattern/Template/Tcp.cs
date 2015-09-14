using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Template
{
    class Tcp : MediaProtocol
    {
        public override void Recv()
        {
            Console.WriteLine("TCP Recv");
        }

        public override void Send()
        {
            Console.WriteLine("TCP Send");
        }
    }
}
