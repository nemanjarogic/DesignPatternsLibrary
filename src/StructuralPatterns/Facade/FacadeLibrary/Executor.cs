using DesignPatternsLibrary.PatternExecutors;
using FacadeLibrary.MortgageExample;
using FacadeLibrary.WeatherServiceExample;

namespace FacadeLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Facade - Structural Pattern";

        public override void Execute()
        {
            MortgageExecutor.Execute();
            WeatherServiceExecutor.Execute();
        }
    }
}
