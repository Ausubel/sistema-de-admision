USE Admission;
GO

IF OBJECT_ID('Area') IS NULL
BEGIN
	CREATE TABLE Area(
		id_area CHAR NOT NULL,
		nombre_area VARCHAR(100) NOT NULL,
		CONSTRAINT PK_area PRIMARY KEY (id_area)
	);
END;
GO