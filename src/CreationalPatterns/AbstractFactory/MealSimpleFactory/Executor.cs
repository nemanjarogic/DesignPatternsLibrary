using System;
using DesignPatternsLibrary.PatternExecutors;
using MealSimpleFactory.Factories;
using MealSimpleFactory.Meals.Common;

namespace MealSimpleFactory
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Simple Factory Pattern - Meal Simple Factory";

        public override void Execute()
        {
            Console.WriteLine("Please enter desired meal name name (green salad/hamburger): ");
            string mealName = Console.ReadLine();

            MealFactory factory = new MealFactory();
            IMeal meal = factory.CreateMeal(mealName);

            meal.ShowDescription();
            meal.ShowAmountOfCalories();
        }
    }
}
