using System.MessageBroker;

namespace Framework.EntityFrameworkCore.SqlServer.MessageTypes;

[MessageType(Name = "http://schemas.microsoft.com/SQL/ServiceBroker/DialogTimer", Validation = MessageTypeValidations.Empty)]
public class ServiceBrokerDialogTimer : IMessageType
{
}
