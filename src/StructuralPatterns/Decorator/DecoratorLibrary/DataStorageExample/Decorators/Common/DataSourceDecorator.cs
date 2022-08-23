using DecoratorLibrary.DataStorageExample.Components.Common;

namespace DecoratorLibrary.DataStorageExample.Decorators.Common;

/// <summary>
/// The base decorator class follows the same interface as the other components.
/// The primary purpose of this class is to define the wrapping interface for all concrete decorators.
/// The default implementation of the wrapping code might include a field for storing
/// a wrapped component and the means to initialize it.
/// </summary>
public abstract class DataSourceDecorator : IDataSource
{
    protected readonly IDataSource _wrapee;

    protected DataSourceDecorator(IDataSource dataSource)
    {
        _wrapee = dataSource;
    }

    // The base decorator simply delegates all work to the wrapped component.
    // Extra behaviors can be added in concrete decorators.
    public virtual void Write(string data) =>
        _wrapee.Write(data);

    // With this approach, concrete decorators can call the parent implementation of the operation
    // instead of calling the wrapped object directly.
    // That simplifies extension of decorator classes.
    public virtual string Read() =>
        _wrapee.Read();

    public void ClearContent() => _wrapee.ClearContent();
}
