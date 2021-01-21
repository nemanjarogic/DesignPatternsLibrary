using System;
using ObserverLibrary.StockExample.Examples.Traditional.Publishers;
using ObserverLibrary.StockExample.Examples.Traditional.Subscribers.Common;

namespace ObserverLibrary.StockExample.Examples.Traditional.Subscribers
{
    public class MicrosoftSubscriber : Subscriber
    {
        private readonly StockTicker _stockTicker;

        public MicrosoftSubscriber(StockTicker stockTicker)
        {
            stockTicker.Subscribe(this);
            _stockTicker = stockTicker;
        }

        public override void Update()
        {
            decimal price = _stockTicker.Stock.Price;
            string symbol = _stockTicker.Stock.Symbol;

            if (symbol == "MSFT" && price > 230.00m)
            {
                Console.WriteLine($"Microsoft has reached the target price: {price:C}");
            }
        }
    }
}
