namespace System.MessageBroker;

public interface IServiceType
{
    public string? Name { get; }
    public string? Owner { get; }

    IQueueType Queue { get; }
    IReadOnlyList<IContractType> Contracts { get; }
}


/*
CREATE SERVICE service_name  
   [ AUTHORIZATION owner_name ]  
   ON QUEUE [ schema_name. ]queue_name  
   [ ( contract_name | [DEFAULT][ ,...n ] ) ]  
[ ; ]

ServiceName																QueueName						ContractName
http://schemas.microsoft.com/SQL/Notifications/EventNotificationService	EventNotificationErrorsQueue	NULL
http://schemas.microsoft.com/SQL/Notifications/QueryNotificationService	QueryNotificationErrorsQueue	NULL
http://schemas.microsoft.com/SQL/ServiceBroker/ServiceBroker			ServiceBrokerQueue				http://schemas.microsoft.com/SQL/ServiceBroker/ServiceEcho
http://schemas.microsoft.com/SQL/ServiceBroker/ServiceBroker			ServiceBrokerQueue				http://schemas.microsoft.com/SQL/ServiceBroker/ServiceDiagnostic
*/