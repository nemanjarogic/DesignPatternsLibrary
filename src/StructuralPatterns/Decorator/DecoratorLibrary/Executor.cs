using DecoratorLibrary.DataStorageExample;
using DecoratorLibrary.PancakeExample;
using DesignPatternsLibrary.PatternExecutors;

namespace DecoratorLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Decorator - Structural Pattern";

        public override void Execute()
        {
            DataStorageExecutor.Execute();
            PancakeExecutor.Execute();
        }
    }
}
