using System;
using ObserverLibrary.StockExample.Examples.Traditional.Publishers;
using ObserverLibrary.StockExample.Examples.Traditional.Subscribers.Common;

namespace ObserverLibrary.StockExample.Examples.Traditional.Subscribers
{
    public class GoogleSubscriber : Subscriber
    {
        private readonly StockTicker _stockTicker;

        public GoogleSubscriber(StockTicker stockTicker)
        {
            stockTicker.Subscribe(this);
            _stockTicker = stockTicker;
        }

        public override void Update()
        {
            decimal price = _stockTicker.Stock.Price;
            string symbol = _stockTicker.Stock.Symbol;

            if (symbol == "GOOG")
            {
                Console.WriteLine($"Google's new price is: {price:C}");
            }
        }
    }
}
