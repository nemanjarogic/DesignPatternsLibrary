using ObserverLibrary.StockExample.Examples.IObserver.Subscribers;

namespace ObserverLibrary.StockExample.Examples.IObserver.Publishers;

public class StockTicker : IObservable<Stock>
{
    private readonly List<IObserver<Stock>> _subscribers = new();
    private Stock _lastChangedStock = Stock.Default();

    public void ProcessNewStockChange(Stock stock)
    {
        _lastChangedStock = stock;
        Notify(_lastChangedStock);

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
        var isReportWithBadData = string.IsNullOrWhiteSpace(stock.Symbol) || stock.Price < 0;

        foreach (var subscriber in _subscribers)
        {
            if (isReportWithBadData)
            {
                subscriber.OnError(new ArgumentException("Bad stock data"));
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
