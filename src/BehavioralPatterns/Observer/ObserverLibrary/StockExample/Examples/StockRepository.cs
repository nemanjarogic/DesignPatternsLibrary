namespace ObserverLibrary.StockExample.Examples;

public class StockRepository
{
    private static readonly Stock[] Stocks =
    {
        new() { Symbol = "MSFT",  Price = 225.35m },
        new() { Symbol = "MSFT",  Price = 226.00m },
        new() { Symbol = "GOOG",  Price = 105.75m },
        new() { Symbol = "MSFT",  Price = 222.20m },
        new() { Symbol = "MSFT",  Price = 217.70m },
        new() { Symbol = "GOOG",  Price = 130.00m },
        new() { Symbol = "GOOG",  Price = 128.00m },
        new() { Symbol = "MSFT",  Price = 231.00m },
    };

    public static IEnumerable<Stock> GetData()
    {
        foreach (var stock in Stocks)
        {
            yield return stock;
        }
    }
}
