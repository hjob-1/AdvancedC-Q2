using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    public class StockEventArgs : EventArgs
    {
        public string StockName { get; }
        public double NewPrice { get; }

        public StockEventArgs(string stockName, double newPrice)
        {
            StockName = stockName;
            NewPrice = newPrice;
        }
    }
}
