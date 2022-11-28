USE Admission
GO

INSERT INTO Detalle(id_area,perfil_estudiante,competencias_profesionales,datos_adicionales) VALUES
(1,
'Tiene conocimientos básicos a un nivel medio superior en las áreas de las ciencias naturales.
Es creativo e innovador en el estudio de procesos y técnicas biológicas.
Tiene habilidades, destrezas y actitudes para la investigación en el campo de las ciencias biológicas.
Tiene disponibilidad para el trabajo en equipo mostrando principios y valores éticos.
Es observador, proactivo y con capacidad de liderazgo para fomentar el cuidado del ambiente, salud pública y agroindustria.
Muestra compromiso e identificación con la universidad, sociedad y ambiente.',
'Evalúa sistemas biológicos y su entorno, aplicando técnicas de análisis clínicos, biológicos, epidemiológicos y forenses, en la determinación de metabolitos, identificación celular, de agentes etiológicos,\r\n vectores en enfermedades metaxénicas, evidencias biológicas en la escena del crimen, de acuerdo con marcos teóricos, avances científicos, política nacional de salud y nuevo código \r\n procesal penal, con actitud ética.
Promueve la conservación del medio ambiente y la biodiversidad según marcos teóricos actuales que le permite proponer acciones de desarrollo sostenible y bienestar de la comunidad, en el marco de la \r\n normativa nacional e internacional, mostrando una actitud de respeto al ser humano y su entorno.
Gestiona procesos de producción acuícola y agroindustrial, de acuerdo con marcos teóricos interdisciplinarios que contribuyen al desarrollo del sector y responden a la demanda del mercado nacional e \r\n internacional, según normas de calidad sanitaria e inocuidad, con eficacia, eficiencia, actitud ética y responsabilidad social.
Gestionar proyectos de investigación, emprendimiento e innovación tecnológica en las áreas de salud, conservación, acuícola y agroindustrial, respondiendo a la demanda del mercado nacional e \r\n internacional, según marcos teóricos interdisciplinarios y avances científicos, con responsabilidad social.',
'GRADO ACADÉMICO: Bachiller en Ciencias Biológicas
TÍTULO PROFESIONAL: Biólogo
DURACIÓN DE ESTUDIOS: 5 años y 10 semestres
');
GO
SELECT A.id_detalle,D.nombre_area, A.perfil_estudiante,A.competencias_profesionales,A.datos_adicionales
FROM Area A
INNER JOIN
Detalle D ON D.id_area = A.id_area
