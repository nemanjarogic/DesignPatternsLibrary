using System;
using System.Collections.Generic;

namespace EventAggregatorLibrary.Components
{
    /// <summary>
    /// Enables a subscriber to unsubscribe from further events.
    /// </summary>
    public class Unsubscriber<T> : IDisposable
    {
        private readonly List<IObserver<T>> _observers;
        private readonly IObserver<T> _observerToUnsubscribe;

        public Unsubscriber(List<IObserver<T>> observers, IObserver<T> observerToUnsubscribe)
        {
            _observers = observers;
            _observerToUnsubscribe = observerToUnsubscribe;
        }

        public void Dispose()
        {
            if (_observers.Contains(_observerToUnsubscribe))
            {
                _observers.Remove(_observerToUnsubscribe);
                Console.WriteLine($"Observer is unsubsribed.");
            }
        }
    }
}
