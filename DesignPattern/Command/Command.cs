using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command
{
    abstract class Command
    {
        protected Cook cook;
        public Command(Cook c)
        {
            cook = c;
        }
        public void Execute()
        {
            cook.Work();
        }
    }
}
