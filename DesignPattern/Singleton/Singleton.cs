using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    sealed class MySingleton
    {
        private static readonly MySingleton instance = new MySingleton();
        private MySingleton() { }

        public static MySingleton GetInstance()
        {
            return instance;
        }
    }
}
