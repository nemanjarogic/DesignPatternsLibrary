using InterpreterLibrary.SandwichExample.Expressions.Terminal.Condiments.Common;

namespace InterpreterLibrary.SandwichExample.Expressions.Terminal.Condiments
{
    public class KetchupCondiment : ICondiment
    {
        public void Interpret(Context context)
        {
            context.Output += " Ketchup ";
        }
    }
}
