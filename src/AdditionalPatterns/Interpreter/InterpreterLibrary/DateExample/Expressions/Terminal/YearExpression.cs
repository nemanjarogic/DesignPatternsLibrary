using InterpreterLibrary.DateExample.Expressions.Common;

namespace InterpreterLibrary.DateExample.Expressions.Terminal
{
    public class YearExpression : IExpression
    {
        public void Evaluate(Context context)
        {
            string expression = context.Expression;
            context.Expression = expression.Replace("YYYY", context.Date.Year.ToString());
        }
    }
}
