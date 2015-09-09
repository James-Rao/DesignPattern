using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Prototype
{
    class Experience : Prototype //ICloneable
    {
        public string Company { get; set; }
        public int Years { get; set; }

        //public object Clone()
        //{
        //    return (object)this.MemberwiseClone();
        //}

        public override string ToString()
        {
            return Company + " " + Years;
        }
    }
}
