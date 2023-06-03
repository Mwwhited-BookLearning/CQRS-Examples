using System.ComponentModel.DataAnnotations;

namespace Framework.EntityFrameworkCore.SqlServer.MessageTypes
{
    [MessageType(Name = "http://schemas.microsoft.com/SQL/ServiceBroker/ServiceEcho/Echo", Validation = MessageTypeValidations.None)]
    public class ServiceBrokerServiceEchoEcho : IMessageType
    {
    }
    /*
SELECT *
FROM sys.service_message_types
    * 
http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic/Query	11	1	X 	XML	NULL
http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic/Status	12	1	X 	XML	NULL
http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic/Description	13	1	N 	BINARY	NULL
DEFAULT	14	1	N 	BINARY	NULL
    */
}
