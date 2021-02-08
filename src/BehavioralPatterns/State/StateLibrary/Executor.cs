using DesignPatternsLibrary.PatternExecutors;
using ObserverLibrary.StockExample;
using StateLibrary.PackageExample;
using StateLibrary.SteakCookingExample;

namespace StateLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "State - Behavioral Pattern";

        public override void Execute()
        {
            ConceptualExecutor.Execute();
            PackageExecutor.Execute();
            SteakCookingExecutor.Execute();
        }
    }
}
