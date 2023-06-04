using System.MessageBroker;

namespace System.Messages;

[QueueType(
    Name = nameof(QueryNotificationErrorsQueue),
    PoisonMessageHandling = false,
    Retention = false,
    Schema = "dbo",
    Status = true
    )]
public class QueryNotificationErrorsQueue : IQueueType
{
}
