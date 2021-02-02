using InterpreterLibrary.SandwichExample.Expressions.Terminal.Breads.Common;

namespace InterpreterLibrary.SandwichExample.Expressions.Terminal.Breads
{
    public class WheatBread : IBread
    {
        public void Interpret(Context context)
        {
            context.Output += " Wheat-Bread ";
        }
    }
}
