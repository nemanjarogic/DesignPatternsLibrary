using System;
using BuildingBlocks;

namespace ObserverLibrary.StockExample.Examples.Motivating
{
    public static class MotivatingExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Stock - motivating example");

            // Monitor a stock ticker, when particular events occur, react
            foreach (Stock stock in StockRepository.GetData())
            {
                // Can we separate these observers?
                if (stock.Symbol == "GOOG")
                {
                    Console.WriteLine($"Google's new price is: {stock.Price:C}");
                }

                if (stock.Symbol == "MSFT" && stock.Price > 230.00m)
                {
                    Console.WriteLine($"Microsoft has reached the target price: {stock.Price:C}");
                }
            }
        }
    }
}
