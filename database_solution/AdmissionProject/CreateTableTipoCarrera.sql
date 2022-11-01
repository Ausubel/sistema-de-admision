USE Admission;
GO

IF OBJECT_ID('tipo_carrera') IS NULL
BEGIN
	CREATE TABLE tipo_carrera(
		codigo_tipo_carrera CHAR NOT NULL,
		nombre_tipo_carrera VARCHAR(100) NOT NULL,

		CONSTRAINT PK_carrera PRIMARY KEY (codigo_tipo_carrera)
	);
END;
GO