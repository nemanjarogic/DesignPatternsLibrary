using System.Collections.Generic;
using InterpreterLibrary.SandwichExample.Expressions.Terminal.Condiments.Common;

namespace InterpreterLibrary.SandwichExample.Expressions.NonTerminal
{
    public class CondimentList
    {
        private readonly List<ICondiment> _condiments;

        public CondimentList(List<ICondiment> condiments)
        {
            _condiments = condiments;
        }

        public void Interpret(Context context)
        {
            foreach (var condiment in _condiments)
            {
                condiment.Interpret(context);
            }
        }
    }
}
