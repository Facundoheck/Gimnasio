---------PA_NUEVO_SOCIO-----------------------------

--CREATE PROCEDURE PA_NUEVO_SOCIO 
--		--	id_socio		autom
--		@nombre				VARCHAR(50),
--		@apellido			VARCHAR(50),
--		@dni				VARCHAR(30),
--		@telefono			VARCHAR(50),
--		@correo				VARCHAR(50),
--		@direccion			VARCHAR(50),
--		@sexo				VARCHAR(30),
--		@fecha_nac			DATE,
--		@descripcion		VARCHAR(100)
--		--	nro_cuenta		autom
--		--	id_usuario		autom


--AS
--BEGIN
--	INSERT INTO socios (

--		--	id_socio		autom
--		nombre			,
--		apellido		,
--		dni				,
--		telefono		,
--		correo			,
--		direccion		,
--		sexo			,
--		fecha_nac		,
--		descripcion		
--		--	nro_cuenta		autom
--		--	id_usuario		autom

--	) VALUES (
	
--		--	id_socio		autom
--		@nombre			,
--		@apellido		,
--		@dni			,
--		@telefono		,
--		@correo			,
--		@direccion		,
--		@sexo			,
--		@fecha_nac		,
--		@descripcion	
--		--	nro_cuenta		autom
--		--	id_usuario		autom
	
--	);

--END 

---------PA_NUEVO_PROFESOR-----------------------------

CREATE PROCEDURE PA_NUEVO_USUARIO
		--	id_usuario			autom
		@usuario			VARCHAR(50),
		@cont				VARCHAR(30),
		@rol				VARCHAR(20),
		@nombre				VARCHAR(50),
		@apellido			VARCHAR(50),
		@dni				VARCHAR(20),
		@telefono			VARCHAR(30),
		@direccion			VARCHAR(50),
		@correo				VARCHAR(50),
		@sexo				VARCHAR(20),
		@fecha_nac			DATE,
		@descripcion		VARCHAR(50)
AS
BEGIN

INSERT INTO USUARIOS (

	--	id_usuario			autom
		usuario		,
		cont			,
		rol			,
		nombre			,
		apellido		,
		dni			,
		telefono		,
		direccion		,
		correo			,
		sexo			,
		fecha_nac		,
		descripcion	

) VALUES (

		--	id_usuario			autom
		@usuario	,
		@cont		,
		@rol		,
		@nombre		,
		@apellido	,
		@dni		,
		@telefono	,
		@direccion	,
		@correo		,
		@sexo		,
		@fecha_nac	,
		@descripcion

);
END