using System.MessageBroker;

namespace Framework.EntityFrameworkCore.SqlServer.MessageTypes;

[MessageType(Name = "http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice/MissingRoute", Validation = MessageTypeValidations.WellFormedXml)]
public class ServiceBrokerBrokerConfigurationNoticeMissingRoute : IMessageType
{
}
