-------------------------------
--   CREATE TABLE  ------------
-------------------------------
CREATE TABLE Capacidades (
	id INT IDENTITY  PRIMARY KEY ,
	nota_id INT NOT NULL,
	numero INT NOT NULL,
	nombre VARCHAR(100) NOT NULL,
	calificacion INT NOT NULL
);
