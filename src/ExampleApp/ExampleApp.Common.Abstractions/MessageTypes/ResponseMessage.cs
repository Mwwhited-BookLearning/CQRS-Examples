using System.ComponentModel.DataAnnotations;
using System.MessageBroker;

namespace ExampleApp.Common.MessageTypes
{
    [MessageType]
    public class ResponseMessage : IMessageType
    {
    }
}
