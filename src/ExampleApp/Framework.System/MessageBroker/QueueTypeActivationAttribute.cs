namespace System.MessageBroker;

[AttributeUsage(AttributeTargets.Class)]
public class QueueTypeActivationAttribute : Attribute
{
    public const string Self = nameof(Self);
    public const string Owner = nameof(Owner);

    public string? ProcedureName { get; set; }
    public int MaxQueueReaders { get; set; } = 1;
    public bool Status { get; set; } = true;
    public string? ExecuteAs { get; set; } = Self;

    public override object TypeId => this;
}
