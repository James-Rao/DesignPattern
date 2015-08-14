using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Factory
{
    class WarshipFactory
    {
        public Warship GetWarship(String type)
        {
            switch (type.ToLower())
            {
                case "a":
                    return new AegisShip("AegisShip", 30);
                case "b":
                    return new BattleShip("BattleShip", 60);
                default:
                    return null;
            }
        }
    }
}
