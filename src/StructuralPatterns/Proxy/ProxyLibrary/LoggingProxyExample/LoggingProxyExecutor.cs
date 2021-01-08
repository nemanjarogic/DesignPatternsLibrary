using System;
using BuildingBlocks;

namespace ProxyLibrary.LoggingProxyExample
{
    public static class LoggingProxyExecutor
    {
        public static void Execute()
        {
            ConsoleExtension.WriteSeparator("Logging proxy example");

            Client client = new Client();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new RealSubject();
            client.PerformOperation(realSubject);

            Console.WriteLine("\nClient: Executing the same client code with a proxy:");
            Proxy proxy = new Proxy(realSubject);
            client.PerformOperation(proxy);
        }
    }
}
