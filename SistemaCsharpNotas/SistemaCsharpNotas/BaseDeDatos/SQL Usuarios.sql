-------------------------------
--   CREATE TABLE  ------------
-------------------------------
CREATE TABLE Usuarios (
	id INT IDENTITY  PRIMARY KEY ,
	codigo CHAR(10) UNIQUE NOT NULL,
	clave VARCHAR(50) NOT NULL,
	nivel INT NOT NULL CHECK(nivel IN(1,2,3)),
	activo INT NOT NULL CHECK(activo IN(0,1))
);


----------------
--   CREATE  ---
----------------
CREATE PROCEDURE spCrearUsuario
	@codigo CHAR(10) ,
	@clave VARCHAR(50),
	@nivel INT,
	@activo INT

AS
BEGIN
	INSERT INTO Usuarios (codigo,clave,nivel,activo) VALUES(@codigo,@clave,@nivel,@activo)
END


----------------
--  READ ALL ---
----------------
CREATE PROCEDURE spListarUsuario
AS
	BEGIN
		SELECT id,codigo,clave,nivel,activo FROM Usuarios
END

----------------
--   READ  -----
----------------
CREATE PROCEDURE spObtenerUsuario
	@id INT
AS
	BEGIN
		SELECT id,codigo,clave,nivel,activo FROM Usuarios WHERE id=@id
END

----------------
--   UPDATE  ---
----------------
CREATE PROCEDURE spActualizarUsuario
	@id INT,
	@codigo CHAR(10) ,
	@clave VARCHAR(50),
	@nivel INT,
	@activo INT
AS
BEGIN
	UPDATE Usuarios 
	SET codigo	=	@codigo,
			clave		=	@clave,
			nivel		=	@nivel,
			activo	=	@activo 
	WHERE id = @id
END

----------------
--   DELETE  ---
----------------