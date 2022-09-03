using StrategyLibrary.ShippingExample.ShippingProviders.Common;

namespace StrategyLibrary.ShippingExample.ShippingProviders;

public class RoyalMail : IShippingProvider
{
    public decimal CalculateCost(Order order) => 8.5m;
}
