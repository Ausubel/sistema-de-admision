USE Admission;
GO

IF OBJECT_ID('Escuela') IS NULL
BEGIN
	CREATE TABLE Escuela(
		id_escuela INT IDENTITY(1,1) NOT NULL,
		id_facultad INT NOT NULL,
		id_area INT NOT NULL,
		nombre_escuela VARCHAR(100) NOT NULL,
		perfil_estudiante VARCHAR(1500) NOT NULL,
		competencias_profesionales VARCHAR(1500) NOT NULL,
		datos_adicionales VARCHAR(1500) NOT NULL,
		CONSTRAINT PK_escuela PRIMARY KEY (id_escuela),
		CONSTRAINT FK_id_facultad FOREIGN KEY (id_facultad) 
		REFERENCES Facultad(id_facultad) ON DELETE NO ACTION ON UPDATE NO ACTION,
		CONSTRAINT FK_id_area_escuela FOREIGN KEY (id_area) 
		REFERENCES Area(id_area) ON DELETE NO ACTION ON UPDATE NO ACTION
	);
END;
GO