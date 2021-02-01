using System;
using EventAggregatorLibrary.Contracts;

namespace EventAggregatorLibrary.Components.Subscribers
{
    /// <summary>
    /// Business tracking subscriber tracks all events in the system.
    /// </summary>
    public class BusinessTrackingSubscriber : ICustomObserver<IEvent>
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly IDisposable _unsubscriber;

        public BusinessTrackingSubscriber(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _unsubscriber = _eventAggregator.Subscribe(this);
        }

        public void OnNext(IEvent @event)
        {
            Console.WriteLine($"{GetType().Name}: processing event with description '{@event.Description}'.");
            Console.WriteLine($"{GetType().Name}: event record is available for various reports.");
        }

        public void OnCompleted()
        {
            Console.WriteLine($"{GetType().Name}: finished event processing.");
        }

        public void OnError(Exception error)
        {
            Console.WriteLine($"{GetType().Name}: experienced error condition.");
        }

        public void Unsubscribe()
        {
            // If subscribe method needs to be called multiple times unsubscribe
            // mechanism must be changed in order to support such functionality.
            _unsubscriber.Dispose();
        }
    }
}
