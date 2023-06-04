using Framework.EntityFrameworkCore.SqlServer.MessageTypes;
using System.Collections.Generic;
using System.MessageBroker;

namespace System.Messages;

[ContractType(Name = "http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic")]
public class ServiceBrokerServiceDiagnostic : IContractType
{
    public IReadOnlyList<(IMessageType messageType, MessageSenders sendBy)> Messages => new[]
    {
        ((IMessageType)new ServiceBrokerServiceDiagnosticQuery(), MessageSenders.Initiator),
        ((IMessageType)new ServiceBrokerServiceDiagnosticStatus(), MessageSenders.Target),
        ((IMessageType)new ServiceBrokerServiceDiagnosticDescription(), MessageSenders.Target),
    };
}
