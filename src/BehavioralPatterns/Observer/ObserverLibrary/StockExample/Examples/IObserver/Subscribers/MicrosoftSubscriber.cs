namespace ObserverLibrary.StockExample.Examples.IObserver.Subscribers;

public class MicrosoftSubscriber : IObserver<Stock>
{
    private const decimal StockTargetPrice = 230.0m;

    public void OnCompleted() =>
        Console.WriteLine("Preparing daily report...");

    public void OnError(Exception error) =>
        Console.WriteLine("Error occured in the stock ticker.");

    public void OnNext(Stock stock)
    {
        if (stock.Symbol == "MSFT" && stock.Price >= StockTargetPrice)
        {
            Console.WriteLine($"Microsoft's stock price has met or exceeded the target price of {StockTargetPrice:C}. The new price is: {stock.Price:C}");
        }
    }
}
