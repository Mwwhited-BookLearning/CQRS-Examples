namespace System.MessageBroker;

public interface IContractType
{
    public string? Name { get; }
    public string? Owner { get; }


    IReadOnlyList<(IMessageType messageType, MessageSenders sendBy)> Messages { get; }
}
