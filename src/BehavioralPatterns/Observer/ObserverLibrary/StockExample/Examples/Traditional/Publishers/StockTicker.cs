using ObserverLibrary.StockExample.Examples.Traditional.Publishers.Common;

namespace ObserverLibrary.StockExample.Examples.Traditional.Publishers
{
    public class StockTicker : Publisher
    {
        private Stock stock;

        public Stock Stock
        {
            get
            {
                return stock;
            }
            set
            {
                stock = value;
                Notify();
            }
        }
    }
}
