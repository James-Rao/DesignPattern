using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Bridge
{
    interface IProtocol
    {
        void Recv();

        void Send();
    }
}
