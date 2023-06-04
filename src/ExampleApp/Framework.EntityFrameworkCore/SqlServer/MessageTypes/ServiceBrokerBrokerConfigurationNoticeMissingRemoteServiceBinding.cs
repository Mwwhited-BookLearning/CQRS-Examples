using System.MessageBroker;

namespace Framework.EntityFrameworkCore.SqlServer.MessageTypes
{
    [MessageType(Name = "http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice/MissingRemoteServiceBinding", Validation = MessageTypeValidations.WellFormedXml)]
    public class ServiceBrokerBrokerConfigurationNoticeMissingRemoteServiceBinding : IMessageType
    {
    }
    /*
SELECT *
FROM sys.service_message_types
    * 
http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice/MissingRemoteServiceBinding	8	1	X 	XML	NULL
http://schemas.microsoft.com/SQL/ServiceBroker/BrokerConfigurationNotice/FailedRemoteServiceBinding	9	1	X 	XML	NULL
http://schemas.microsoft.com/SQL/ServiceBroker/ServiceEcho/Echo	10	1	N 	BINARY	NULL
http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic/Query	11	1	X 	XML	NULL
http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic/Status	12	1	X 	XML	NULL
http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic/Description	13	1	N 	BINARY	NULL
DEFAULT	14	1	N 	BINARY	NULL
    */
}
