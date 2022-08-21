using RestaurantAbstractFactory.Common.Products;

namespace RestaurantAbstractFactory.Vegetarian.Products;

public class VegetarianMainCourse : IMainCourse
{
    public void ShowDescription() => Console.WriteLine("Green salad - with lettuce, cucumber and green olives");

    public void ShowRecommendedDrink() => Console.WriteLine("Sparkling water.");
}
