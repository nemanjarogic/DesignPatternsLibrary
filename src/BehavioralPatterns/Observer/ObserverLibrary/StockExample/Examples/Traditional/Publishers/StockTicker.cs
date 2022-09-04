using ObserverLibrary.StockExample.Examples.Traditional.Publishers.Common;

namespace ObserverLibrary.StockExample.Examples.Traditional.Publishers;

public class StockTicker : Publisher
{
    public Stock LastChangedStock { get; private set; } = Stock.Default();

    public void ProcessNewStockChange(Stock stock)
    {
        LastChangedStock = stock;
        NotifySubscribers();
    }
}
