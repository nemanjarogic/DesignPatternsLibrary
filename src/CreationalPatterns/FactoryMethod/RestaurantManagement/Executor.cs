using System.Reflection;
using BuildingBlocks;
using RestaurantManagement.Common;
using RestaurantManagement.FastFood;

namespace RestaurantManagement;

public class Executor : PatternExecutor
{
    public override string Name => "Factory Method - Creational Pattern";

    public override void Execute()
    {
        var restaurant = InitializeRestaurant();
        restaurant.OrderDailySpecial();
    }

    private static Restaurant InitializeRestaurant()
    {
        // Choose between FastFoodRestaurant and VegetarianRestaurant.
        // The choice is hardcoded here, but it's usually made through some configuration.
        var chosenType = typeof(FastFoodRestaurant).FullName!;

        var restaurant = Assembly.GetExecutingAssembly().CreateInstance(chosenType) as Restaurant;
        return restaurant!;
    }
}
