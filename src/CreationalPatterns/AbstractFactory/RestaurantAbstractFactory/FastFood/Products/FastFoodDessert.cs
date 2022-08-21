using RestaurantAbstractFactory.Common.Products;

namespace RestaurantAbstractFactory.FastFood.Products;

public class FastFoodDessert : IDessert
{
    public void ShowDescription() => Console.WriteLine("Pancakes - with nutella and bananas.");

    public void ShowSugarAmount() => Console.WriteLine("High sugar amount.");
}
