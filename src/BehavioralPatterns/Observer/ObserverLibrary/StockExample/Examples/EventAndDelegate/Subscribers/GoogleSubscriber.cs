using ObserverLibrary.StockExample.Examples.EventAndDelegate.Publishers;

namespace ObserverLibrary.StockExample.Examples.EventAndDelegate.Subscribers;

public class GoogleSubscriber
{
    public GoogleSubscriber(StockTicker stockTicker)
    {
        stockTicker.StockChange += CheckFilterWhenStockChanged!;
    }

    private void CheckFilterWhenStockChanged(object sender, StockChangeEventArgs e)
    {
        var symbol = e.Stock.Symbol;
        var price = e.Stock.Price;

        if (symbol == "GOOG")
        {
            Console.WriteLine($"Google's stock price has changed. The new price is: {price:C}");
        }
    }
}
