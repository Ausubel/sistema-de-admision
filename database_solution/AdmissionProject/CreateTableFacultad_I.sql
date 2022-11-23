USE Admission;
GO

IF OBJECT_ID('Facultad') IS NULL
BEGIN
	CREATE TABLE Facultad(
		id_facultad INT IDENTITY(1,1) NOT NULL,
		nombre_facultad VARCHAR(100) NOT NULL,
		CONSTRAINT PK_carrera PRIMARY KEY (id_facultad)
	);
END;
GO

SELECT * from Facultad


