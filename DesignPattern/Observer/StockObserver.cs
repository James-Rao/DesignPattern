using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    class StockObserver : IObserver
    {
        static int StockOberserIDTracker = 0;
        int StockObserverID;

        public StockObserver()
        {
            ++StockOberserIDTracker;
            StockObserverID = StockOberserIDTracker;
        }

        public void Update(double price)
        {
            Console.WriteLine(StockObserverID + " Update Price With" + price);
        }

    }
}
