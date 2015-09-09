using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Facade
{
    class Stock
    {
        internal void Buy()
        {
            Console.WriteLine("Buy Stock");
        }

        internal void Sell()
        {
            Console.WriteLine("Sell Stock");
        }
    }
}
