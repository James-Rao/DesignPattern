using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Facade
{
    class NationalDebt
    {
        internal void Buy()
        {
            Console.WriteLine("Buy National Debt");
        }

        internal void Sell()
        {
            Console.WriteLine("Sell National Debt");
        }
    }
}
