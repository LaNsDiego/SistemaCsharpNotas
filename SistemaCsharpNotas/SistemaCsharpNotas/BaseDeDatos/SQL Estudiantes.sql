-------------------------------
--   CREATE TABLE  ------------
-------------------------------
CREATE TABLE Estudiantes (
	id INT IDENTITY  PRIMARY KEY ,
	codigo CHAR(10) UNIQUE NOT NULL,
	dni CHAR(8) UNIQUE NOT NULL,
	nombres VARCHAR(25) NOT NULL,
	apellidos VARCHAR(25) NOT NULL,
	sexo CHAR(1) NOT NULL CHECK(sexo IN('M','F')),
	correo VARCHAR(40) NOT NULL UNIQUE
);


----------------
--   CREATE  ---
----------------
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


----------------
--  READ ALL ---
----------------
CREATE PROCEDURE spListarEstudiante
AS
	BEGIN
		SELECT id,codigo,dni,nombres,apellidos,sexo,correo from Estudiantes
END

----------------
--   READ  -----
----------------
CREATE PROCEDURE spObtenerEstudiante
	@id INT
AS
	BEGIN
		SELECT id,codigo,dni,nombres,apellidos,sexo,correo FROM Estudiantes WHERE id=@id
END



----------------
--   UPDATE  ---
----------------
CREATE PROCEDURE spModificarEstudiante
	@id INT,
	@codigo CHAR(10) ,
	@dni CHAR(8),
	@nombres VARCHAR(25),
	@apellidos VARCHAR(25),
	@sexo CHAR(1),
	@correo VARCHAR(40)

AS
BEGIN
	UPDATE Estudiantes SET codigo=@codigo,dni=@dni,nombres=@nombres,apellidos=@apellidos,sexo=@sexo,correo=@correo WHERE id = @id
END

