using DesignPatternsLibrary.PatternExecutors;
using SingletonLibrary.Implementations;
using System;

namespace SingletonLibrary
{
    public class SingletonGreeterExecutor : PatternExecutor
    {
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
            SingletonGreeter.Instance.Greet();
        }
    }
}
