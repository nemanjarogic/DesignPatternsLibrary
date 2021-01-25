using StrategyLibrary.ShippingExample.ShippingProviders.Common;

namespace StrategyLibrary.ShippingExample
{
    public class ShippingCostCalculationService
    {
        private readonly IShippingProvider _shippingProvider;

        public ShippingCostCalculationService(IShippingProvider shippingCostStrategy)
        {
            _shippingProvider = shippingCostStrategy;
        }

        public decimal Calculate(Order order)
        {
            return _shippingProvider.CalculateCost(order);
        }
    }
}
