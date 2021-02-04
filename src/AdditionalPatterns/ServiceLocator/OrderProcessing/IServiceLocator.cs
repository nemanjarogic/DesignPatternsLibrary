namespace OrderProcessing
{
    public interface IServiceLocator
    {
        void AddService<T>(T service);

        void AddService<T>(string serviceName, T service);

        T GetService<T>();

        object GetService<T>(string serviceName);
    }
}
