using Greeter.Types.Common;
using System.Diagnostics.CodeAnalysis;

namespace Greeter.Types;

/// <summary>
/// This implementation attempts to be thread-safe without the necessity of taking out a lock every time.
/// However, it's easy to get wrong. The pattern needs to be pretty much exactly as shown.
/// Any significant changes are likely to impact either performance or correctness.
/// It doesn't perform as well as the <see cref="LocklessGreeter"/> or <see cref="LocklessFullyLazyGreeter"/>.
/// </summary>
public class DoubleCheckGreeter : BaseGreeter
{
    private static readonly object Padlock = new();
    private static DoubleCheckGreeter? _instance;

    private DoubleCheckGreeter()
    {
    }


    /// <summary>
    /// Gets instance in a way to support multi-threaded applications through 'double checked locking'
    /// pattern which (once the instance exists) avoids locking each time the method is invoked.
    /// </summary>
    [SuppressMessage("Maintainability", "CA1508:Avoid dead conditional code",
        Justification = "If the first check determines that instance is null, that might not be the case for the second check in multi-threaded scenarios.")]
    public static DoubleCheckGreeter Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (Padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new DoubleCheckGreeter();
                    }
                }
            }

            return _instance;
        }
    }
}
