using DesignPatternsLibrary.PatternExecutors;
using UnitOfWorkLibrary.Example1;
using UnitOfWorkLibrary.Example2;

namespace UnitOfWorkLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Unit of Work - Data Access Pattern";

        public override void Execute()
        {
            Example1Executor.Execute();
            Example2Executor.ExecuteAsync().Wait();
        }
    }
}
