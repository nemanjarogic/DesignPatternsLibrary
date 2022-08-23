namespace DecoratorLibrary.DataStorageExample.Components.Common;

/// <summary>
/// The component interface defines operations that can be altered by decorators.
/// </summary>
public interface IDataSource
{
    void Write(string data);
    string Read();
    void ClearContent();
}
