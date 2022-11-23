USE Admission;
GO

IF OBJECT_ID('Postulante') IS NULL
BEGIN
	CREATE TABLE Postulante(
		id_postulante INT IDENTITY(20220000,1)NOT NULL,
		id_escuela INT NOT NULL,
		id_area INT NOT NULL,
		nombre VARCHAR(100) NOT NULL,
		apellido_paterno VARCHAR(100) NOT NULL,
		apellido_materno VARCHAR(100) NOT NULL,
		edad INT NOT NULL,
		nota FLOAT NULL,		
		CONSTRAINT PK_postulante PRIMARY KEY (id_postulante),
		CONSTRAINT FK_estudiante_escuela FOREIGN KEY (id_escuela) REFERENCES
		Escuela (id_escuela) ON DELETE NO ACTION ON UPDATE NO ACTION,
		CONSTRAINT FK_estudiante_area FOREIGN KEY (id_area) REFERENCES
		Area (id_area) ON DELETE NO ACTION ON UPDATE NO ACTION
	);
END;
GO