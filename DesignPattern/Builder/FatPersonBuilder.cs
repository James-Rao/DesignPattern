using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    class FatPersonBuilder : IPersonBuilder
    {
        public void BuildHead()
        {
            Console.WriteLine("Fat Person Head");
        }
        public void BuildTorso()
        {
            Console.WriteLine("Fat Person Torso");
        }
        public void BuildFoot()
        {
            Console.WriteLine("Fat Person Foot");
        }
    }
}
