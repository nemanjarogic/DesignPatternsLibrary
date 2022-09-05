using StoreManagement.Contracts;

namespace StoreManagement.Components;

public class EventAggregator : IEventAggregator
{
    private readonly List<IEvent> _events;
    private readonly List<IObserver<IEvent>> _observers;
    private readonly Dictionary<Type, List<IObserver<IEvent>>> _typedObservers;

    public EventAggregator()
    {
        _events = new List<IEvent>();
        _observers = new List<IObserver<IEvent>>();
        _typedObservers = new Dictionary<Type, List<IObserver<IEvent>>>();
    }

    /// <summary>
    /// Publish an event to subscribers.
    /// </summary>
    /// <param name="event">The event to publish.</param>
    public void Publish(IEvent @event)
    {
        _events.Add(@event);

        foreach (var observer in _observers)
        {
            // Provide the observer with new data.
            observer.OnNext(@event);
        }

        if (!_typedObservers.TryGetValue(@event.GetType(), out var typedObservers))
        {
            return;
        }

        foreach (var observer in typedObservers)
        {
            // Provide the typed observer with new data.
            observer.OnNext(@event);
        }
    }

    /// <summary>
    /// Subscribe to all events.
    /// </summary>
    /// <param name="observer">The subscriber.</param>
    /// <returns>An unsubscriber to allow unsubscribing from events.</returns>
    public IDisposable Subscribe(IObserver<IEvent> observer) =>
        SubscribeToAllEvents(observer);

    /// <summary>
    /// Subscribe to all events.
    /// </summary>
    /// <param name="observer">The subscriber.</param>
    /// <returns>An unsubscriber to allow unsubscribing from events.</returns>
    public IDisposable Subscribe(ICustomObserver<IEvent> observer) =>
        SubscribeToAllEvents(observer);

    /// <summary>
    /// Subscribe to a specific event type.
    /// </summary>
    /// <typeparam name="T">The event type to subscribe to.</typeparam>
    /// <param name="newObserver">The subscriber.</param>
    /// <returns>An unsubscriber to allow unsubscribing from events.</returns>
    public IDisposable Subscribe<T>(ICustomObserver<T> newObserver)
        where T : IEvent
    {
        if (!_typedObservers.TryGetValue(typeof(T), out List<IObserver<IEvent>> observers))
        {
            observers = new List<IObserver<IEvent>>();
            _typedObservers[typeof(T)] = observers;
        }

        return SubscribeAndSendEvents(observers, newObserver, _events.Where(evt => evt is T));
    }

    private IDisposable SubscribeToAllEvents(IObserver<IEvent> newObserver) =>
        SubscribeAndSendEvents(_observers, newObserver, _events);

    private IDisposable SubscribeAndSendEvents(
        List<IObserver<IEvent>> currentObservers,
        IObserver<IEvent> newObserver,
        IEnumerable<IEvent> events)
    {
        if (!currentObservers.Contains(newObserver))
        {
            currentObservers.Add(newObserver);

            // Provide observer with existing data.
            foreach (var @event in events)
            {
                newObserver.OnNext(@event);
            }
        }

        return new Unsubscriber<IEvent>(currentObservers, newObserver);
    }
}
