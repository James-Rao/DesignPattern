using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    class SydneyStock : IStock
    {
        private List<IObserver> observers;

        public SydneyStock()
        {
            observers = new List<IObserver>();
        }

        public void Register(IObserver io)
        {
            observers.Add(io);
        }
        public void Unregister(IObserver io)
        {
            observers.Remove(io);
        }
        public void Notify(double newPrice)
        {
            foreach (var item in observers)
            {
                item.Update(newPrice);
            }
        }
    }
}
