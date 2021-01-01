using DesignPatternsLibrary.PatternExecutors;
using Greeter.Implementations;
using System;

namespace Greeter
{
    public class Executor : PatternExecutor
    {
        public Executor()
            : base("Singleton Pattern - Greeter")
        {
        }

        public override void Execute()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("Initial greetings...");
            Console.WriteLine();

            Greet();

            Console.WriteLine("--------------------------");
            Console.WriteLine("Goodbye greetings...");
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
