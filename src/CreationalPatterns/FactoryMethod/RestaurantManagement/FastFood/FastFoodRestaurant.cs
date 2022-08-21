using RestaurantManagement.Common;

namespace RestaurantManagement.FastFood;

/// <summary>
/// Concrete creators override the base factory method so it returns a different type of product.
/// </summary>
public class FastFoodRestaurant : Restaurant
{
    public override IMeal PrepareMainCourse() => new Hamburger();
}
