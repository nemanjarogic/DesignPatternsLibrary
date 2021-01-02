using RestaurantAbstractFactory.Factories.Common;
using RestaurantAbstractFactory.Meals.Common;
using RestaurantAbstractFactory.Meals.Vegetarian;

namespace RestaurantAbstractFactory.Factories
{
    /// <summary>
    /// Concrete Factories implement creation methods of the abstract factory.
    /// Each concrete factory corresponds to a specific variant of products and creates only those product variants.
    /// </summary>
    public class VegetarianRestaurantFactory : IRestaurantFactory
    {
        public IAppetizer PrepareAppetizer()
        {
            return new VegetarianAppetizer();
        }

        public IMainCourse PrepareMainCourse()
        {
            return new VegetarianMainCourse();
        }

        public IDessert PrepareDessert()
        {
            return new VegetarianDessert();
        }
    }
}
