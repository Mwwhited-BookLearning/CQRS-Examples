using System.MessageBroker;

namespace System.Messages;

[QueueType(
    Name = nameof(EventNotificationErrorsQueue),
    PoisonMessageHandling = false,
    Retention = false,
    Schema = "dbo",
    Status = true
    )]
public class EventNotificationErrorsQueue : IQueueType
{
}
