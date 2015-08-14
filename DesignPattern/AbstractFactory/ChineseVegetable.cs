using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    class ChineseVegetable : IVegetable
    {
        public void Display()
        {
            Console.WriteLine("Stir-fried Vegetable - Chinese");
        }
    }
}
