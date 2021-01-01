using RestaurantManagement.Meals;
using RestaurantManagement.Meals.Common;
using RestaurantManagement.Restaurants.Common;

namespace RestaurantManagement.Restaurants
{
    public class BarbequeRestaurant : Restaurant
    {
        public override IMeal GetMainCourse()
        {
            return new Hamburger();
        }
    }
}
