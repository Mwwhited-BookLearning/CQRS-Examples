using System.MessageBroker;

namespace System.Messages;

public class EventNotificationErrorsQueue : IQueueType
{
    public string? Name => nameof(EventNotificationErrorsQueue);
    public string? Schema => "dbo";
    public bool? Status => true;
    public bool? Retention => false;
    public bool? PoisonMessageHandling => false;
}
