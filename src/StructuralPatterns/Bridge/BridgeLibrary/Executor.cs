using BridgeLibrary.DevicesAndRemotesExample;
using BridgeLibrary.ManuscriptsAndFormattersExample;
using DesignPatternsLibrary.PatternExecutors;

namespace BridgeLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Bridge - Bridge Library - Structural Pattern";

        public override void Execute()
        {
            DevicesAndRemotesExecutor.Execute();
            ManuscriptsAndFormattersExecutor.Execute();
        }
    }
}
