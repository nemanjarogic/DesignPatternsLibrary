using StrategyLibrary.ShippingExample.ShippingProviders.Common;

namespace StrategyLibrary.ShippingExample.ShippingProviders
{
    public class FedEx : IShippingProvider
    {
        public decimal CalculateCost(Order order)
        {
            return 10;
        }
    }
}
