using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    class ChineseRestaurant : IRestaurant
    {
        public IVegetable CookVegetable()
        {
            return new ChineseVegetable();
        }

        public IMeat CookMeat()
        {
            return new ChineseMeat();
        }
    }
}
