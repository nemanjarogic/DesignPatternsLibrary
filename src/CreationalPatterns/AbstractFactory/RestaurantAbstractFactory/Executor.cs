using BuildingBlocks;
using RestaurantAbstractFactory.Common.Factories;
using RestaurantAbstractFactory.Common.Products;
using RestaurantAbstractFactory.Vegetarian;

namespace RestaurantAbstractFactory;

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

    // The factory is hardcoded in this example, but it's usually resolved from a configuration.
    private static IRestaurantFactory LoadFactory() =>
        new VegetarianRestaurantFactory();
}
