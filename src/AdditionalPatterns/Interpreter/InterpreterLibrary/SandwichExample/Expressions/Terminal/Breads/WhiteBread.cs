using InterpreterLibrary.SandwichExample.Expressions.Terminal.Breads.Common;

namespace InterpreterLibrary.SandwichExample.Expressions.Terminal.Breads
{
    public class WhiteBread : IBread
    {
        public void Interpret(Context context)
        {
            context.Output += " White-Bread ";
        }
    }
}
