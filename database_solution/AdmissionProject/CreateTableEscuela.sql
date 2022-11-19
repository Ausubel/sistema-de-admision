USE Admission;
GO

IF OBJECT_ID('Escuela') IS NULL
BEGIN
	CREATE TABLE Escuela(
		id_escuela INT IDENTITY(1,1) NOT NULL,
		id_facultad INT NOT NULL,
		id_detalle INT NOT NULL,
		nombre_escuela VARCHAR(100) NOT NULL,
		CONSTRAINT PK_escuela PRIMARY KEY (id_escuela),
		CONSTRAINT FK_id_facultad FOREIGN KEY (id_facultad) 
		REFERENCES Facultad(id_facultad) ON DELETE NO ACTION ON UPDATE NO ACTION,
		CONSTRAINT FK_id_detalle_escuela FOREIGN KEY (id_detalle) 
		REFERENCES Detalle(id_detalle) ON DELETE NO ACTION ON UPDATE NO ACTION
	);
END;
GO