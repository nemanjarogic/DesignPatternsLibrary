namespace ObserverLibrary.StockExample.Examples.EventAndDelegate.Publishers;

public class StockTicker
{
    private Stock _lastChangedStock = Stock.Default();
    public event EventHandler<StockChangeEventArgs>? StockChange;

    public void ProcessNewStockChange(Stock stock)
    {
        _lastChangedStock = stock;
        OnStockChange(new StockChangeEventArgs(_lastChangedStock));
    }

    private void OnStockChange(StockChangeEventArgs e) =>
        StockChange?.Invoke(this, e);
}
