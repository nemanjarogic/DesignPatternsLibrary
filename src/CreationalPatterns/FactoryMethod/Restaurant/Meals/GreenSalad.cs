using RestaurantManagement.Meals.Common;
using System;

namespace RestaurantManagement.Meals
{
    public class GreenSalad : IMeal
    {
        public void ShowIngredients()
        {
            Console.WriteLine("Green salad: lettuce, cucumber and green olives");
        }
    }
}
