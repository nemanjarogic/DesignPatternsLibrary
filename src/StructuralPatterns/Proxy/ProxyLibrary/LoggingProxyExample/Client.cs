namespace ProxyLibrary.LoggingProxyExample
{
    /// <summary>
    /// The client code is supposed to work with all objects (both subjects and proxies)
    /// via the Subject interface in order to support both real subjects and proxies.
    /// In real life, however, clients mostly work with their real subjects directly.
    /// In this case, to implement the pattern more easily, you can extend your proxy from the real subject's class.
    /// </summary>
    public class Client
    {
        public void PerformOperation(ISubject subject)
        {
            subject.Request();
        }
    }
}
