using DesignPatternsLibrary.PatternExecutors;
using InterpreterLibrary.DateExample;
using InterpreterLibrary.SandwichExample;

namespace InterpreterLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Interpreter - Interpreter Library - Additional Pattern";

        public override void Execute()
        {
            DateExecutor.Execute();
            SandwichExecutor.Execute();
        }
    }
}
