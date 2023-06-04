using Framework.EntityFrameworkCore.SqlServer.MessageTypes;
using System.Collections.Generic;
using System.MessageBroker;

namespace System.Messages;

[ContractType(Name = "http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice")]
public class ServiceBrokerBrokerConfigurationNotice : IContractType
{
    public IReadOnlyList<(IMessageType messageType, MessageSenders sendBy)> Messages => new[]
    {
        ((IMessageType)new ServiceBrokerBrokerConfigurationNoticeMissingRoute(), MessageSenders.Initiator),
        ((IMessageType)new ServiceBrokerBrokerConfigurationNoticeFailedRoute(), MessageSenders.Initiator),
        ((IMessageType)new ServiceBrokerBrokerConfigurationNoticeMissingRemoteServiceBinding(), MessageSenders.Initiator),
        ((IMessageType)new ServiceBrokerBrokerConfigurationNoticeFailedRemoteServiceBinding(), MessageSenders.Initiator),
    };
}
