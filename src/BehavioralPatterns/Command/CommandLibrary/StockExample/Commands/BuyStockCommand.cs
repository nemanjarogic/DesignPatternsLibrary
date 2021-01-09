using CommandLibrary.StockExample.Commands.Common;

namespace CommandLibrary.StockExample.Commands
{
    public class BuyStockCommand : IOrderCommand
    {
        private readonly Stock _stock;

        public BuyStockCommand(Stock stock)
        {
            _stock = stock;
        }

        public void Execute()
        {
            _stock.Buy();
        }
    }
}
