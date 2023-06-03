CREATE DATABASE QueueTest;
GO
USE QueueTest;
GO
CREATE QUEUE dbo.TestQueue;
GO
CREATE SERVICE TestService ON QUEUE dbo.TestQueue;
GO
