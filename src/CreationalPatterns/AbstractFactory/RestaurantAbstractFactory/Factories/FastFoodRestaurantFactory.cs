using RestaurantAbstractFactory.Factories.Common;
using RestaurantAbstractFactory.Meals.Common;
using RestaurantAbstractFactory.Meals.FastFood;

namespace RestaurantAbstractFactory.Factories
{
    /// <summary>
    /// Concrete Factories implement creation methods of the abstract factory.
    /// Each concrete factory corresponds to a specific variant of products and creates only those product variants.
    /// </summary>
    public class FastFoodRestaurantFactory : IRestaurantFactory
    {
        public IAppetizer PrepareAppetizer()
        {
            return new FastFoodAppetizer();
        }

        public IMainCourse PrepareMainCourse()
        {
            return new FastFoodMainCourse();
        }

        public IDessert PrepareDessert()
        {
            return new FastFoodDessert();
        }
    }
}
