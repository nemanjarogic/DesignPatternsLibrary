using RestaurantManagement.Meals;
using RestaurantManagement.Meals.Common;
using RestaurantManagement.Restaurants.Common;

namespace RestaurantManagement.Restaurants
{
    /// <summary>
    /// Concrete creators override the base factory method so it returns a different type of product.
    /// </summary>
    public class BarbequeRestaurant : Restaurant
    {
        public override IMeal PrepareMainCourse()
        {
            return new Hamburger();
        }
    }
}
