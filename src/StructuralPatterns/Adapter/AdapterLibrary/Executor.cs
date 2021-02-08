using AdapterLibrary.BillingSystemExample;
using AdapterLibrary.MovieBroadcasterExample;
using DesignPatternsLibrary.PatternExecutors;

namespace AdapterLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Adapter - Structural Pattern";

        public override void Execute()
        {
            BillingSystemExecutor.Execute();
            MovieBroadcasterExecutor.Execute();
        }
    }
}
