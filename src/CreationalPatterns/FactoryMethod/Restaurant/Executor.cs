using DesignPatternsLibrary.PatternExecutors;
using RestaurantManagement.Restaurants;
using RestaurantManagement.Restaurants.Common;
using System.Reflection;

namespace RestaurantManagement
{
    public class Executor : PatternExecutor
    {
        public Executor()
            : base("Factory Method Pattern - Restaurant Management")
        {
        }

        public override void Execute()
        {
            var restaurant = InitializeRestaurant();

            restaurant.ShowBasicInformation();
        }


        private Restaurant InitializeRestaurant()
        {
            // This is usually stored within some configuration
            var choosenType = typeof(BarbequeRestaurant).FullName;

            return Assembly.GetExecutingAssembly().CreateInstance(choosenType) as Restaurant;
        }
    }
}
