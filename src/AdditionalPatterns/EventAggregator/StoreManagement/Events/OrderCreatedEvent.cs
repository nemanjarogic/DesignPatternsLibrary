using EventAggregatorLibrary.Contracts;

namespace EventAggregatorLibrary.Events
{
    public class OrderCreatedEvent : IEvent
    {
        public OrderCreatedEvent(string description)
        {
            Description = description;
        }

        public string Description { get; set; }
    }
}
