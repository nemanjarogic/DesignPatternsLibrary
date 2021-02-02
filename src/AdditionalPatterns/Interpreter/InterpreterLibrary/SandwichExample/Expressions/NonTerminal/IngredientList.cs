using System.Collections.Generic;
using InterpreterLibrary.SandwichExample.Expressions.Common;
using InterpreterLibrary.SandwichExample.Expressions.Terminal.Ingredients.Common;

namespace InterpreterLibrary.SandwichExample.Expressions.NonTerminal
{
    public class IngredientList : IExpression
    {
        private readonly List<IIngredient> _ingredients;

        public IngredientList(List<IIngredient> ingredients)
        {
            _ingredients = ingredients;
        }

        public void Interpret(Context context)
        {
            foreach (var ingredient in _ingredients)
            {
                ingredient.Interpret(context);
            }
        }
    }
}
