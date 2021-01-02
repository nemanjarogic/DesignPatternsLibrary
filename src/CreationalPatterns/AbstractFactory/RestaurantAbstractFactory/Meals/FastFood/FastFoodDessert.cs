using System;
using RestaurantAbstractFactory.Meals.Common;

namespace RestaurantAbstractFactory.Meals.FastFood
{
    public class FastFoodDessert : IDessert
    {
        public void ShowDescription()
        {
            Console.WriteLine("Pancakes - with nutella and bananas.");
        }

        public void ShowSugarAmount()
        {
            Console.WriteLine("High sugar amount.");
        }
    }
}
