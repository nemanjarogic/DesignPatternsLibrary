using ObserverLibrary.StockExample.Examples.EventAndDelegate;
using ObserverLibrary.StockExample.Examples.IObserver;
using ObserverLibrary.StockExample.Examples.Motivating;
using ObserverLibrary.StockExample.Examples.Traditional;

namespace ObserverLibrary.StockExample
{
    public static class StockExecutor
    {
        public static void Execute()
        {
            MotivatingExecutor.Execute();
            TraditionalExecutor.Execute();
            EventAndDelegateExecutor.Execute();
            ObserverExecutor.Execute();
        }
    }
}
