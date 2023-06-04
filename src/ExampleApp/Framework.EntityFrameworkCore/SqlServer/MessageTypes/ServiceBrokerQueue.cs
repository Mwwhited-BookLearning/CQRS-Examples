using System.MessageBroker;

namespace System.Messages;

[QueueType(
    Name = nameof(ServiceBrokerQueue),
    PoisonMessageHandling = false,
    Retention = false,
    Schema = "dbo",
    Status = true
    )]
public class ServiceBrokerQueue : IQueueType
{
}