using System.MessageBroker;

namespace System.Messages;

[ContractType(Name = "DEFAULT")]
public class DefaultContract : IContractType
{
    public IReadOnlyList<(IMessageType messageType, MessageSenders sendBy)> Messages => new []
    {
        ((IMessageType)new DefaultMessageType(), MessageSenders.Any),
    };
}
