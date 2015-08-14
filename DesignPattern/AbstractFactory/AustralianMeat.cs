using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    class AustralianMeat : IMeat
    {
        public void Display()
        {
            Console.WriteLine("Half-cooked Meat - Australian");
        }
    }
}
