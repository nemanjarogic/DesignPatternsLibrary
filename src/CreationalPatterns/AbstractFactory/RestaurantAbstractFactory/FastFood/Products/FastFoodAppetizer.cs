using RestaurantAbstractFactory.Common.Products;

namespace RestaurantAbstractFactory.FastFood.Products;

/// <summary>
/// Concrete Products are various implementations of abstract products, grouped by variants.
/// </summary>
public class FastFoodAppetizer : IAppetizer
{
    public void ShowDescription() => Console.WriteLine("Bread bites - with garlic and marinara sauce.");

    public bool IsBroth() => false;
}
