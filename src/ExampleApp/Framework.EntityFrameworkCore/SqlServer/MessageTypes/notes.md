

https://techcommunity.microsoft.com/t5/azure-sql-blog/cross-instance-service-broker-message-exchange-for-azure-sql/ba-p/2217323


SELECT *
FROM sys.service_message_types
select *
FROM sys.service_contracts
SELECT *
FROM sys.service_contract_message_usages
select *
FROM sys.service_message_types
select *
FROM sys.service_contract_usages
SELECT *
FROM sys.service_queues
SELECT *
FROM sys.service_queue_usages
SELECT *
FROM sys.transmission_queue
SELECT *
FROM sys.services

### Message Types

https://learn.microsoft.com/en-us/sql/t-sql/statements/create-message-type-transact-sql?view=sql-server-ver16

#### Create

```sql
CREATE MESSAGE TYPE message_type_name  
    [ AUTHORIZATION owner_name ]  
    [ VALIDATION = {  NONE  
                    | EMPTY   
                    | WELL_FORMED_XML  
                    | VALID_XML WITH SCHEMA COLLECTION schema_collection_name  
                   } ]  
[ ; ]  
```

#### Enumerate

```sql
select *
FROM sys.service_message_types
```

### Contracts

https://learn.microsoft.com/en-us/sql/t-sql/statements/create-contract-transact-sql?view=sql-server-ver16

#### Create

```sql
CREATE CONTRACT contract_name  
   [ AUTHORIZATION owner_name ]  
      (  {   { message_type_name | [ DEFAULT ] }  
          SENT BY { INITIATOR | TARGET | ANY }   
       } [ ,...n] )   
[ ; ]  
```

#### Enumerate

```sql
SELECT 
	service_contracts.name AS [ContractName]
	,service_message_types.name AS [MessageTypeName]
	,CASE service_contract_message_usages.is_sent_by_target * 2
		+ service_contract_message_usages.is_sent_by_initiator
		WHEN 3 THEN 'ANY'
		WHEN 2 THEN 'TARGET'
		WHEN 1 THEN 'INITIATOR'
		END AS [Send By]
	 
	,service_contract_message_usages.is_sent_by_target 
	,service_contract_message_usages.is_sent_by_initiator
FROM sys.service_contracts
LEFT OUTER JOIN sys.service_contract_message_usages
	ON service_contract_message_usages.service_contract_id = service_contracts.service_contract_id
LEFT OUTER JOIN sys.service_message_types
	ON service_message_types.message_type_id = service_contract_message_usages.message_type_id
```

### Queues

https://learn.microsoft.com/en-us/sql/t-sql/statements/create-queue-transact-sql?view=sql-server-ver16

#### Create

```sql
CREATE QUEUE <object>
   [ WITH
     [ STATUS = { ON | OFF } [ , ] ]
     [ RETENTION = { ON | OFF } [ , ] ]
     [ ACTIVATION (
         [ STATUS = { ON | OFF } , ]
           PROCEDURE_NAME = <procedure> ,
           MAX_QUEUE_READERS = max_readers ,
           EXECUTE AS { SELF | 'user_name' | OWNER }
            ) [ , ] ]
     [ POISON_MESSAGE_HANDLING (
         [ STATUS = { ON | OFF } ] ) ]
    ]
     [ ON { filegroup | [ DEFAULT ] } ]
[ ; ]

<object> ::=
{ database_name.schema_name.queue_name | schema_name.queue_name | queue_name }

<procedure> ::=
{ database_name.schema_name.stored_procedure_name | schema_name.stored_procedure_name | stored_procedure_name }
```

#### Enumerate

### Services

https://learn.microsoft.com/en-us/sql/t-sql/statements/create-service-transact-sql?view=sql-server-ver16

#### Create

```sql
CREATE SERVICE service_name  
   [ AUTHORIZATION owner_name ]  
   ON QUEUE [ schema_name. ]queue_name  
   [ ( contract_name | [DEFAULT][ ,...n ] ) ]  
[ ; ]
```
