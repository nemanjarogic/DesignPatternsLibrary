using DesignPatternsLibrary.PatternExecutors;
using ObserverLibrary.NewspaperExample;
using ObserverLibrary.StockExample;

namespace ObserverLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Observer - Behavioral Pattern";

        public override void Execute()
        {
            NewspaperExecutor.Execute();
            StockExecutor.Execute();
        }
    }
}
