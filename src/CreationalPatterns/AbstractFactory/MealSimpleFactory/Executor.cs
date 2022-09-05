using BuildingBlocks;
using MealSimpleFactory.Factories;
using MealSimpleFactory.Meals;
using MealSimpleFactory.Meals.Common;

namespace MealSimpleFactory;

public class Executor : PatternExecutor
{
    public override string Name => "Simple Factory - Creational Pattern";

    public override void Execute()
    {
        var response = string.Empty;
        while (response is not "1" and not "2")
        {
            Console.WriteLine("Please choose the desired meal name (enter the number): ");
            Console.WriteLine("1. Green salad");
            Console.WriteLine("2. Hamburger");
            response = Console.ReadLine()!;
        }

        var mealName = response == "1" ? nameof(GreenSalad) : nameof(Hamburger);
        var factory = new MealFactory();

        IMeal meal = factory.CreateMeal(mealName);
        meal.ShowDescription();
        meal.ShowAmountOfCalories();
    }
}
