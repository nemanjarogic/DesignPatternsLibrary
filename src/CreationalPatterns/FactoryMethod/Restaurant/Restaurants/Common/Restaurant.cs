using RestaurantManagement.Meals.Common;
using System;

namespace RestaurantManagement.Restaurants.Common
{
    public abstract class Restaurant
    {
        public abstract IMeal GetMainCourse();

        public void ShowBasicInformation()
        {
            Console.WriteLine("Payment methods: cash, checks, debit cards and credit cards.");

            Console.WriteLine("The main course with ingredients will be shown below...");
            var mainCourse = GetMainCourse();
            mainCourse.ShowIngredients();
        }
    }
}
