using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public abstract class ToppingPizza : Pizza
    {
        protected Pizza originalPizza;

        public ToppingPizza(Pizza p)
        {
            originalPizza = p;
        }
        public abstract void GetDescription();
    }
}
