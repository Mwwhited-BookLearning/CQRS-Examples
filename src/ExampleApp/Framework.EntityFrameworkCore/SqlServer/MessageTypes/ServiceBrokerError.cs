using System.MessageBroker;

namespace Framework.EntityFrameworkCore.SqlServer.MessageTypes
{
    [MessageType(Name = "http://schemas.microsoft.com/SQL/ServiceBroker/Error", Validation = MessageTypeValidations.WellFormedXml)]
    public class ServiceBrokerError : IMessageType
    {
    }
}
