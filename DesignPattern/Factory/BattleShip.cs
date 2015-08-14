using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Factory
{
    class BattleShip : Warship
    {
        public BattleShip(String name, int damage)
            : base (name, damage)
        {

        }
        public override void Fight()
        {
            Console.WriteLine("Fight Slow: " + Name + " " + Damage);
        }
    }
}
