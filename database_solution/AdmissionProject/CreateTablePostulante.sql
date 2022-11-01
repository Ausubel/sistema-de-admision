USE Admission;
GO

IF OBJECT_ID('postulante') IS NULL
BEGIN
	CREATE TABLE postulante(
		codigo_postulante INT IDENTITY(20220000,1)NOT NULL,
		nombre VARCHAR(100) NOT NULL,
		apellido_paterno VARCHAR(100) NOT NULL,
		apellido_materno VARCHAR(100) NOT NULL,
		edad INT NOT NULL,
		nota FLOAT NULL,
		codigo_carrera INT NOT NULL,
		CONSTRAINT PK_postulante PRIMARY KEY (codigo_postulante),
		CONSTRAINT FK_codigo_carrera FOREIGN KEY (codigo_carrera) REFERENCES
		carrera (codigo_carrera) ON DELETE NO ACTION ON UPDATE NO ACTION
	);
END;
GO