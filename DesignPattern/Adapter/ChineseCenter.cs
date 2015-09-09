using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Adapter
{
    class ChineseCenter
    {
        internal void 进攻()
        {
            Console.WriteLine("中国籍中锋 进攻");
        }

        internal void 防守()
        {
            Console.WriteLine("中国籍中锋 防守");
        }
    }
}
