using BuildingBlocks;
using InterpreterLibrary.SandwichExample.Expressions.NonTerminal;
using InterpreterLibrary.SandwichExample.Expressions.Terminal.Breads;
using InterpreterLibrary.SandwichExample.Expressions.Terminal.Condiments;
using InterpreterLibrary.SandwichExample.Expressions.Terminal.Condiments.Common;
using InterpreterLibrary.SandwichExample.Expressions.Terminal.Ingredients;
using InterpreterLibrary.SandwichExample.Expressions.Terminal.Ingredients.Common;

namespace InterpreterLibrary.SandwichExample;

public static class SandwichExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Sandwich example");

        var topBread = new WheatBread();
        var topCondiments = new CondimentList(new List<ICondiment> { new MayoCondiment(), new MustardCondiment() });
        var ingredients = new IngredientList(new List<IIngredient> { new LettuceIngredient(), new ChickenIngredient() });
        var bottomCondiments = new CondimentList(new List<ICondiment> { new KetchupCondiment() });
        var bottomBread = new WheatBread();

        var sandwich = new Sandwich(
            topBread,
            topCondiments,
            ingredients,
            bottomCondiments,
            bottomBread);

        sandwich.Interpret(new Context());
    }
}
