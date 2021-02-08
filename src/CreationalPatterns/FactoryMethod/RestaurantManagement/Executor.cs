using System.Reflection;
using DesignPatternsLibrary.PatternExecutors;
using RestaurantManagement.Restaurants;
using RestaurantManagement.Restaurants.Common;

namespace RestaurantManagement
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Factory Method - Creational Pattern";

        public override void Execute()
        {
            Restaurant restaurant = InitializeRestaurant();

            restaurant.OrderDailySpecial();
        }

        private Restaurant InitializeRestaurant()
        {
            // This is usually stored within some configuration
            var choosenType = typeof(FastFoodRestaurant).FullName;

            return Assembly.GetExecutingAssembly().CreateInstance(choosenType) as Restaurant;
        }
    }
}
