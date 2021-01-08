using System;
using ChainOfResponsibilityLibrary.LoggingExample.Common;

namespace ChainOfResponsibilityLibrary.LoggingExample.Loggers
{
    public class PriorityLogger : Logger
    {
        public PriorityLogger()
            : base(LogLevel.Error)
        {
        }

        protected override void Write(string message)
        {
            Console.WriteLine($"Priority monitoring logger:: {message}");
        }
    }
}
