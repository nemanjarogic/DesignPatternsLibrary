using BuildingBlocks;
using ObserverLibrary.StockExample.Examples.EventAndDelegate.Publishers;
using ObserverLibrary.StockExample.Examples.EventAndDelegate.Subscribers;

namespace ObserverLibrary.StockExample.Examples.EventAndDelegate;

public static class EventAndDelegateExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Stock - event and delegate example");

        // Monitor a stock ticker, and react when particular events occur.
        var stockTicker = new StockTicker();

        // Create new subscribers to listen to the stock ticker
        var googleSubscriber = new GoogleSubscriber(stockTicker);
        var microsoftSubscriber = new MicrosoftSubscriber(stockTicker);

        // Load the sample stock data
        foreach (Stock stock in StockRepository.GetData())
        {
            stockTicker.ProcessNewStockChange(stock);
        }
    }
}
