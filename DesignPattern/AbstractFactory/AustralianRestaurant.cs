using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.AbstractFactory
{
    class AustralianRestaurant : IRestaurant
    {
        public IVegetable CookVegetable()
        {
            return new AustralianVegetable();
        }
        public IMeat CookMeat()
        {
            return new AustralianMeat();
        }
    }
}
