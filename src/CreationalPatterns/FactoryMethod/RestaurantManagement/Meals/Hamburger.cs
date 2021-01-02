using RestaurantManagement.Meals.Common;
using System;

namespace RestaurantManagement.Meals
{
    /// <summary>
    /// Concrete products are different implementations of the product interface <see cref="IMeal"/>.
    /// </summary>
    public class Hamburger : IMeal
    {
        public void ShowDescription()
        {
            Console.WriteLine("Hamburger - with beef meat, Worcestershire sauce and cheese.");
        }
    }
}
