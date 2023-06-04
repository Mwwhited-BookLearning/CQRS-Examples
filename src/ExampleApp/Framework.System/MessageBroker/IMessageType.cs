namespace System.MessageBroker;

public interface IMessageType
{
    public string? Name { get; }
    public string? Schema { get; }
    public string? Owner { get; }
    public MessageTypeValidations Validation { get; }
}
