using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    class PersonBuilderDirector
    {
        private IPersonBuilder _pb;
        public PersonBuilderDirector(IPersonBuilder ipb)
        {
            this._pb = ipb;
        }

        public void BuildPerson()
        {
            _pb.BuildHead();
            _pb.BuildTorso();
            _pb.BuildFoot();
        }
    }
}
