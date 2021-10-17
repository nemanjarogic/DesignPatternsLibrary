using System;
using BuildingBlocks;
using StrategyLibrary.ShippingExample.ShippingProviders;
using StrategyLibrary.ShippingExample.ShippingProviders.Common;

namespace StrategyLibrary.ShippingExample
{
    public static class ShippingExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Shipping example");

            var originAddress = new Address
            {
                ContactName = "Jonh Doe",
                AddressLine1 = "185 Lincoln St.",
                AddressLine2 = "Suite 305",
                City = "Hingham",
                Country = "U.S.",
                Region = "MA",
                PostalCode = "02043",
            };

            var destinationAddress = new Address
            {
                ContactName = "Anna Taylor",
                AddressLine1 = "125 Main St",
                AddressLine2 = "200 Main St",
                City = "Plympton",
                Country = "U.S.",
                Region = "MA",
                PostalCode = "02367",
            };

            var order = new Order
            {
                Origin = originAddress,
                Destination = destinationAddress,
                Description = "Xiaomi Mi 10T Pro",
            };

            IShippingProvider fedEx = new FedEx();
            var shippingCostCalculationService = new ShippingCostCalculationService(fedEx);

            var price = shippingCostCalculationService.Calculate(order);

            Console.WriteLine($"Shipping price for {order.Description} is {price:C}");
        }
    }
}
