--CREATE DATABASE pruebas;
select * from Estudiantes;
CREATE TABLE Estudiantes (
	id INT IDENTITY  PRIMARY KEY ,
	codigo CHAR(10) UNIQUE NOT NULL,
	dni CHAR(8) UNIQUE NOT NULL,
	nombres VARCHAR(25) NOT NULL,
	apellidos VARCHAR(25) NOT NULL,
	sexo CHAR(1) NOT NULL CHECK(sexo IN('M','F')),
	correo VARCHAR(40) NOT NULL UNIQUE
);


CREATE PROCEDURE spCrearEstudiante
	@codigo CHAR(10) ,
	@dni CHAR(8),
	@nombres VARCHAR(25),
	@apellidos VARCHAR(25),
	@sexo CHAR(1),
	@correo VARCHAR(40)

AS
BEGIN
	INSERT INTO Estudiantes (codigo,dni,nombres,apellidos,sexo,correo) VALUES(@codigo,@dni,@nombres,@apellidos,@sexo,@correo)
END