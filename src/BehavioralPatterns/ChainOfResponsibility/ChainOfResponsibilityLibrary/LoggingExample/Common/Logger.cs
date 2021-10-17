namespace ChainOfResponsibilityLibrary.LoggingExample.Common
{
    public abstract class Logger
    {
        protected readonly LogLevel _loggerLevel;
        protected Logger _next;

        public Logger(LogLevel loggerLevel)
        {
            _loggerLevel = loggerLevel;
        }

        public Logger RegisterNext(Logger next)
        {
            _next = next;
            return _next;
        }

        public void Log(LogLevel level, string message)
        {
            if (_loggerLevel <= level)
            {
                Write(message);
            }

            _next?.Log(level, message);
        }

        protected abstract void Write(string message);
    }
}
