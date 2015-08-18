using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Decorator
{
    public class PlainPizza : Pizza
    {
        public void GetDescription()
        {
            Console.WriteLine("Plain Pizza");
        }
    }
}
