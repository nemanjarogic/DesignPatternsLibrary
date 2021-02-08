using DesignPatternsLibrary.PatternExecutors;
using LazyLoadLibrary.GhostsExample;
using LazyLoadLibrary.LazyInitializationExample;
using LazyLoadLibrary.ValueHolderExample;
using LazyLoadLibrary.VirtualProxyExample;

namespace LazyLoadLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Lazy Load - Data Access Pattern";

        public override void Execute()
        {
            GhostsExecutor.Execute();
            LazyInitializationExecutor.Execute();
            ValueHolderExecutor.Execute();
            VirtualProxyExecutor.Execute();
        }
    }
}
