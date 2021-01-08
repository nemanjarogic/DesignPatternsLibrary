using System;
using ChainOfResponsibilityLibrary.LoggingExample.Common;

namespace ChainOfResponsibilityLibrary.LoggingExample.Loggers
{
    public class FileLogger : Logger
    {
        public FileLogger()
            : base(LogLevel.Debug)
        {
        }

        protected override void Write(string message)
        {
            Console.WriteLine($"File:: {message}");
        }
    }
}
