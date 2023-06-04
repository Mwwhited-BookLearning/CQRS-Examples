using System.MessageBroker;

namespace System.Messages;

public class DefaultContract : IContractType
{
    public IReadOnlyList<(IMessageType messageType, MessageSenders sendBy)> Messages => new[]
    {
        ((IMessageType)new DefaultMessageType(), MessageSenders.Any),
    };

    public string? Name => "DEFAULT";
    public string? Owner => null;
}
