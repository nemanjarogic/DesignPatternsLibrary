using InterpreterLibrary.SandwichExample.Expressions.Terminal.Condiments.Common;

namespace InterpreterLibrary.SandwichExample.Expressions.NonTerminal;

public class CondimentList
{
    private readonly IEnumerable<ICondiment> _condiments;

    public CondimentList(IEnumerable<ICondiment> condiments)
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
