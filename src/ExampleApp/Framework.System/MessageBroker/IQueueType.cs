namespace System.MessageBroker;

public interface IQueueType
{
    public string? Name { get; }
    public string? Schema { get; }
    bool? Status { get; } //= true;
    bool? Retention { get; } //= false;
    bool? PoisonMessageHandling { get; }// = true;
}
