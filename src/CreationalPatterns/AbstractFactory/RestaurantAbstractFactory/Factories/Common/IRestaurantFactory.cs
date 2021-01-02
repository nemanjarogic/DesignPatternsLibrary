using RestaurantAbstractFactory.Meals.Common;

namespace RestaurantAbstractFactory.Factories.Common
{
    /// <summary>
    /// The Abstract Factory interface declares a set of methods for creating each of the abstract products.
    /// </summary>
    public interface IRestaurantFactory
    {
        IAppetizer PrepareAppetizer();

        IMainCourse PrepareMainCourse();

        IDessert PrepareDessert();
    }
}
