using RestaurantManagement.Common;

namespace RestaurantManagement.Vegetarian;

/// <summary>
/// Concrete creators override the base factory method so it returns a different type of product.
/// </summary>
public class VegetarianRestaurant : Restaurant
{
    public override IMeal PrepareMainCourse() => new GreenSalad();
}
