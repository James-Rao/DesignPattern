using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    interface IPersonBuilder
    {
        void BuildHead();
        void BuildTorso();
        void BuildFoot();
    }
}
