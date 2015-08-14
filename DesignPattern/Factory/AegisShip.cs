using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Factory
{
    class AegisShip : Warship
    {
        public AegisShip(String name, int damage)
            : base(name, damage)
        {

        }
        public override void Fight()
        {
            Console.WriteLine("Fight fast: " + Name + " " + Damage);
        }
    }
}
