using Q2;

public class Program
{
    static void Main(string[] args)
    {
        var  market = new StockMarket();
        var  trader = new StockTrader();

        trader.Subscribe(market);

        market.SimulatePriceChange("AAPL", 150.25);
    }
}