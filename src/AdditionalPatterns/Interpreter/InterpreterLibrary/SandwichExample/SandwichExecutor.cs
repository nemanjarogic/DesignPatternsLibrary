using System.Collections.Generic;
using BuildingBlocks;
using InterpreterLibrary.SandwichExample.Expressions.NonTerminal;
using InterpreterLibrary.SandwichExample.Expressions.Terminal.Breads;
using InterpreterLibrary.SandwichExample.Expressions.Terminal.Condiments;
using InterpreterLibrary.SandwichExample.Expressions.Terminal.Condiments.Common;
using InterpreterLibrary.SandwichExample.Expressions.Terminal.Ingredients;
using InterpreterLibrary.SandwichExample.Expressions.Terminal.Ingredients.Common;

namespace InterpreterLibrary.SandwichExample
{
    public static class SandwichExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Sandwich example");

            var sandwhich = new Sandwich(
                new WheatBread(),
                new CondimentList(new List<ICondiment> { new MayoCondiment(), new MustardCondiment() }),
                new IngredientList(new List<IIngredient> { new LettuceIngredient(), new ChickenIngredient() }),
                new CondimentList(new List<ICondiment> { new KetchupCondiment() }),
                new WheatBread());

            sandwhich.Interpret(new Context());
        }
    }
}
