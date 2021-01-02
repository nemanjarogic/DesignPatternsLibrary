using System;
using RestaurantAbstractFactory.Meals.Common;

namespace RestaurantAbstractFactory.Meals.FastFood
{
    public class FastFoodMainCourse : IMainCourse
    {
        public void ShowDescription()
        {
            Console.WriteLine("Hamburger - with beef meat, Worcestershire sauce and cheese.");
        }

        public void ShowRecommendedDrink()
        {
            Console.WriteLine("Beer.");
        }
    }
}
