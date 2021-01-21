using System.Collections.Generic;
using CommandLibrary.StockExample.Commands.Common;

namespace CommandLibrary.StockExample
{
    public class Broker
    {
        private readonly List<IOrderCommand> _orders = new List<IOrderCommand>();

        public void TakeOrder(IOrderCommand order)
        {
            _orders.Add(order);
        }

        public void ProcessOrders()
        {
            foreach (var order in _orders)
            {
                order.Execute();
            }

            _orders.Clear();
        }
    }
}
