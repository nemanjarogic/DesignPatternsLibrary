using System;

namespace OrderProcessing
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Logger: {message}");
        }
    }
}
