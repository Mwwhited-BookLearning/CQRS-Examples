using System.MessageBroker;

namespace System.Messages;

public class DefaultMessageType : IMessageType
{
    public string? Name => "DEFAULT";
    public string? Schema => null;
    public string? Owner => null;
    public MessageTypeValidations Validation => MessageTypeValidations.None;
}
