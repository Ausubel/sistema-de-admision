USE master;
GO

IF NOT EXISTS (SELECT 1 FROM sys.databases WHERE name='Admission')
	CREATE DATABASE Admission;
GO

USE Admission;
GO