using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    public class StockTrader
    {
        public void Subscribe(StockMarket market)
        {
            market.StockPriceChanged += HandlePriceChange;
        }

        private void HandlePriceChange(object sender, StockEventArgs e)
        {
            Console.WriteLine($"Received price change notification: {e.StockName} is now {e.NewPrice}");
        }
    }
}
