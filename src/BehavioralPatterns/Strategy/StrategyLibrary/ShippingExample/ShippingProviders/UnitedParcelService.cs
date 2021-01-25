using StrategyLibrary.ShippingExample.ShippingProviders.Common;

namespace StrategyLibrary.ShippingExample.ShippingProviders
{
    public class UnitedParcelService : IShippingProvider
    {
        public decimal CalculateCost(Order order)
        {
            return 9;
        }
    }
}
