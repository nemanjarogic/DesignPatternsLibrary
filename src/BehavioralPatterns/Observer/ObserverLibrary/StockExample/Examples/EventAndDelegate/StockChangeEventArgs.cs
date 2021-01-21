using System;

namespace ObserverLibrary.StockExample.Examples.EventAndDelegate
{
    public class StockChangeEventArgs : EventArgs
    {
        public StockChangeEventArgs(Stock stock)
        {
            Stock = stock;
        }

        public Stock Stock { get; set; }
    }
}
