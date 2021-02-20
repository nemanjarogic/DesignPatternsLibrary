using System;
using DesignPatternsLibrary.PatternExecutors;
using MealSimpleFactory.Factories;
using MealSimpleFactory.Meals.Common;

namespace MealSimpleFactory
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Simple Factory - Creational Pattern";

        public override void Execute()
        {
            Console.WriteLine("Please enter desired meal name (green salad/hamburger): ");
            string mealName = Console.ReadLine();

            MealFactory factory = new MealFactory();
            IMeal meal = factory.CreateMeal(mealName);

            meal.ShowDescription();
            meal.ShowAmountOfCalories();
        }
    }
}
