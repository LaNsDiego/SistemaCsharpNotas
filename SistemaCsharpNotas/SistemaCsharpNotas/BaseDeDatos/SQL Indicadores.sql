-------------------------------
--   CREATE TABLE  ------------
-------------------------------
CREATE TABLE Indicadores (
	id INT IDENTITY  PRIMARY KEY ,
	criterio_id INT NOT NULL,
	calificacion INT NOT NULL
);