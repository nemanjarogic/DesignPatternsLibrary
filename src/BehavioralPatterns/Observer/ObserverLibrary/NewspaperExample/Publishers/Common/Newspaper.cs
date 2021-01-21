using System;
using System.Collections.Generic;
using System.Linq;
using ObserverLibrary.NewspaperExample.Subscribers.Common;

namespace ObserverLibrary.NewspaperExample.Publishers.Common
{
    public abstract class Newspaper
    {
        private readonly List<IUser> _subscribers;

        private readonly string _name;
        private decimal _monthlyPrice;

        public Newspaper(string name, decimal monthlyPrice)
        {
            _subscribers = new List<IUser>();

            _name = name;
            _monthlyPrice = monthlyPrice;
        }

        public decimal MonthlyPrice
        {
            get
            {
                return _monthlyPrice;
            }
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
            _subscribers.Add(user);
            Console.WriteLine($"{user.Name} is subscribed to {_name} newspaper.");
        }

        public void Unsubscribe(IUser user)
        {
            _subscribers.Remove(user);
            Console.WriteLine($"{user.Name} is unsubscribed from {_name} newspaper.");
        }

        private void Notify()
        {
            foreach (IUser user in _subscribers.ToList())
            {
                user.ReportSubscriptionPriceChange(this);
            }
        }
    }
}
