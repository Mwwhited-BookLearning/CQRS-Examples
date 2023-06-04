using System.MessageBroker;

namespace System.Messages;

[MessageType(Name = "DEFAULT", Validation = MessageTypeValidations.None)]
public class DefaultMessageType : IMessageType
{
}
