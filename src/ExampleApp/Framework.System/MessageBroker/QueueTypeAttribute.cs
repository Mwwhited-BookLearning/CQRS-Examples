namespace System.MessageBroker;

[AttributeUsage(AttributeTargets.Class)]
public class QueueTypeAttribute : Attribute
{
    public string? Name { get; set; }
    public string? Schema { get; set; }
    public bool Status { get; set; } = true;
    public bool Retention { get; set; } = false;
    public bool PoisonMessageHandling { get; set; } = true;

    public override object TypeId => this;
}
