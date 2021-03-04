using DesignPatternsLibrary.PatternExecutors;
using VisitorLibrary.CompanyExample;
using VisitorLibrary.PersonDynamicProgrammingExample;
using VisitorLibrary.PersonExample;

namespace VisitorLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Visitor - Behavioral Pattern";

        public override void Execute()
        {
            CompanyExecutor.Execute();
            PersonDynamicProgrammingExecutor.Execute();
            PersonExecutor.Execute();
        }
    }
}
