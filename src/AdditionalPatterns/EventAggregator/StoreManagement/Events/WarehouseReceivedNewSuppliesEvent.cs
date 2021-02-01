using EventAggregatorLibrary.Contracts;

namespace EventAggregatorLibrary.Events
{
    public class WarehouseReceivedNewSuppliesEvent : IEvent
    {
        public WarehouseReceivedNewSuppliesEvent(string description)
        {
            Description = description;
        }

        public string Description { get; set; }
    }
}
