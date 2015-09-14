using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Bridge
{
    class Communication
    {
        IProtocol _protocol;

        public void SetProtocol(IProtocol p)
        {
            _protocol = p;
        }

        public void Work()
        {
            _protocol.Send();
            _protocol.Recv();
        }
    }
}
