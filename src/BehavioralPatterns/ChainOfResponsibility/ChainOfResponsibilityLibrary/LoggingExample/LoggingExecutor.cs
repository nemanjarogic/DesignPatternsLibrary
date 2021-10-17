using System;
using BuildingBlocks;
using ChainOfResponsibilityLibrary.LoggingExample.Common;
using ChainOfResponsibilityLibrary.LoggingExample.Loggers;

namespace ChainOfResponsibilityLibrary.LoggingExample
{
    public static class LoggingExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Logging example");

            Logger loggerChain = InitializeLoggerChain();

            var infoMessage = "This is information.";
            var debugMessage = "This is debug level information.";
            var errorMessage = "This is error information.";

            loggerChain.Log(LogLevel.Info, infoMessage);
            Console.WriteLine();

            loggerChain.Log(LogLevel.Debug, debugMessage);
            Console.WriteLine();

            loggerChain.Log(LogLevel.Error, errorMessage);
            Console.WriteLine();
        }

        private static Logger InitializeLoggerChain()
        {
            Logger consoleLogger = new ConsoleLogger();
            Logger fileLogger = new FileLogger();
            Logger priorityLogger = new PriorityLogger();

            consoleLogger
                .RegisterNext(fileLogger)
                .RegisterNext(priorityLogger);

            return consoleLogger;
        }
    }
}
