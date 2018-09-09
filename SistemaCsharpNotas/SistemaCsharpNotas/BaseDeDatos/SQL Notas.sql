-------------------------------
--   CREATE TABLE  ------------
-------------------------------
CREATE TABLE Notas (
	id INT IDENTITY  PRIMARY KEY ,
	estudiante_id INT NOT NULL,
	silabo_id INT NOT NULL,
	calificacion INT NOT NULL
);
