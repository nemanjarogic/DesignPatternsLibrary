using System;
using DesignPatternsLibrary.PatternExecutors;
using Greeter.Types;

namespace Greeter
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Singleton - Creational Pattern";

        public override void Execute()
        {
            Console.WriteLine("Initial greetings...");
            Console.WriteLine();
            Greet();

            Console.WriteLine("\nGoodbye greetings...");
            Console.WriteLine();
            Greet();
        }

        private void Greet()
        {
            SimpleGreeter.Instance.Greet();
            SimpleThreadSafetyGreeter.Instance.Greet();
            DoubleCheckGreeter.Instance.Greet();
            LocklessGreeter.Instance.Greet();
            LocklessFullyLazyGreeter.Instance.Greet();
            DotNetLazyGreeter.Instance.Greet();
        }
    }
}
