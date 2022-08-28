using BuildingBlocks;
using ChainOfResponsibilityLibrary.LoggingExample.Common;
using ChainOfResponsibilityLibrary.LoggingExample.Loggers;

namespace ChainOfResponsibilityLibrary.LoggingExample;

public static class LoggingExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Logging example");

        Logger loggerChain = InitializeLoggerChain();

        loggerChain.Log(LogLevel.Info, "This is information.");
        Console.WriteLine();

        loggerChain.Log(LogLevel.Debug, "This is debug level information.");
        Console.WriteLine();

        loggerChain.Log(LogLevel.Error, "This is error information.");
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
