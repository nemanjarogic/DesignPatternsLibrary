using DesignPatternsLibrary.PatternExecutors;
using RulesLibrary.MotivatingExample;
using RulesLibrary.RulesExample;

namespace RulesLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Rules - Behavioral Pattern";

        public override void Execute()
        {
            MotivatingExecutor.Execute();
            RulesExecutor.Execute();
        }
    }
}
