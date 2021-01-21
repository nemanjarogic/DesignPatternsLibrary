using ObserverLibrary.NewspaperExample.Publishers.Common;
using ObserverLibrary.NewspaperExample.Subscribers.Common;

namespace ObserverLibrary.NewspaperExample.Subscribers
{
    public class User : IUser
    {
        private readonly decimal _availableMonthlySubscriptionAmount;

        public User(string name, decimal availableMonthlySubscriptionAmount)
        {
            Name = name;
            _availableMonthlySubscriptionAmount = availableMonthlySubscriptionAmount;
        }

        public string Name { get; set; }

        public void ReportSubscriptionPriceChange(Newspaper newspaper)
        {
            if (newspaper.MonthlyPrice > _availableMonthlySubscriptionAmount)
            {
                newspaper.Unsubscribe(this);
            }
        }
    }
}
