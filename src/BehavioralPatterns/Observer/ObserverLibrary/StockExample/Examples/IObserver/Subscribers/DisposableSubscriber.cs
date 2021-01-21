using System;
using System.Collections.Generic;

namespace ObserverLibrary.StockExample.Examples.IObserver.Subscribers
{
    public class DisposableSubscriber : IDisposable
    {
        private readonly List<IObserver<Stock>> _subscribers;
        private readonly IObserver<Stock> _currentSubscriber;

        public DisposableSubscriber(List<IObserver<Stock>> subscribers, IObserver<Stock> currentSubscriber)
        {
            _subscribers = subscribers;
            _currentSubscriber = currentSubscriber;
        }

        public void Dispose()
        {
            if (_currentSubscriber != null && _subscribers.Contains(_currentSubscriber))
            {
                _subscribers.Remove(_currentSubscriber);
            }
        }
    }
}
