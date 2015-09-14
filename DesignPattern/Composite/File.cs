using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Composite
{
    class File : FileComponent
    {
        public override void Display()
        {
            Console.WriteLine(Name + ", " + Description);
        }

        public override void Add(FileComponent fc)
        {
            throw new NotImplementedException();
        }

        public override void Remove(FileComponent fc)
        {
            throw new NotImplementedException();
        }
    }
}
