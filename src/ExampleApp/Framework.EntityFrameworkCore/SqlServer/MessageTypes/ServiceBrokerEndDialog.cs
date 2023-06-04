using System.MessageBroker;

namespace Framework.EntityFrameworkCore.SqlServer.MessageTypes;

[MessageType(Name = "http://schemas.microsoft.com/SQL/ServiceBroker/EndDialog", Validation = MessageTypeValidations.Empty)]
public class ServiceBrokerEndDialog : IMessageType
{
}
