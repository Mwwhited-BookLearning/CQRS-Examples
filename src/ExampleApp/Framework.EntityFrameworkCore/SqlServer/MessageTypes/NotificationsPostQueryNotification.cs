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