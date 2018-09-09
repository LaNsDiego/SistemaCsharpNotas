-------------------------------
--   CREATE TABLE  ------------
-------------------------------
CREATE TABLE Silabos (
	id INT IDENTITY  PRIMARY KEY ,
	anio VARCHAR(50) UNIQUE NOT NULL,
	turno VARCHAR(10) CHECK(turno IN('diurno','nocturno')) UNIQUE NOT NULL,
	unidad_id INT NOT NULL,
	docente_id INT NOT NULL
);


----------------
--   CREATE  ---
----------------
CREATE PROCEDURE spCrearSilabo
	@nombre VARCHAR(50),
	@sigla VARCHAR(5),
	@turno INT
AS
BEGIN
	INSERT INTO Silabos (nombre,sigla,turno) VALUES(@nombre,@sigla,@turno)
END

----------------
--   READ  -----
----------------
CREATE PROCEDURE spObtenerSilabo
	@id INT
AS
BEGIN
	SELECT id,nombre,sigla,turno FROM Silabos WHERE id = @id
END

----------------
--  READ ALL ---
----------------
CREATE PROCEDURE spListarSilabos
AS
BEGIN
	SELECT id,nombre,sigla,turno FROM Silabos
END

----------------
--   UPDATE  ---
----------------
CREATE PROCEDURE spActualizarSilabo
	@id INT,
	@nombre VARCHAR(50) ,
	@sigla VARCHAR(5),
	@turno INT

AS
BEGIN
	UPDATE Silabos SET nombre = @nombre, sigla = @sigla ,turno = @turno WHERE id = @id
END

----------------
--   DELETE  ---
----------------
/*CREATE PROCEDURE spBorrarSilabo
	@id INT,
	@nombre VARCHAR(50) ,
	@sigla VARCHAR(5),
	@turno INT

AS
BEGIN
	UPDATE Silabos SET nombre = @nombre, sigla = @sigla ,turno = @turno WHERE id = @id
END*/

