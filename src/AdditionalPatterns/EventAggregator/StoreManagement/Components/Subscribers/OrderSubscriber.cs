using System;
using EventAggregatorLibrary.Contracts;
using EventAggregatorLibrary.Events;

namespace EventAggregatorLibrary.Components.Subscribers
{
    /// <summary>
    /// Order subscriber tracks only order created event.
    /// </summary>
    public class OrderSubscriber : ICustomObserver<OrderCreatedEvent>
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly IDisposable _unsubscriber;

        public OrderSubscriber(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _unsubscriber = _eventAggregator.Subscribe(this);
        }

        public void OnNext(IEvent @event)
        {
            Console.WriteLine($"{GetType().Name}: processing event with description '{@event.Description}'.");
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
            _unsubscriber.Dispose();
        }
    }
}
