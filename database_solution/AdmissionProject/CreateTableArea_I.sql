USE Admission;
GO

IF OBJECT_ID('Area') IS NULL
BEGIN
	CREATE TABLE Area(
		id_area INT IDENTITY(1,1) NOT NULL,
		letra_area CHAR(1) NOT NULL,
		nombre_area VARCHAR(100) NOT NULL,
		CONSTRAINT PK_area PRIMARY KEY (id_area)
	);
END;
GO
