using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    class Context
    {
        private ICashSuper iCashSuper;
        public Context(ICashSuper ics)
        {
            this.iCashSuper = ics;
        }

        public double PayAmount(double originalAmount)
        {
            double d = iCashSuper.PayAmount(originalAmount);
            Console.WriteLine("Pay " + d);
            return d;
        }
    }
}
