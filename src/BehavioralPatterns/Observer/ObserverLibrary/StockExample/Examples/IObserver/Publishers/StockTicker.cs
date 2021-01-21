using System;
using System.Collections.Generic;
using ObserverLibrary.StockExample.Examples.IObserver.Subscribers;

namespace ObserverLibrary.StockExample.Examples.IObserver.Publishers
{
    public class StockTicker : IObservable<Stock>
    {
        private readonly List<IObserver<Stock>> _subscribers = new List<IObserver<Stock>>();
        private Stock _stock;

        public Stock Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                _stock = value;
                Notify(_stock);
            }
        }

        public IDisposable Subscribe(IObserver<Stock> subscriber)
        {
            if (!_subscribers.Contains(subscriber))
            {
                _subscribers.Add(subscriber);
            }

            return new DisposableSubscriber(_subscribers, subscriber);
        }

        private void Notify(Stock stock)
        {
            foreach (var subscriber in _subscribers)
            {
                if (stock.Symbol == null || stock.Price < 0)
                {
                    subscriber.OnError(new Exception("Bad stock data"));
                    continue;
                }

                subscriber.OnNext(stock);
            }
        }

        private void ReportDailyReport()
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.OnCompleted();
            }
        }
    }
}
