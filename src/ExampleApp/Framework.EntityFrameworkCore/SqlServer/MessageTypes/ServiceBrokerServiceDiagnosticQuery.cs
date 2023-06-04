using System.MessageBroker;

namespace Framework.EntityFrameworkCore.SqlServer.MessageTypes;

[MessageType(Name = "http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic/Query", Validation = MessageTypeValidations.WellFormedXml)]
public class ServiceBrokerServiceDiagnosticQuery : IMessageType
{
}
