using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory
{
    abstract class Warship
    {
        public String Name { get; set; }
        public int Damage { get; set; }

        public Warship(String name, int damage)
        {
            Name = name;
            Damage = damage;
        }

        public abstract void Fight();
    }
}
