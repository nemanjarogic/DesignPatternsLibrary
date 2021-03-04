namespace ProxyLibrary.LoggingProxyExample
{
    /// <summary>
    /// The Subject interface declares common operations for both
    /// <see cref="RealSubject"/> and the <see cref="Proxy"/>.
    /// As long as the client works with <see cref="RealSubject"/> using this
    /// interface, you'll be able to pass it a proxy instead of a real subject.
    /// </summary>
    public interface ISubject
    {
        void Request();
    }
}
