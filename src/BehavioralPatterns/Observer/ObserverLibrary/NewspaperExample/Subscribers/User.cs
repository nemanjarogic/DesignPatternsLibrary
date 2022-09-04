using ObserverLibrary.NewspaperExample.Publishers.Common;
using ObserverLibrary.NewspaperExample.Subscribers.Common;

namespace ObserverLibrary.NewspaperExample.Subscribers;

public class User : IUser
{
    private readonly decimal _availableMonthlySubscriptionAmount;

    public User(string name, string username, decimal availableMonthlySubscriptionAmount)
    {
        Name = name;
        Username = username;
        _availableMonthlySubscriptionAmount = availableMonthlySubscriptionAmount;
    }

    public string Username { get; set; }
    public string Name { get; set; }

    public void ReportSubscriptionPriceChange(Newspaper newspaper)
    {
        if (newspaper.MonthlyPrice > _availableMonthlySubscriptionAmount)
        {
            newspaper.Unsubscribe(this);
        }
    }
}
