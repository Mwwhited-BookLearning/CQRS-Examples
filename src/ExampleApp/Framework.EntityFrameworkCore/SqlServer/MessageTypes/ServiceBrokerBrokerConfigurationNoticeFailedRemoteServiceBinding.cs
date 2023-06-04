using System.MessageBroker;

namespace Framework.EntityFrameworkCore.SqlServer.MessageTypes;

[MessageType(Name = "http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice/FailedRemoteServiceBinding", Validation = MessageTypeValidations.WellFormedXml)]
public class ServiceBrokerBrokerConfigurationNoticeFailedRemoteServiceBinding : IMessageType
{
}
