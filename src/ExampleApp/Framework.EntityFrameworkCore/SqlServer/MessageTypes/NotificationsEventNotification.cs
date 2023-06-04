using System.MessageBroker;

namespace Framework.EntityFrameworkCore.SqlServer.MessageTypes;

public class NotificationsEventNotification : IMessageType
{
    public string? Name => "http://schemas.microsoft.com/SQL/Notifications/EventNotification";
    public string? Schema => null;
    public string? Owner => null;
    public MessageTypeValidations Validation => MessageTypeValidations.WellFormedXml;
}
