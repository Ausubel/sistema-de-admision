USE master;
GO

IF NOT EXISTS (SELECT 1 FROM sys.databases WHERE name='Admission')
BEGIN
	CREATE DATABASE Admission;
END;
GO

USE Admission;
GO