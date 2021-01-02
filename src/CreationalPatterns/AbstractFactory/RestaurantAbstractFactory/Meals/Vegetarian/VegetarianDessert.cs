using System;
using RestaurantAbstractFactory.Meals.Common;

namespace RestaurantAbstractFactory.Meals.Vegetarian
{
    public class VegetarianDessert : IDessert
    {
        public void ShowDescription()
        {
            Console.WriteLine("Rice Pudding - with milk and vanilla extract");
        }

        public void ShowSugarAmount()
        {
            Console.WriteLine("Low sugar amount.");
        }
    }
}
