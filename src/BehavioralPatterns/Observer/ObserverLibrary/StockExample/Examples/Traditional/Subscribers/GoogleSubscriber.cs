using ObserverLibrary.StockExample.Examples.Traditional.Publishers;
using ObserverLibrary.StockExample.Examples.Traditional.Subscribers.Common;

namespace ObserverLibrary.StockExample.Examples.Traditional.Subscribers;

public class GoogleSubscriber : Subscriber
{
    private readonly StockTicker _stockTicker;

    public GoogleSubscriber(StockTicker stockTicker)
    {
        _stockTicker = stockTicker;
        _stockTicker.Subscribe(this);
    }

    public override void Update()
    {
        decimal price = _stockTicker.LastChangedStock.Price;
        string symbol = _stockTicker.LastChangedStock.Symbol;

        if (symbol == "GOOG")
        {
            Console.WriteLine($"Google's stock price has changed. The new price is: {price:C}");
        }
    }
}
