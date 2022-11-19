USE Admission;
GO

IF OBJECT_ID('Detalle') IS NULL
BEGIN
	CREATE TABLE Detalle(
		id_detalle INT IDENTITY(1,1) NOT NULL,
		id_area INT NOT NULL,
		perfil_estudiante VARCHAR(1500) NOT NULL,
		competencias_profesionales VARCHAR(1500) NOT NULL,
		datos_adicionales VARCHAR(1500) NOT NULL,
		CONSTRAINT PK_detalle PRIMARY KEY (id_detalle),
		CONSTRAINT FK_id_area FOREIGN KEY (id_area) 
		REFERENCES Area(id_area) ON DELETE NO ACTION ON UPDATE NO ACTION
	);
END;
GO