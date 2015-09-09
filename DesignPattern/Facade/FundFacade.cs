using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Facade
{
    class FundFacade
    {
        Stock stock;
        NationalDebt nationalDebt;
        Realty realty;

        public FundFacade()
        {
            stock = new Stock();
            nationalDebt = new NationalDebt();
            realty = new Realty();
        }

        public void Buy()
        {
            stock.Buy();
            nationalDebt.Buy();
            realty.Buy();
        }

        public void Sell()
        {
            stock.Sell();
            nationalDebt.Sell();
            realty.Sell();
        }
    }
}
