using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Command
{
    class BarbecuerCommand : Command
    {
        public BarbecuerCommand(Cook c)
            : base(c)
        {

        }
    }
}
