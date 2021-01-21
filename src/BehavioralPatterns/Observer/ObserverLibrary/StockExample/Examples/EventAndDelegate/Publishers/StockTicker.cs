using System;

namespace ObserverLibrary.StockExample.Examples.EventAndDelegate.Publishers
{
    public class StockTicker
    {
        private Stock _stock;

        public event EventHandler<StockChangeEventArgs> StockChange;

        public Stock Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
                OnStockChange(new StockChangeEventArgs(_stock));
            }
        }

        private void OnStockChange(StockChangeEventArgs e)
        {
            StockChange?.Invoke(this, e);
        }
    }
}
