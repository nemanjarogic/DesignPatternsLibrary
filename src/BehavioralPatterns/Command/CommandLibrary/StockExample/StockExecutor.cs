using BuildingBlocks;
using CommandLibrary.StockExample.Commands;

namespace CommandLibrary.StockExample
{
    public static class StockExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Stock example");

            var stock = new Stock("Tesla", 5);

            var buyStock = new BuyStockCommand(stock);
            var sellStock = new SellStockCommand(stock);

            var broker = new Broker();
            broker.TakeOrder(buyStock);
            broker.TakeOrder(sellStock);

            broker.ProcessOrders();
        }
    }
}
