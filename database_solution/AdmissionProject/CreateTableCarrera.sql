USE Admission;
GO

IF OBJECT_ID('carrera') IS NULL
BEGIN
	CREATE TABLE carrera(
		codigo_carrera INT IDENTITY(1,1) NOT NULL,
		nombre_carrera VARCHAR(100) NOT NULL,
		CONSTRAINT PK_carrera PRIMARY KEY (codigo_carrera)
	);
END;
GO