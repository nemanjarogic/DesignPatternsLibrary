using DesignPatternsLibrary.PatternExecutors;
using RestaurantAbstractFactory.Factories;
using RestaurantAbstractFactory.Factories.Common;

namespace RestaurantAbstractFactory
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Abstract Factory Pattern - Restaurant Abstract Factory";

        public override void Execute()
        {
            IRestaurantFactory factory = LoadFactory();

            var appetizer = factory.PrepareAppetizer();
            appetizer.ShowDescription();

            var mainCourse = factory.PrepareMainCourse();
            mainCourse.ShowDescription();

            var dessert = factory.PrepareDessert();
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
