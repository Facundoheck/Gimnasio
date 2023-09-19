--create database Gimnasio

--------------------TABLAS Y RELACIONES-------------------------------------------

--create table socios (

--	id_socio		INT IDENTITY (1,1) PRIMARY KEY,
--	nombre			VARCHAR(30),
--	apellido		VARCHAR(30),
--	dni				VARCHAR(15),
--	telefono		VARCHAR(30),
--	correo			VARCHAR(100),
--	direccion		VARCHAR(50),
--	sexo			VARCHAR(30),
--	fecha_nac		DATE,
--	descripcion		VARCHAR(100),
--	nro_cuenta		INT,
--	id_usuario		INT,

--	CONSTRAINT FK_cuenta_socio FOREIGN KEY (nro_cuenta) REFERENCES cta_cte(nro_cuenta),
--	CONSTRAINT FK_usuario_socio FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario)

--);

--create table usuarios (

--	id_usuario		INT IDENTITY (1,1) PRIMARY KEY,
--	usuario			VARCHAR(30),
--	cont			VARCHAR(30),
--	rol				VARCHAR(22),
--	nombre			VARCHAR(30),
--	apellido		VARCHAR(30),
--	dni				VARCHAR(15),
--	telefono		VARCHAR(30),
--	direccion		VARCHAR(100),
--	correo			VARCHAR(50),
--	sexo			VARCHAR(30),
--	fecha_nac		DATE,
--	descripcion		VARCHAR(100),

--);

--create table rutinas (

--	nro_rutina		INT IDENTITY (1,1) PRIMARY KEY,
--	tipo			VARCHAR(30),
--	ejercicio		VARCHAR(100),
--	peso			FLOAT,
--	tiempo			BIGINT

--);
--alter table rutinas add CONSTRAINT FK_socio_rutina FOREIGN KEY (nro_rutina) REFERENCES socios(id_socio)

--create table cta_cte (

--	nro_cuenta		INT IDENTITY (1,1) PRIMARY KEY,
--	importe			FLOAT,
--	fecha			DATE

--);

------------------------------------LLAMADA AL PA PARA NUEVO SOCIO-------------------------------------------

--exec PA_NUEVO_SOCIO 
--		--	id_socio		autom
--		@nombre				=	'Juana',
--		@apellido			=	'de Arco',
--		@dni				=	'35286143',
--		@telefono			=	'5493444542',
--		@correo				=	'jdearco@gmail.com',
--		@direccion			=	'Tucuman bis 123',
--		@sexo				=	'fem',
--		@fecha_nac			=	'1999-12-20',
--		@descripcion		=	'Musculacion'
--		--	nro_cuenta		autom
--		--	id_usuario		autom

------------------------------------LLAMADA AL PA PARA NUEVA CUENTA-------------------------------------------



------------------------------------LLAMADA AL PA PARA NUEVO ADMIN-------------------------------------------
BEGIN TRANSACTION
--exec PA_NUEVO_USUARIO
--		--	id_usuario			autom
--		@usuario			=	'admin',
--		@cont				=	'admin',
--		@rol				=	'Administrador',
--		@nombre				=	'Lionel',
--		@apellido			=	'Messi',
--		@dni				=	'35286143',
--		@telefono			=	'5493444542',
--		@direccion			=	'Tucuman bis 123',
--		@correo				=	'lmessi@gmail.com',
--		@sexo				=	'masc',
--		@fecha_nac			=	'1999-12-20',
--		@descripcion		=	'dueño del gimnasio'
--		--	id_socio		autom


SELECT * FROM USUARIOS
SELECT * FROM SOCIOS WHERE descripcion= 'el demonio' 

BEGIN TRANSACTION
UPDATE usuarios SET usuario= 'administrador' , cont= 'administrador' WHERE id_usuario= '2' 

--COMMIT
--ROLLBACK


select * from usuarios