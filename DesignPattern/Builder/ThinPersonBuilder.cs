using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    class ThinPersonBuilder : IPersonBuilder
    {
        public void BuildHead()
        {
            Console.WriteLine("Thin Person Head");
        }
        public void BuildTorso()
        {
            Console.WriteLine("Thin Person Torso");
        }
        public void BuildFoot()
        {
            Console.WriteLine("Thin Person Foot");
        }
    }
}
