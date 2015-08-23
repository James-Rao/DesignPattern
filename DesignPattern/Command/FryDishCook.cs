using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Command
{
    class FryDishCook : Cook
    {
        public void Work()
        {
            Console.WriteLine("Fry Dish");
        }
    }
}
