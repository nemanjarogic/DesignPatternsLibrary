using System;

namespace ObserverLibrary.StockExample.Examples.IObserver.Subscribers
{
    public class MicrosoftSubscriber : IObserver<Stock>
    {
        public void OnCompleted()
        {
            Console.WriteLine("Preparing daily report...");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine("Error occured in the stock ticker.");
        }

        public void OnNext(Stock stock)
        {
            if (stock.Symbol == "MSFT" && stock.Price > 230.00m)
            {
                Console.WriteLine($"Microsoft has reached the target price: {stock.Price:C}");
            }
        }
    }
}
