using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    abstract class PersonBuilderDirectorBase
    {
        protected IPersonBuilder _pb;
        public void SetPersonBuilder(IPersonBuilder pb)
        {
            this._pb = pb;
        }

        public abstract void BuildPerson();
    }
}
