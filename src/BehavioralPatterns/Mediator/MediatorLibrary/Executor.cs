using DesignPatternsLibrary.PatternExecutors;
using MediatorLibrary.AirTrafficControlExample;
using MediatorLibrary.GroupChatExample;

namespace MediatorLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Mediator - Behavioral Pattern";

        public override void Execute()
        {
            AirTrafficControlExecutor.Execute();
            GroupChatExecutor.Execute();
        }
    }
}
