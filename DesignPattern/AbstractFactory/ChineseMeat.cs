using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    class ChineseMeat : IMeat
    {
        public void Display()
        {
            Console.WriteLine("Stir-fried Meat - Chinese");
        }
    }
}
