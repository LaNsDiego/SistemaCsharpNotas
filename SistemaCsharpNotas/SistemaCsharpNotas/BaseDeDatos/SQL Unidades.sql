-------------------------------
--   CREATE TABLE  ------------
-------------------------------
CREATE TABLE Unidades (
	id INT IDENTITY  PRIMARY KEY ,
	nombre VARCHAR(100) NOT NULL,
	codigo VARCHAR(15) NOT NULL,
	unidad_id VARCHAR(5) NOT NULL
);


----------------
--   CREATE  ---
----------------
CREATE PROCEDURE spCrearUnidad
	@nombre VARCHAR(50),
	@	codigo VARCHAR(15) ,
	@unidad_id INT 
AS
BEGIN
	INSERT INTO Unidad (nombre,codigo,unidad_id) VALUES(@nombre,@codigo,@unidad_id)
END

----------------
--   READ  -----
----------------
CREATE PROCEDURE spObtenerUnidad
	@id INT
AS
BEGIN
	SELECT id,nombre,codigo,unidad_id FROM Unidad WHERE id = @id
END


----------------
--  READ ALL ---
----------------
CREATE PROCEDURE spListarUnidad
AS
BEGIN
	SELECT id,nombre,codigo,unidad_id FROM Unidad
END

----------------
--   UPDATE  ---
----------------
CREATE PROCEDURE spActualizarUnidad
	@id INT,
	@nombre VARCHAR(50),
	@codigo VARCHAR(15) ,
	@unidad_id INT 

AS
BEGIN
	UPDATE Unidad SET nombre = @nombre, codigo = @codigo ,unidad_id = @unidad_id WHERE id = @id
END


----------------
--   DELETE  ---
----------------