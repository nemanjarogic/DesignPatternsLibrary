using StoreManagement.Contracts;

namespace StoreManagement.Events;

public class OrderCreatedEvent : IEvent
{
    public OrderCreatedEvent(string description)
    {
        Description = description;
    }

    public string Description { get; set; }
}