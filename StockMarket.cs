using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    public delegate void StockPriceChangedEventHandler(object sender, StockEventArgs e);

    public class StockMarket
    {
        public event StockPriceChangedEventHandler StockPriceChanged;

        public void SimulatePriceChange(string stockName, double newPrice)
        {
            Console.WriteLine($"Price of {stockName} changed to {newPrice}");
            OnStockPriceChanged(stockName, newPrice);
        }

        protected virtual void OnStockPriceChanged(string stockName, double newPrice)
        {
            StockPriceChanged?.Invoke(this, new StockEventArgs(stockName, newPrice));
        }
    }
}
