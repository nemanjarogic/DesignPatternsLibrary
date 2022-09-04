using ObserverLibrary.NewspaperExample.Subscribers.Common;

namespace ObserverLibrary.NewspaperExample.Publishers.Common;

public abstract class Newspaper
{
    private readonly Dictionary<string, IUser> _subscribers = new();
    private readonly string _name;

    private decimal _monthlyPrice;

    protected Newspaper(string name, decimal monthlyPrice)
    {
        _name = name;
        _monthlyPrice = monthlyPrice;
    }

    public decimal MonthlyPrice
    {
        get => _monthlyPrice;
        set
        {
            if (_monthlyPrice != value)
            {
                _monthlyPrice = value;
                Console.WriteLine($"Monthly price for {_name} newspaper is changed to {_monthlyPrice:C}.");

                Notify();
            }
        }
    }

    public void Subscribe(IUser user)
    {
        _subscribers.Add(user.Username, user);
        Console.WriteLine($"{user.Name} is subscribed to {_name} newspaper.");
    }

    public void Unsubscribe(IUser user)
    {
        _subscribers.Remove(user.Username);
        Console.WriteLine($"{user.Name} is unsubscribed from {_name} newspaper.");
    }

    private void Notify()
    {
        foreach (var user in _subscribers.Values.ToList())
        {
            user.ReportSubscriptionPriceChange(this);
        }
    }
}
