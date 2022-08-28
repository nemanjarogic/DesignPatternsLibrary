using CommandLibrary.StockExample.Commands.Common;

namespace CommandLibrary.StockExample;

public class Broker
{
    private readonly List<IOrderCommand> _orders = new();

    public void TakeOrder(IOrderCommand order) => _orders.Add(order);

    public void ProcessOrders()
    {
        foreach (var order in _orders)
        {
            order.Execute();
        }

        _orders.Clear();
    }
}
