using RestaurantAbstractFactory.Common.Products;

namespace RestaurantAbstractFactory.Common.Factories;

/// <summary>
/// The Abstract Factory interface declares a set of methods for creating each of the abstract products.
/// </summary>
public interface IRestaurantFactory
{
    IAppetizer PrepareAppetizer();

    IMainCourse PrepareMainCourse();

    IDessert PrepareDessert();
}