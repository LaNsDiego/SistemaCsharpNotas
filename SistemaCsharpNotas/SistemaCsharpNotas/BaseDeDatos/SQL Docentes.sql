-------------------------------
--   CREATE TABLE  ------------
-------------------------------
CREATE TABLE Docentes (
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
CREATE PROCEDURE spCrearDocente
	@codigo CHAR(10) ,
	@dni CHAR(8),
	@nombres VARCHAR(25),
	@apellidos VARCHAR(25),
	@sexo CHAR(1),
	@correo VARCHAR(40)

AS
BEGIN
	INSERT INTO Docentes (codigo,dni,nombres,apellidos,sexo,correo) VALUES(@codigo,@dni,@nombres,@apellidos,@sexo,@correo)
END


----------------
--  READ ALL ---
----------------
CREATE PROCEDURE spListarDocente
AS
	BEGIN
		SELECT id,codigo,dni,nombres,apellidos,sexo,correo FROM Docentes
END

----------------
--   READ  -----
----------------
CREATE PROCEDURE spObtenerDocente
	@id INT
AS
	BEGIN
		SELECT id,codigo,dni,nombres,apellidos,sexo,correo FROM Docentes WHERE id=@id
END

----------------
--   UPDATE  ---
----------------
CREATE PROCEDURE spActualizarDocente
	@id INT,
	@codigo CHAR(10) ,
	@dni CHAR(8),
	@nombres VARCHAR(25),
	@apellidos VARCHAR(25),
	@sexo CHAR(1),
	@correo VARCHAR(40)
AS
BEGIN
	UPDATE Docentes SET codigo=@codigo,dni=@dni,nombres=@nombres,apellidos=@apellidos,sexo=@sexo,correo=@correo WHERE id = @id
END

----------------
--   DELETE  ---
----------------