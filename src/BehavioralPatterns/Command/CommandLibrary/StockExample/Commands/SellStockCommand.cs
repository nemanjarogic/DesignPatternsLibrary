using CommandLibrary.StockExample.Commands.Common;

namespace CommandLibrary.StockExample.Commands
{
    public class SellStockCommand : IOrderCommand
    {
        private readonly Stock _stock;

        public SellStockCommand(Stock stock)
        {
            _stock = stock;
        }

        public void Execute()
        {
            _stock.Sell();
        }
    }
}
