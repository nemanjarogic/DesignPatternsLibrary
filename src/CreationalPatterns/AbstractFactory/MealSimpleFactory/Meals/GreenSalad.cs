using System;
using MealSimpleFactory.Meals.Common;

namespace MealSimpleFactory.Meals
{
    public class GreenSalad : IMeal
    {
        public void ShowAmountOfCalories()
        {
            Console.WriteLine("Calories: 250 kcal");
        }

        public void ShowDescription()
        {
            Console.WriteLine("Green salad: lettuce, cucumber and green olives");
        }
    }
}
