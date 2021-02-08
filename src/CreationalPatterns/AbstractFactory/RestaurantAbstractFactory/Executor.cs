using DesignPatternsLibrary.PatternExecutors;
using RestaurantAbstractFactory.Factories;
using RestaurantAbstractFactory.Factories.Common;
using RestaurantAbstractFactory.Meals.Common;

namespace RestaurantAbstractFactory
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Abstract Factory - Creational Pattern";

        public override void Execute()
        {
            IRestaurantFactory factory = LoadFactory();

            IAppetizer appetizer = factory.PrepareAppetizer();
            appetizer.ShowDescription();

            IMainCourse mainCourse = factory.PrepareMainCourse();
            mainCourse.ShowDescription();

            IDessert dessert = factory.PrepareDessert();
            dessert.ShowDescription();
            dessert.ShowSugarAmount();
        }

        private IRestaurantFactory LoadFactory()
        {
            // The factory is usually chosen based on some value from the configuration
            return new VegetarianRestaurantFactory();
        }
    }
}
