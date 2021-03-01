using DecoratorLibrary.DataStorageExample.Components.Common;

namespace DecoratorLibrary.DataStorageExample.Decorators.Common
{
    /// <summary>
    /// The base decorator class follows the same interface as the other components.
    /// The primary purpose of this class is to define the wrapping interface for all concrete decorators.
    /// The default implementation of the wrapping code might include a field for storing
    /// a wrapped component and the means to initialize it.
    /// </summary>
    public abstract class DataSourceDecorator : IDataSource
    {
        private readonly IDataSource _wrapee;

        public DataSourceDecorator(IDataSource dataSource)
        {
            _wrapee = dataSource;
        }

        public void ClearContent()
        {
            _wrapee.ClearContent();
        }

        public virtual string Read()
        {
            // Concrete decorators may call the parent implementation of the operation
            // instead of calling the wrapped object directly.
            // This approach simplifies extension of decorator classes.
            return _wrapee.Read();
        }

        public virtual void Write(string data)
        {
            // The base decorator simply delegates all work to the wrapped component.
            // Extra behaviors can be added in concrete decorators.
            _wrapee.Write(data);
        }
    }
}
