namespace StoreManagement.Components;

/// <summary>
/// Enables a subscriber to unsubscribe from further events.
/// </summary>
public class Unsubscriber<T> : IDisposable
{
    private readonly List<IObserver<T>> _observers;
    private readonly IObserver<T> _observerToUnsubscribe;
    private bool _isDisposed;

    public Unsubscriber(List<IObserver<T>> observers, IObserver<T> observerToUnsubscribe)
    {
        _observers = observers;
        _observerToUnsubscribe = observerToUnsubscribe;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    // The bulk of the clean-up code is implemented in Dispose(bool)
    protected virtual void Dispose(bool disposing)
    {
        if (_isDisposed)
        {
            return;
        }

        if (disposing)
        {
            if (_observers.Contains(_observerToUnsubscribe))
            {
                _observers.Remove(_observerToUnsubscribe);
                Console.WriteLine($"Observer is unsubsribed.");
            }
        }

        _isDisposed = true;
    }
}
