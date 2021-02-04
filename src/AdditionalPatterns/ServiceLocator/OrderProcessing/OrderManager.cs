namespace OrderProcessing
{
    public class OrderManager
    {
        private readonly IServiceLocator _serviceLocator;
        private readonly Logger _logger;

        public OrderManager(IServiceLocator serviceLocator)
        {
            _serviceLocator = serviceLocator;
            _logger = _serviceLocator.GetService<Logger>();
        }

        public void ProcessOrder(Order order)
        {
            _logger.Log("Processing new order...");

            decimal totalPrice = order.UnitPrice * order.Quantity;

            var paymentProcessor = _serviceLocator.GetService<PaymentProcessor>();
            bool isPaymentSuccessful = paymentProcessor.ProcessPayment(totalPrice);

            NotifyCustomer(isPaymentSuccessful);
        }

        private void NotifyCustomer(bool isPaymentSuccessful)
        {
            var notifier = _serviceLocator.GetService<NotificationManager>();
            if (isPaymentSuccessful)
            {
                notifier.NotifyCustomer("Payment succeeded");
                return;
            }

            notifier.NotifyCustomer("Payment failed");
            _logger.Log("Payment failed");
        }
    }
}
