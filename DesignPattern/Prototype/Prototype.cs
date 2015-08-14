using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    abstract class Prototype : ICloneable
    {
        public object Clone()
        {
            object cloneResult = (object)this.MemberwiseClone();

            // field
            IEnumerable<object> fieldsInfo = cloneResult.GetType().GetFields();
            foreach (FieldInfo item in fieldsInfo)
            {
                if (!item.FieldType.IsValueType)
                {
                    object obj = item.GetValue(this) ;
                    if (obj is ICloneable)
                    {
                        item.SetValue(cloneResult, ((ICloneable)obj).Clone());
                    }
                }
            }

            // property
            IEnumerable<PropertyInfo> propertiesInfo = cloneResult.GetType().GetProperties();
            foreach (PropertyInfo item in propertiesInfo)
	        {
                Object t = item.GetValue(this);
                if (!item.PropertyType.IsValueType)
                {
                    object obj = item.GetValue(this);
                    if (obj is ICloneable)
                    {
                        item.SetValue(cloneResult, ((ICloneable)obj).Clone());
                    }
                }
	        }
       
            return cloneResult;
        }
    }
}
