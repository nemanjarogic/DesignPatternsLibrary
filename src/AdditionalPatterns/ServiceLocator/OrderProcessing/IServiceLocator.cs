namespace OrderProcessing;

public interface IServiceLocator
{
    void AddService<T>(T service) where T : notnull;
    void AddService<T>(string serviceName, T service) where T : notnull;
    T GetService<T>() where T : notnull;
    object GetService<T>(string serviceName) where T : notnull;
}
