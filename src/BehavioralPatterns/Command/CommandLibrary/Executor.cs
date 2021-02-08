using CommandLibrary.EmailExample;
using CommandLibrary.ShoppingCartExample;
using CommandLibrary.StockExample;
using DesignPatternsLibrary.PatternExecutors;

namespace CommandLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Command - Behavioral Pattern";

        public override void Execute()
        {
            EmailExecutor.Execute();
            ShoppingCartExecutor.Execute();
            StockExecutor.Execute();
        }
    }
}
