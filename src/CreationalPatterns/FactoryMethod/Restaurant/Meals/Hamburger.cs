using RestaurantManagement.Meals.Common;
using System;

namespace RestaurantManagement.Meals
{
    public class Hamburger : IMeal
    {
        public void ShowIngredients()
        {
            Console.WriteLine("Hamburger: beef meat, Worcestershire sauce and cheese.");
        }
    }
}
