using Framework.EntityFrameworkCore.SqlServer.MessageTypes;
using System.Collections.Generic;
using System.MessageBroker;

namespace System.Messages;

public class NotificationsPostEventNotification : IContractType
{
    public IReadOnlyList<(IMessageType messageType, MessageSenders sendBy)> Messages => new[]
    {
        ((IMessageType)new NotificationsEventNotification(), MessageSenders.Initiator),
    };

    public string? Name => "http://schemas.microsoft.com/SQL/Notifications/PostEventNotification";
    public string? Owner => null;
}
