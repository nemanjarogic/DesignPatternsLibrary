using RestaurantAbstractFactory.Common.Factories;
using RestaurantAbstractFactory.Common.Products;
using RestaurantAbstractFactory.FastFood.Products;

namespace RestaurantAbstractFactory.FastFood;

/// <summary>
/// Concrete Factories implement creation methods of the abstract factory.
/// Each concrete factory corresponds to a specific variant of products and creates only those product variants.
/// </summary>
public class FastFoodRestaurantFactory : IRestaurantFactory
{
    public IAppetizer PrepareAppetizer() => new FastFoodAppetizer();

    public IMainCourse PrepareMainCourse() => new FastFoodMainCourse();

    public IDessert PrepareDessert() => new FastFoodDessert();
}
