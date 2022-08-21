using RestaurantAbstractFactory.Common.Products;

namespace RestaurantAbstractFactory.Vegetarian.Products;

/// <summary>
/// Concrete Products are various implementations of abstract products, grouped by variants.
/// </summary>
public class VegetarianAppetizer : IAppetizer
{
    public void ShowDescription() => Console.WriteLine("Broth - with pumpkin.");

    public bool IsBroth() => true;
}
