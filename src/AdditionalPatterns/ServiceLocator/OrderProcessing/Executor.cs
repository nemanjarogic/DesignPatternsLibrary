using System;
using DesignPatternsLibrary.PatternExecutors;

namespace OrderProcessing
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Service Locator - Architectural Pattern";

        public override void Execute()
        {
            IServiceLocator serviceLocator = new ServiceLocator();
            serviceLocator.AddService(new Logger());

            var order = new Order
            {
                ProductId = Guid.NewGuid(),
                UnitPrice = 50,
                Quantity = 2,
            };

            var orderManager = new OrderManager(serviceLocator);
            orderManager.ProcessOrder(order);
        }
    }
}
