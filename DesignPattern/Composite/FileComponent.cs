using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Composite
{
    abstract class FileComponent
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public abstract void Display();
        public abstract void Add(FileComponent fc);
        public abstract void Remove(FileComponent fc);
    }
}
