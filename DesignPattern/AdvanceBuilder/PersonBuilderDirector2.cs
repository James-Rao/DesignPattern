using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    class PersonBuilderDirector2 : PersonBuilderDirectorBase
    {
        public override void BuildPerson()
        {
            _pb.BuildTorso();
            _pb.BuildFoot();
            _pb.BuildHead();
        }
    }
}
