-------------------------------
--   CREATE TABLE  ------------
-------------------------------
CREATE TABLE Criterios (
	id INT IDENTITY  PRIMARY KEY ,
	capacidad_id INT NOT NULL,
	nombre VARCHAR(25) NOT NULL,
	descripcion VARCHAR(100) NOT NULL,
	calificacion INT NOT NULL
);
