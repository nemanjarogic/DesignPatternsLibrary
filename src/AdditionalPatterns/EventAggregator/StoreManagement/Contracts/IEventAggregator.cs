using System;

namespace EventAggregatorLibrary.Contracts
{
    public interface IEventAggregator : IObservable<IEvent>
    {
        void Publish(IEvent message);

        IDisposable Subscribe(ICustomObserver<IEvent> observer);

        IDisposable Subscribe<T>(ICustomObserver<T> observer)
            where T : IEvent;
    }
}
