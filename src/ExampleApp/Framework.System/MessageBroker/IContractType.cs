namespace System.MessageBroker;

public interface IContractType
{
    IReadOnlyList<(IMessageType messageType, MessageSenders sendBy)> Messages { get; }
}
