using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command
{
    class FryDishCommand : Command
    {
        public FryDishCommand(Cook c)
            : base(c)
        {

        }
    }
}
