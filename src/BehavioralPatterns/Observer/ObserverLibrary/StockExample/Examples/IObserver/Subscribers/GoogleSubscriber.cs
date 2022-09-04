namespace ObserverLibrary.StockExample.Examples.IObserver.Subscribers;

public class GoogleSubscriber : IObserver<Stock>
{
    public void OnCompleted() =>
        Console.WriteLine("Preparing daily report...");

    public void OnError(Exception error) =>
        Console.WriteLine("Error occurred in the stock ticker.");

    public void OnNext(Stock stock)
    {
        if (stock.Symbol == "GOOG")
        {
            Console.WriteLine($"Google's stock price has changed. The new price is: {stock.Price}");
        }
    }
}
