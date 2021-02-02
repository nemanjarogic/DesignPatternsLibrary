using InterpreterLibrary.DateExample.Expressions.Common;

namespace InterpreterLibrary.DateExample.Expressions.Terminal
{
    public class DayExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("DD", context.Date.Day.ToString());
        }
    }
}
