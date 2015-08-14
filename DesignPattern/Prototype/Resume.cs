using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    class Resume : Prototype //ICloneable
    {
        public int id;
        public string Name { get; set; }
        public Experience Experience { get; set; }

        public Resume()
        {
            Experience = new Experience();
        }

        //public object Clone()
        //{
        //    Resume r = new Resume();
        //    r.id = this.id;
        //    r.Name = this.Name;

        //    r.Experience = (Experience)this.Experience.Clone();
        //    return r;
        //}
    }
}
