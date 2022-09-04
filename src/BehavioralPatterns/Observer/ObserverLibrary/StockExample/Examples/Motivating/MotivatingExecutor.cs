using BuildingBlocks;

namespace ObserverLibrary.StockExample.Examples.Motivating;

public static class MotivatingExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Stock - motivating example");

        // Monitor a stock ticker, and react when particular events occur.
        foreach (Stock stock in StockRepository.GetData())
        {
            // Can we separate these observers?
            if (stock.Symbol == "GOOG")
            {
                // Display every price change.
                Console.WriteLine($"Google's stock price has changed. The new price is: {stock.Price:C}");
            }

            if (stock.Symbol == "MSFT" && stock.Price >= 230.00m)
            {
                // Display only when the price is greater than the given limit.
                Console.WriteLine($"Microsoft's stock price has met or exceeded the target price of {230:C}. The new price is: {stock.Price:C}");
            }
        }
    }
}
