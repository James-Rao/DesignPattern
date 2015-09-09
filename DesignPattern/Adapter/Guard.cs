
using System;
namespace DesignPattern.Adapter
{
    class Guard : BasketballPlayer
    {
        public void Attack()
        {
            Console.WriteLine("Guard Attack");
        }
        public void Defense()
        {
            Console.WriteLine("Guard Defense");
        }
    }
}