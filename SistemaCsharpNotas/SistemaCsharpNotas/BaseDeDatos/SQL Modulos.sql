-------------------------------
--   CREATE TABLE  ------------
-------------------------------
CREATE TABLE Modulos (
	id INT IDENTITY  PRIMARY KEY ,
	nombre VARCHAR(50) NOT NULL,
	numero INT NOT NULL,
	carrera_id VARCHAR(5) NOT NULL
);


----------------
--   CREATE  ---
----------------
CREATE PROCEDURE spCrearModulo
	@nombre VARCHAR(50),
	@numero INT,
	@carrera_id VARCHAR(5) 
AS
BEGIN
	INSERT INTO Modulos (nombre,numero,carrera_id) VALUES(@nombre,@numero,@carrera_id)
END

----------------
--   READ  -----
----------------
CREATE PROCEDURE spObtenerModulo
	@id INT
AS
BEGIN
	SELECT id,nombre,numero,carrera_id FROM Modulos WHERE id = @id
END


----------------
--  READ ALL ---
----------------
CREATE PROCEDURE spListarModulos
AS
BEGIN
	SELECT id,nombre,numero,carrera_id FROM Modulos
END

----------------
--   UPDATE  ---
----------------
CREATE PROCEDURE spActualizarModulo
	@id INT,
	@nombre VARCHAR(50),
	@numero INT,
	@carrera_id VARCHAR(5) 

AS
BEGIN
	UPDATE Modulos SET nombre = @nombre, numero = @numero ,carrera_id = @carrera_id WHERE id = @id
END


----------------
--   DELETE  ---
----------------