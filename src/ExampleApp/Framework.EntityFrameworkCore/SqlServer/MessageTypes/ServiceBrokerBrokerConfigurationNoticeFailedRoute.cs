using System.MessageBroker;

namespace Framework.EntityFrameworkCore.SqlServer.MessageTypes;

[MessageType(Name = "http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice/FailedRoute", Validation = MessageTypeValidations.WellFormedXml)]
public class ServiceBrokerBrokerConfigurationNoticeFailedRoute : IMessageType
{
}
