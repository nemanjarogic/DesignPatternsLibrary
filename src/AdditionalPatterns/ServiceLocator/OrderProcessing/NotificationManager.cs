using System;

namespace OrderProcessing
{
    public class NotificationManager
    {
        public void NotifyCustomer(string message)
        {
            Console.WriteLine($"Notification manager: Sending '{message}' message to user.");
        }
    }
}
