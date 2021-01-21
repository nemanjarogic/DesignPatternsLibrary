using System;
using ObserverLibrary.StockExample.Examples.EventAndDelegate.Publishers;

namespace ObserverLibrary.StockExample.Examples.EventAndDelegate.Subscribers
{
    public class MicrosoftSubscriber
    {
        public MicrosoftSubscriber(StockTicker stockTicker)
        {
            stockTicker.StockChange += new EventHandler<StockChangeEventArgs>(CheckFilterWhenStockChanged);
        }

        private void CheckFilterWhenStockChanged(object sender, StockChangeEventArgs e)
        {
            var symbol = e.Stock.Symbol;
            var price = e.Stock.Price;

            if (symbol == "MSFT" && price > 230.00m)
            {
                Console.WriteLine($"Microsoft has reached the target price: {price:C}");
            }
        }
    }
}
