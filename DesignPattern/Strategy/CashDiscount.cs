using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    class CashDiscount : ICashSuper
    {
        private double discount = 1;

        public CashDiscount(double discount)
        {
            this.discount = discount;
        }

        public double PayAmount(double originalAmount)
        {
            return originalAmount * discount;
        }
    }
}
