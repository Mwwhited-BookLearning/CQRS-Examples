using System.MessageBroker;

namespace Framework.EntityFrameworkCore.SqlServer.MessageTypes;

[MessageType(Name = "http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic/Status", Validation = MessageTypeValidations.WellFormedXml)]
public class ServiceBrokerServiceDiagnosticStatus : IMessageType
{
}
