using System;

namespace ProxyLibrary.LoggingProxyExample
{
    /// <summary>
    /// The Proxy has an interface identical to the RealSubject.
    /// </summary>
    public class Proxy : ISubject
    {
        private readonly RealSubject _realSubject;

        public Proxy(RealSubject realSubject)
        {
            _realSubject = realSubject;
        }

        /// <summary>
        /// The most common applications of the Proxy pattern are
        /// lazy loading, caching, controlling the access, logging, etc.
        /// A Proxy can perform one of these things and then, depending on the result,
        /// pass the execution to the same method in a linked RealSubject object.
        /// </summary>
        public void Request()
        {
            //if (!CheckAccess())
            //{
            //    return;
            //}

            _realSubject.Request();
            LogAccess();
        }

        public bool CheckAccess()
        {
            // Some real checks should go here.
            Console.WriteLine("Proxy: Checking access prior to firing a real request.");

            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine($"Proxy: Request is issued at {DateTime.Now}");
        }
    }
}
