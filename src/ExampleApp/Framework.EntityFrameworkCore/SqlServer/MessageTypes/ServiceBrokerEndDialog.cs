using System.ComponentModel.DataAnnotations;

namespace Framework.EntityFrameworkCore.SqlServer.MessageTypes
{
    [MessageType(Name = "http://schemas.microsoft.com/SQL/ServiceBroker/EndDialog", Validation = MessageTypeValidations.Empty)]
    public class ServiceBrokerEndDialog : IMessageType
    {
    }

    /*
SELECT *
FROM sys.service_message_types
    * 
http://schemas.microsoft.com/SQL/ServiceBroker/Error	1	1	X 	XML	NULL
http://schemas.microsoft.com/SQL/ServiceBroker/EndDialog	2	1	E 	EMPTY	NULL
http://schemas.microsoft.com/SQL/Notifications/QueryNotification	3	1	X 	XML	NULL
http://schemas.microsoft.com/SQL/Notifications/EventNotification	4	1	X 	XML	NULL
http://schemas.microsoft.com/SQL/ServiceBroker/DialogTimer	5	1	E 	EMPTY	NULL
http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice/MissingRoute	6	1	X 	XML	NULL
http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice/FailedRoute	7	1	X 	XML	NULL
http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice/MissingRemoteServiceBinding	8	1	X 	XML	NULL
http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice/FailedRemoteServiceBinding	9	1	X 	XML	NULL
http://schemas.microsoft.com/SQL/ServiceBroker/ServiceEcho/Echo	10	1	N 	BINARY	NULL
http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic/Query	11	1	X 	XML	NULL
http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic/Status	12	1	X 	XML	NULL
http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic/Description	13	1	N 	BINARY	NULL
DEFAULT	14	1	N 	BINARY	NULL
    */
}
