using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Command
{
    class BarbecuerCook : Cook
    {
        public void Work()
        {
            Console.WriteLine("Roast Meat");
        }
    }
}
