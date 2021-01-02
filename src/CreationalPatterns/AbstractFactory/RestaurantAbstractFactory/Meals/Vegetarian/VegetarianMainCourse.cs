using System;
using RestaurantAbstractFactory.Meals.Common;

namespace RestaurantAbstractFactory.Meals.Vegetarian
{
    public class VegetarianMainCourse : IMainCourse
    {
        public void ShowDescription()
        {
            Console.WriteLine("Green salad - with lettuce, cucumber and green olives");
        }

        public void ShowRecommendedDrink()
        {
            Console.WriteLine("Sparkling water.");
        }
    }
}
