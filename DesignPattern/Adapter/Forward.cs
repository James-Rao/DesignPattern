
using System;
namespace DesignPattern.Adapter
{
    class Forward : BasketballPlayer
    {
        public void Attack()
        {
            Console.WriteLine("Forward Attack");
        }
        public void Defense()
        {
            Console.WriteLine("Forward Defense");
        }
    }
}