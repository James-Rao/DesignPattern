using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Composite
{
    class FileFolder : FileComponent
    {
        private List<FileComponent> children = new List<FileComponent>();

        public override void Add(FileComponent fc)
        {
            children.Add(fc);
        }

        public override void Remove(FileComponent fc)
        {
            children.Remove(fc);
        }

        public override void Display()
        {
            // itself
            Console.WriteLine(Name + ", " + Description);

            // children
            foreach (var item in children)
            {
                item.Display();
            }
        }
    }
}
