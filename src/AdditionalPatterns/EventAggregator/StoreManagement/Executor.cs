using System;
using DesignPatternsLibrary.PatternExecutors;
using EventAggregatorLibrary.Components;
using EventAggregatorLibrary.Components.Publishers;
using EventAggregatorLibrary.Components.Subscribers;

namespace EventAggregatorLibrary
{
    public class Executor : PatternExecutor
    {
        public override string Name => "Event Aggregator - Behavioral Pattern";

        public override void Execute()
        {
            var eventAggregator = new EventAggregator();

            var orderPublisher = new OrderPublisher(eventAggregator);
            var warehousePublisher = new WarehousePublisher(eventAggregator);

            var orderSubscriber = new OrderSubscriber(eventAggregator);
            var businessTrackingSubscriber = new BusinessTrackingSubscriber(eventAggregator);

            Console.WriteLine("Preparing order 1...");
            orderPublisher.Publish("Order 1");

            Console.WriteLine("\nPreparing small delivery...");
            warehousePublisher.Publish("Small delivery to the warehouse.");

            Console.WriteLine("\nPreparing order 2...");
            orderPublisher.Publish("Order 2");

            Console.WriteLine("\nUnsubscribing order subscriber from further events...");
            orderSubscriber.Unsubscribe();

            Console.WriteLine("\nPreparing order 3...");
            orderPublisher.Publish("Order 3");
        }
    }
}
