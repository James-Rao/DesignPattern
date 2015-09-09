using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Facade
{
    class Realty
    {
        internal void Buy()
        {
            Console.WriteLine("Buy Realty");
        }

        internal void Sell()
        {
            Console.WriteLine("Sell Realty");
        }
    }
}
