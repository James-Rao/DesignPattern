using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    class CashReturn : ICashSuper
    {
        private double returnCondition = 1;
        private double returnAmount = 1;

        public CashReturn(double returnCondition, double returnAmount)
        {
            this.returnCondition = returnCondition;
            this.returnAmount = returnAmount;
        }

        public double PayAmount(double originalAmount)
        {
            if (originalAmount >= returnCondition)
            {
                return originalAmount - returnAmount;
            }
            return originalAmount;
        }
    }
}
