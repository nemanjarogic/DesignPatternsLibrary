using RestaurantAbstractFactory.Common.Factories;
using RestaurantAbstractFactory.Common.Products;
using RestaurantAbstractFactory.Vegetarian.Products;

namespace RestaurantAbstractFactory.Vegetarian;

/// <summary>
/// Concrete Factories implement creation methods of the abstract factory.
/// Each concrete factory corresponds to a specific variant of products and creates only those product variants.
/// </summary>
public class VegetarianRestaurantFactory : IRestaurantFactory
{
    public IAppetizer PrepareAppetizer() => new VegetarianAppetizer();

    public IMainCourse PrepareMainCourse() => new VegetarianMainCourse();

    public IDessert PrepareDessert() => new VegetarianDessert();
}
