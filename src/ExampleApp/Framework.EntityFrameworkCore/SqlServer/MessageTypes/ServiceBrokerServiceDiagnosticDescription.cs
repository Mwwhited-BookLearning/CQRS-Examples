using System.MessageBroker;

namespace Framework.EntityFrameworkCore.SqlServer.MessageTypes;

[MessageType(Name = "http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic/Description", Validation = MessageTypeValidations.WellFormedXml)]
public class ServiceBrokerServiceDiagnosticDescription : IMessageType
{
}
