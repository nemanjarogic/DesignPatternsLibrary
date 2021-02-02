using InterpreterLibrary.SandwichExample.Expressions.Terminal.Ingredients.Common;

namespace InterpreterLibrary.SandwichExample.Expressions.Terminal.Ingredients
{
    public class TomatoIngredient : IIngredient
    {
        public void Interpret(Context context)
        {
            context.Output += " Tomato ";
        }
    }
}
