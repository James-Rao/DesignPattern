using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    class AustralianVegetable : IVegetable
    {
        public void Display()
        {
            Console.WriteLine("Un-cooked Vegetable - Australian");
        }
    }
}
