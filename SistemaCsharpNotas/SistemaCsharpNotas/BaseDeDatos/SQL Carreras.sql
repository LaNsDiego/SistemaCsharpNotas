-------------------------------
--   CREATE TABLE  ------------
-------------------------------
CREATE TABLE Carreras (
	id INT IDENTITY  PRIMARY KEY ,
	nombre VARCHAR(50) UNIQUE NOT NULL,
	sigla VARCHAR(5) UNIQUE NOT NULL,
	turno INT NOT NULL
);


----------------
--   CREATE  ---
----------------
CREATE PROCEDURE spCrearCarrera
	@nombre VARCHAR(50),
	@sigla VARCHAR(5),
	@turno INT
AS
BEGIN
	INSERT INTO Carreras (nombre,sigla,turno) VALUES(@nombre,@sigla,@turno)
END

----------------
--   READ  -----
----------------
CREATE PROCEDURE spObtenerCarrera
	@id INT
AS
BEGIN
	SELECT id,nombre,sigla,turno FROM Carreras WHERE id = @id
END

----------------
--  READ ALL ---
----------------
CREATE PROCEDURE spListarCarreras
AS
BEGIN
	SELECT id,nombre,sigla,turno FROM Carreras
END

----------------
--   UPDATE  ---
----------------
CREATE PROCEDURE spActualizarCarrera
	@id INT,
	@nombre VARCHAR(50) ,
	@sigla VARCHAR(5),
	@turno INT

AS
BEGIN
	UPDATE Carreras SET nombre = @nombre, sigla = @sigla ,turno = @turno WHERE id = @id
END

----------------
--   DELETE  ---
----------------
/*CREATE PROCEDURE spBorrarCarrera
	@id INT,
	@nombre VARCHAR(50) ,
	@sigla VARCHAR(5),
	@turno INT

AS
BEGIN
	UPDATE Carreras SET nombre = @nombre, sigla = @sigla ,turno = @turno WHERE id = @id
END*/ 

