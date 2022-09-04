namespace ObserverLibrary.StockExample.Examples;

public class Stock
{
    public string Symbol { get; set; } = string.Empty;
    public decimal Price { get; set; }

    public static Stock Default() =>
        new() { Symbol = "Default", Price = 0 };
}
