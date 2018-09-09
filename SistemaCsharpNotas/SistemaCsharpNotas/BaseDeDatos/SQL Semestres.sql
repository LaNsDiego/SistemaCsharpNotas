-------------------------------
--   CREATE TABLE  ------------
-------------------------------
CREATE TABLE Semestres (
	id INT IDENTITY  PRIMARY KEY ,
	nombre VARCHAR(50) UNIQUE NOT NULL
);


----------------
--   CREATE  ---
----------------
CREATE PROCEDURE spCrearSemestre
	@nombre VARCHAR(50)
AS
BEGIN
	INSERT INTO Semestre (nombre) VALUES(@nombre)
END

----------------
--   READ  -----
----------------
CREATE PROCEDURE spObtenerSemestre
	@id INT
AS
BEGIN
	SELECT id,nombre FROM Semestres WHERE id = @id
END

----------------
--   READ ALL --
----------------

CREATE PROCEDURE spListarSemestres
	@id INT
AS
BEGIN
	SELECT id,nombre FROM Semestres 
END



----------------
--   UPDATE  ---
----------------
CREATE PROCEDURE spActualizarSemestre
	@id INT,
	@nombre VARCHAR(50)
AS
BEGIN
	UPDATE Semestres SET nombre = @nombre WHERE id = @id
END

----------------
--   DELETE  ---
----------------