using ObserverLibrary.StockExample.Examples.EventAndDelegate.Publishers;

namespace ObserverLibrary.StockExample.Examples.EventAndDelegate.Subscribers;

public class MicrosoftSubscriber
{
    private const decimal StockTargetPrice = 230.0m;

    public MicrosoftSubscriber(StockTicker stockTicker)
    {
        stockTicker.StockChange += CheckFilterWhenStockChanged!;
    }

    private void CheckFilterWhenStockChanged(object sender, StockChangeEventArgs e)
    {
        var symbol = e.Stock.Symbol;
        var price = e.Stock.Price;

        if (symbol == "MSFT" && price >= StockTargetPrice)
        {
            Console.WriteLine($"Microsoft's stock price has met or exceeded the target price of {StockTargetPrice:C}. The new price is: {price:C}");
        }
    }
}
