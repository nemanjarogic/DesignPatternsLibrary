using BuildingBlocks;
using ObserverLibrary.StockExample.Examples.Traditional.Publishers;
using ObserverLibrary.StockExample.Examples.Traditional.Subscribers;

namespace ObserverLibrary.StockExample.Examples.Traditional;

public static class TraditionalExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Stock - traditional example");

        // Monitor a stock ticker, and react when particular events occur.
        var stockTicker = new StockTicker();

        // Create new subscribers to listen to the stock ticker.
        var googleSubscriber = new GoogleSubscriber(stockTicker);
        var microsoftSubscriber = new MicrosoftSubscriber(stockTicker);

        // Load the sample stock data.
        foreach (Stock stock in StockRepository.GetData())
        {
            stockTicker.ProcessNewStockChange(stock);
        }
    }
}
