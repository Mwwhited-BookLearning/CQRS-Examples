using Framework.EntityFrameworkCore.SqlServer.MessageTypes;
using System.Collections.Generic;
using System.MessageBroker;

namespace System.Messages;

[ContractType(Name = "http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification")]
public class NotificationsPostQueryNotification : IContractType
{
    public IReadOnlyList<(IMessageType messageType, MessageSenders sendBy)> Messages => new[]
    {
        ((IMessageType)new NotificationsQueryNotification(), MessageSenders.Initiator),
    };
}

/*
http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice	http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice/MissingRoute	INITIATOR	0	1
http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice	http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice/FailedRoute	INITIATOR	0	1
http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice	http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice/MissingRemoteServiceBinding	INITIATOR	0	1
http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice	http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice/FailedRemoteServiceBinding	INITIATOR	0	1
http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic	http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic/Query	INITIATOR	0	1
http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic	http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic/Status	TARGET	1	0
http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic	http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic/Description	TARGET	1	0
http://schemas.microsoft.com/SQL/ServiceBroker/ServiceEcho	http://schemas.microsoft.com/SQL/ServiceBroker/ServiceEcho/Echo	ANY	1	1
*/