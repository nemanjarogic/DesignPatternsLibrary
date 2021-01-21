using ObserverLibrary.NewspaperExample.Publishers.Common;

namespace ObserverLibrary.NewspaperExample.Subscribers.Common
{
    public interface IUser
    {
        public string Name { get; set; }

        void ReportSubscriptionPriceChange(Newspaper newspaper);
    }
}
