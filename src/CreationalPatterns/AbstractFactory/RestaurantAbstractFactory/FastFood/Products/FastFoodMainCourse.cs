using RestaurantAbstractFactory.Common.Products;

namespace RestaurantAbstractFactory.FastFood.Products;

public class FastFoodMainCourse : IMainCourse
{
    public void ShowDescription() => Console.WriteLine("Hamburger - with beef meat, Worcestershire sauce and cheese.");

    public void ShowRecommendedDrink() => Console.WriteLine("Beer.");
}
