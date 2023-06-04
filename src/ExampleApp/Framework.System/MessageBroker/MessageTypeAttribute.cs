namespace System.MessageBroker;

[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public class MessageTypeAttribute : Attribute
{
    public string? Name { get; set; }
    public string? Schema { get; set; }
    public string? Owner { get; set; }
    public MessageTypeValidations Validation { get; set; }

    public override object TypeId => this;
}
