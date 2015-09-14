using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Template
{
    abstract class MediaProtocol
    {
        public void Work()
        {
            Recv();
            Send();
        }
       
        public abstract void Recv();

        public abstract void Send();
    }
}
