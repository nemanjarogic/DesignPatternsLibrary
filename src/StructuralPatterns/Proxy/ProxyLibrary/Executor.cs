using DesignPatternsLibrary.PatternExecutors;
using ProxyLibrary.CachingProxyExample;
using ProxyLibrary.LoggingProxyExample;
using ProxyLibrary.ProtectionProxyExample;

namespace ProxyLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Proxy - Structural Pattern";

        public override void Execute()
        {
            CachingProxyExecutor.Execute();
            LoggingProxyExecutor.Execute();
            ProtectionProxyExecutor.Execute();
        }
    }
}
