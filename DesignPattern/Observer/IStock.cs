using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    interface IStock
    {
        void Register(IObserver io);
        void Unregister(IObserver io);
        void Notify(double newPrice);
    }
}
