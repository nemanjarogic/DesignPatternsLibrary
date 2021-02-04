using System.Collections.Generic;

namespace OrderProcessing
{
    /// <summary>
    /// The service locator plays the middleman and allow consumers
    /// to find and connect with various services.
    /// Possible improvements:
    /// 1) The service locator itself might be a singleton. There usually is no need to have two instances of a service locator.
    /// 2) Lazy initialization of services might be considered.
    ///    In the example above, the constructor creates new instances for all possible services.
    ///    Initialization might be deferred until some client actually requests a particular service.
    /// 3) The mapping between interfaces and implementation might be more flexible using metadata
    ///    (e.g.through application configuration files).
    /// </summary>
    public class ServiceLocator : IServiceLocator
    {
        private readonly Dictionary<string, object> _services;

        public ServiceLocator()
        {
            // Services can be pre-populated, but users could add them dynamically too.
            _services = new Dictionary<string, object>()
            {
                { typeof(PaymentProcessor).Name, new PaymentProcessor() },
                { typeof(NotificationManager).Name, new NotificationManager() },
            };
        }

        public void AddService<T>(T service)
        {
            _services.Add(typeof(T).Name, service);
        }

        public void AddService<T>(string serviceName, T service)
        {
            _services.Add(serviceName, service);
        }

        public T GetService<T>()
        {
            return (T)_services[typeof(T).Name];
        }

        public object GetService<T>(string serviceName)
        {
            return (T)_services[serviceName];
        }

        /*public void AddService(string serviceName)
        {
            // What if we have app.config with similar content?
            // <configuration>
            //      <appSettings>
            //          <add key="logger" value="OrderProcessing.NotificationManager"/>
            //      </appSettings>
            // </configuration>

            var configurationEntry = ConfigurationManager.AppSettings[serviceName];

            // Initialize notification manager through reflection
            var notificationManager = Assembly.GetExecutingAssembly().CreateInstance(configurationEntry);

            AddService(serviceName, notificationManager);
        }*/
    }
}
