using DesignPatternsLibrary.PatternExecutors;
using StrategyLibrary.ShippingExample;
using StrategyLibrary.SortingExample;

namespace StrategyLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Strategy - Behavioral Pattern";

        public override void Execute()
        {
            ShippingExecutor.Execute();
            SortingExecutor.Execute();
        }
    }
}
