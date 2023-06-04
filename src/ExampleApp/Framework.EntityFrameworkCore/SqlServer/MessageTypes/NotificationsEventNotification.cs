using System.MessageBroker;

namespace Framework.EntityFrameworkCore.SqlServer.MessageTypes;

[MessageType(Name = "http://schemas.microsoft.com/SQL/Notifications/EventNotification", Validation = MessageTypeValidations.WellFormedXml)]
public class NotificationsEventNotification : IMessageType
{
}
