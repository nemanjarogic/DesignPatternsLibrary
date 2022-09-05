using StoreManagement.Contracts;

namespace StoreManagement.Events;

public class WarehouseReceivedNewSuppliesEvent : IEvent
{
    public WarehouseReceivedNewSuppliesEvent(string description)
    {
        Description = description;
    }

    public string Description { get; set; }
}