using DesignPatternsLibrary.PatternExecutors;
using InterpreterLibrary.DateExample;
using InterpreterLibrary.SandwichExample;

namespace InterpreterLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Interpreter - Behavioral Pattern";

        public override void Execute()
        {
            DateExecutor.Execute();
            SandwichExecutor.Execute();
        }
    }
}
