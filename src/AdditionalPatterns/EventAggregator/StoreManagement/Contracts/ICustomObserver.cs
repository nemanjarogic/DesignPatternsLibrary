using System;

namespace EventAggregatorLibrary.Contracts
{
    public interface ICustomObserver<T> : IObserver<IEvent>
        where T : IEvent
    {
        void Unsubscribe();
    }
}
