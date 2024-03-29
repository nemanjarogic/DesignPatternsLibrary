﻿using StoreManagement.Contracts;
using StoreManagement.Events;

namespace StoreManagement.Components.Publishers;

public class OrderPublisher : IPublisher
{
    private readonly IEventAggregator _eventAggregator;

    public OrderPublisher(IEventAggregator eventAggregator)
    {
        _eventAggregator = eventAggregator;
    }

    public void Publish(string payload) =>
        _eventAggregator.Publish(new OrderCreatedEvent(payload));
}
