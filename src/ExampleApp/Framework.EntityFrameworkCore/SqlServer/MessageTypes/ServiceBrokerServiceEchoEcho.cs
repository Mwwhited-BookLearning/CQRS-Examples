using System.MessageBroker;

namespace Framework.EntityFrameworkCore.SqlServer.MessageTypes;

[MessageType(Name = "http://schemas.microsoft.com/SQL/ServiceBroker/ServiceEcho/Echo", Validation = MessageTypeValidations.None)]
public class ServiceBrokerServiceEchoEcho : IMessageType
{
}
