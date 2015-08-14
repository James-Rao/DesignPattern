using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    class CashNormal : ICashSuper
    {
        public CashNormal()
        {

        }

        public double PayAmount(double originalMount)
        {
            return originalMount;
        }
    }
}
