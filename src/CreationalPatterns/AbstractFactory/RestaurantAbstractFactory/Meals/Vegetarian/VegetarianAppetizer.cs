using System;
using RestaurantAbstractFactory.Meals.Common;

namespace RestaurantAbstractFactory.Meals.Vegetarian
{
    /// <summary>
    /// Concrete Products are various implementations of abstract products, grouped by variants.
    /// </summary>
    public class VegetarianAppetizer : IAppetizer
    {
        public void ShowDescription()
        {
            Console.WriteLine("Broth - with pumpkin.");
        }

        public bool IsBroth()
        {
            return true;
        }
    }
}
