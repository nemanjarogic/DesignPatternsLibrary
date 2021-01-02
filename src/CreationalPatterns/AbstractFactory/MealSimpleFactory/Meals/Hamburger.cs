using System;
using MealSimpleFactory.Meals.Common;

namespace MealSimpleFactory.Meals
{
    public class Hamburger : IMeal
    {
        public void ShowAmountOfCalories()
        {
            Console.WriteLine("Calories: 450 kcal");
        }

        public void ShowDescription()
        {
            Console.WriteLine("Hamburger: beef meat, Worcestershire sauce and cheese.");
        }
    }
}
