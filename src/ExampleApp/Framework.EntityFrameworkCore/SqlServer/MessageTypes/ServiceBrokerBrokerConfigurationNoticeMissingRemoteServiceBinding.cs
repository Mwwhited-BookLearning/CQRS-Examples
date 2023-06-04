using System.MessageBroker;

namespace Framework.EntityFrameworkCore.SqlServer.MessageTypes;

[MessageType(Name = "http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice/MissingRemoteServiceBinding", Validation = MessageTypeValidations.WellFormedXml)]
public class ServiceBrokerBrokerConfigurationNoticeMissingRemoteServiceBinding : IMessageType
{
}
