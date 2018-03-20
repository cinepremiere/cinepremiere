create database DB_OperacionesCinepremium_2
go
use DB_OperacionesCinepremium_2
go
set dateformat 'dmy'
go
create table Usuarios
(
	claveUsuario nvarchar(5) primary key,
	primerNombre nvarchar(20) not null,
	segundoNombre nvarchar(20) null,
	paterno nvarchar(25) not null,
	materno nvarchar(25) not null,--
	tipoUsuario smallint not null,--1 = Adminstrador, 2 = Gerente, 3 = Supervisor de Cajas, 4 = Cajero, 5 = TEST/ROOT
	calle nvarchar(25) not null,
	numeroExterior nvarchar(5) not null,
	numeroInterior nvarchar (5) null,
	cp nvarchar (5) not null,
	colonia nvarchar (30) not null,
	localidad nvarchar (30) not null,
	telefonoCasa nvarchar (16) null,
	telefonoMovil nvarchar (16) not null,
	inicioContrato date not null,
	turno smallint not null,
	mail nvarchar(50) not null,
	suledo money not null,
	constrasena nvarchar (10) not null
)
go
create table Idioma
(
	idIdioma smallint primary key,
	idioma char(5) not null,
	subtitulos char(5) not null
)

create table Tipo
(
	idTipo smallint primary key,
	tipo char(5) not null
)

create table Checador
(
	claveUsuario nvarchar(5) references Usuarios(claveUsuario),
	horaIngreso date,
	horaSalidaComida date,
	horaregresoComida date,
	horasalida date 
)
go
create table Clientes
(
	claveCliente nvarchar(5) primary key,
	primerNombre nvarchar(20) not null,
	segundoNombre nvarchar(20) null,
	paterno nvarchar(25) not null,
	materno nvarchar(25) not null,
	calle nvarchar(25) not null,
	numeroExterior nvarchar(5) not null,
	numeroInterior nvarchar (5) null,
	cp nvarchar (5) not null,
	colonia nvarchar (30) not null,
	localidad nvarchar (30) not null,
	telefonoCasa nvarchar (16) null,
	telefonoMovil nvarchar (16) not null,
	fechaRegistro date not null,
	mail nvarchar(50) not null,
	constrasena nvarchar (10) not null,
	puntos int null
)
go
create table Salas
(
	claveSala nvarchar(5) primary key,
	capacidad smallint not null,
	tipo nvarchar (30) not null
)
go
create table Peliculas
(
	clavePelicula nvarchar(5) primary key,
	titulo nvarchar(30) not null,
	clasificacion nvarchar(5) not null,
	distribuidor nvarchar(30) not null,
	fechaEstreno date not null,
	fechaRetiro date not null,
	duracion time not null,
	disponible bit not null
)
go
create table Funciones
(
	claveFuncion nvarchar(5) primary key,
	claveSala nvarchar (5) references Salas(claveSala) not null,
	clavePelicula nvarchar (5) references Peliculas (clavePelicula) not null,
	idTipo smallint references Tipo(idTipo),
	idIdioma smallint references Idioma(idIdioma),
	fecha date not null,
	hora time not null,
	idioma nvarchar(20) not null,
	tipo nvarchar(20) not null,
	disponible bit not null,
	lugaresLibres smallint not null,
)
go
create table Boletos
(
	boleto nvarchar(5) primary key,
	claveFuncion nvarchar (5) references Funciones (claveFuncion) not null,
	asiento nvarchar(3) not null,
	tipoCliente bit not null,
	precioUnitario money not null,
)
go
create table Ventas
(
	claveVenta nvarchar(5) primary key,
	claveCliente nvarchar(5) references Clientes(claveCliente) null,
	claveUsuario nvarchar(5) references Usuarios(claveUsuario) not null,
	fechaVenta date not null,
	horaVenta time not null
 )
 go
 create table DetallesVentas
 (
	claveVenta nvarchar(5) references Ventas(claveVenta),
	claveFuncion nvarchar(5) references Funciones(claveFuncion),
	numeroBoleto nvarchar(5) references Boletos(boleto) not null
 )
 go
