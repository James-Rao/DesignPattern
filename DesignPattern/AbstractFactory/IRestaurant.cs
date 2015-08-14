using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    interface IRestaurant
    {
        IVegetable CookVegetable();
        IMeat CookMeat();
    }
}
