using BuildingBlocks;
using ObserverLibrary.StockExample.Examples.IObserver.Publishers;
using ObserverLibrary.StockExample.Examples.IObserver.Subscribers;

namespace ObserverLibrary.StockExample.Examples.IObserver
{
    public static class ObserverExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Stock - IObserver example");

            // Monitor a stock ticker, when particular events occur, react
            var stockTicker = new StockTicker();

            var googleSubscriber = new GoogleSubscriber();
            var microsoftSubscriber = new MicrosoftSubscriber();

            // With using statements we release resources after usage
            using (stockTicker.Subscribe(googleSubscriber))
            using (stockTicker.Subscribe(microsoftSubscriber))
            {
                // Load the sample stock data
                foreach (Stock stock in StockRepository.GetData())
                {
                    stockTicker.Stock = stock;
                }
            }
        }
    }
}
