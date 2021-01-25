namespace StrategyLibrary.ShippingExample.ShippingProviders.Common
{
    public interface IShippingProvider
    {
        decimal CalculateCost(Order order);
    }
}
