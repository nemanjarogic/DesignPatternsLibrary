using InterpreterLibrary.SandwichExample.Expressions.Common;
using InterpreterLibrary.SandwichExample.Expressions.Terminal.Ingredients.Common;

namespace InterpreterLibrary.SandwichExample.Expressions.NonTerminal;

public class IngredientList : IExpression
{
    private readonly IEnumerable<IIngredient> _ingredients;

    public IngredientList(IEnumerable<IIngredient> ingredients)
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
