using System.Collections.Generic;
using ObserverLibrary.StockExample.Examples.Traditional.Subscribers.Common;

namespace ObserverLibrary.StockExample.Examples.Traditional.Publishers.Common
{
    public abstract class Publisher
    {
        private readonly List<Subscriber> _subscribers = new List<Subscriber>();

        public void Subscribe(Subscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(Subscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void Notify()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update();
            }
        }
    }
}
