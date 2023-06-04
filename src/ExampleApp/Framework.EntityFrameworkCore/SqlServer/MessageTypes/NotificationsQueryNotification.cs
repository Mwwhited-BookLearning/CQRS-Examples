using System.MessageBroker;

namespace Framework.EntityFrameworkCore.SqlServer.MessageTypes;

[MessageType(Name = "http://schemas.microsoft.com/SQL/Notifications/QueryNotification", Validation = MessageTypeValidations.WellFormedXml)]
public class NotificationsQueryNotification : IMessageType
{
}
