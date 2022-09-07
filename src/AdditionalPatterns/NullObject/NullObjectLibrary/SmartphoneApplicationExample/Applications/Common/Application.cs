namespace NullObjectLibrary.SmartphoneApplicationExample.Applications.Common;

public abstract class Application
{
    protected Application(Guid processId)
    {
        ProcessId = processId;
    }

    public static NullApplication Default { get; } = new();

    public abstract string Name { get; }
    public Guid ProcessId { get; }

    public virtual void Open() =>
        Console.WriteLine($"{Name} opened.");

    public virtual void Close() =>
        Console.WriteLine($"{Name} closed.");
}
