using System;
using ChainOfResponsibilityLibrary.LoggingExample.Common;

namespace ChainOfResponsibilityLibrary.LoggingExample.Loggers
{
    public class ConsoleLogger : Logger
    {
        public ConsoleLogger()
            : base(LogLevel.Info)
        {
        }

        protected override void Write(string message)
        {
            Console.WriteLine($"Console:: {message}");
        }
    }
}
