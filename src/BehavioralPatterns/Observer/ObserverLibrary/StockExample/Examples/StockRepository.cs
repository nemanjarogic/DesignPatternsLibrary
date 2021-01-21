using System.Collections.Generic;

namespace ObserverLibrary.StockExample.Examples
{
    public class StockRepository
    {
        private static readonly Stock[] Stocks = new Stock[]
        {
            new Stock { Symbol = "MSFT",  Price = 225.35m },
            new Stock { Symbol = "MSFT",  Price = 226.00m },
            new Stock { Symbol = "GOOG",  Price = 1887.75m },
            new Stock { Symbol = "MSFT",  Price = 222.20m },
            new Stock { Symbol = "MSFT",  Price = 217.70m },
            new Stock { Symbol = "GOOG",  Price = 1882.00m },
            new Stock { Symbol = "GOOG",  Price = 1879.00m },
            new Stock { Symbol = "MSFT",  Price = 231.00m },
        };

        public static IEnumerable<Stock> GetData()
        {
            foreach (var stock in Stocks)
            {
                yield return stock;
            }
        }
    }
}
