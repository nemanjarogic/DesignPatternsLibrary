using ObserverLibrary.StockExample.Examples.Traditional.Publishers;
using ObserverLibrary.StockExample.Examples.Traditional.Subscribers.Common;

namespace ObserverLibrary.StockExample.Examples.Traditional.Subscribers;

public class MicrosoftSubscriber : Subscriber
{
    private const decimal StockTargetPrice = 230.0m;
    private readonly StockTicker _stockTicker;

    public MicrosoftSubscriber(StockTicker stockTicker)
    {
        _stockTicker = stockTicker;
        _stockTicker.Subscribe(this);
    }

    public override void Update()
    {
        decimal price = _stockTicker.LastChangedStock.Price;
        string symbol = _stockTicker.LastChangedStock.Symbol;

        if (symbol == "MSFT" && price >= StockTargetPrice)
        {
            Console.WriteLine($"Microsoft's stock price has met or exceeded the target price of {StockTargetPrice:C}. The new price is: {price:C}");
        }
    }
}
