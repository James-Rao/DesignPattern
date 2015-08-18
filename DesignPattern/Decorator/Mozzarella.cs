using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class Mozzarella : ToppingPizza
    {
        public Mozzarella(Pizza p)
            : base(p)
        {
        }

        public override void GetDescription()
        {
            if (originalPizza != null)
            {
                originalPizza.GetDescription();
            }

            Console.WriteLine(" + Mozzarella");
        }
    }
}
