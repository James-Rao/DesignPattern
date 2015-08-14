using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    class PersonBuilderDirector1 : PersonBuilderDirectorBase
    {
        public override void BuildPerson()
        {
            _pb.BuildFoot();
            _pb.BuildTorso();
            _pb.BuildHead();
        }
    }
}
