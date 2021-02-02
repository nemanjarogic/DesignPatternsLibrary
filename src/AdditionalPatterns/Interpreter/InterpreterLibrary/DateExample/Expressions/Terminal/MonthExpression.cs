using InterpreterLibrary.DateExample.Expressions.Common;

namespace InterpreterLibrary.DateExample.Expressions.Terminal
{
    public class MonthExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("MM", context.Date.Month.ToString());
        }
    }
}
