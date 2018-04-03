--drop database DB_CinePremier
create database DB_CinePremier
go
use DB_CinePremier
go
set dateformat 'dmy'
go
create table TipoUsuario
(
	claveTipoUsuario smallint primary key identity(1, 1),
	tipoUsuario nvarchar(25) not null,--1 = Adminstrador, 2 = Gerente, 3 = Supervisor de Cajas, 4 = Cajero, 5 = TEST/ROOT
	status bit not null,
)
ALTER TABLE TipoUsuario
ADD CONSTRAINT col_stat1 DEFAULT 1 FOR status
go
create table Usuarios
(
	claveUsuario bigint primary key identity(1, 1),
	curp char(18) not null unique,
	primerNombre nvarchar(20) not null,
	segundoNombre nvarchar(20) null,
	paterno nvarchar(25) not null,
	materno nvarchar(25) not null,--
	claveTipoUsuario smallint references TipoUsuario(claveTipoUsuario) not null,
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
	constrasena nvarchar (10) not null,
	status bit not null,
)
ALTER TABLE Usuarios
ADD CONSTRAINT col_stat2 DEFAULT 1 FOR status
go
create table Idioma
(
	claveIdioma smallint primary key identity(1, 1),
	idioma char(15) not null unique,
	status bit not null,
)
ALTER TABLE Idioma
ADD CONSTRAINT col_stat3 DEFAULT 1 FOR status
go

create table Subtitulos
(
	claveSubtitulos smallint primary key identity(1, 1),
	subtitulos char(15) not null unique,
	status bit not null,
)
ALTER TABLE Subtitulos
ADD CONSTRAINT col_stat4 DEFAULT 1 FOR status
go
create table TipoFuncion
(
	claveTipoFuncion smallint primary key identity(1, 1),
	tipoFuncion char(15) not null unique,--2DR, 3DR, 4DX, IMAX2D, IMAX3D, 3DVIP, 2DVIP, RV
	precio money not null,
	descripcion char(15) null,
	status bit not null,
)
ALTER TABLE TipoFuncion
ADD CONSTRAINT col_stat5 DEFAULT 1 FOR status
go
create table Checador
(
	claveUsuario bigint references Usuarios(claveUsuario) not null,
	horaIngreso date not null,
	horaSalidaComida date null,
	horaregresoComida date null,
	horasalida date null,
)
go
create table TipoCliente
(
	claveTipoCliente smallint primary key identity(1, 1),
	tipoCliente char(15) not null unique,--preferente, vip, premier
	status bit not null,
)
ALTER TABLE TipoCliente
ADD CONSTRAINT col_stat6 DEFAULT 1 FOR status
go
create table Clientes
(
	claveCliente bigint primary key identity(1, 1),
	primerNombre nvarchar(20) not null,
	segundoNombre nvarchar(20) null,
	curp char(18) not null unique,
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
	puntos int null,
	status bit not null,
	tipoCliente smallint references TipoCliente(claveTipoCliente) not null,
)
ALTER TABLE Clientes
ADD CONSTRAINT col_stat7 DEFAULT 1 FOR status
go
create table TipoSala
(
	claveTipoSala smallint primary key identity(1, 1),
	capacidad smallint not null unique,
	descripcion nvarchar(50) null,
	status bit not null,
)
ALTER TABLE TipoSala
ADD CONSTRAINT col_stat8 DEFAULT 1 FOR status
go
create table Salas
(
	claveSala smallint primary key identity(1, 1),
	claveTipoSala smallint references TipoSala(claveTipoSala) not null,
	status bit not null,
)
ALTER TABLE Salas
ADD CONSTRAINT col_stat9 DEFAULT 1 FOR status
go
create table Peliculas
(
	claveNombrePelicula char(100) primary key,
	clasificacion char(15) not null,
	distribuidor nvarchar(30) not null,
	fechaEstreno date not null,
	fechaRetiro date not null,
	duracion time not null,
	disponible bit not null,
	indice bigint not null unique identity(1,1),
)
ALTER TABLE Peliculas
ADD CONSTRAINT col_disp1 DEFAULT 1 FOR disponible
go
create table Funciones
(
	claveFuncion bigint primary key identity(1, 1),
	claveSala smallint references Salas(claveSala) not null,
	clavePelicula char(100) references Peliculas (claveNombrePelicula) not null,
	claveTipoFuncion smallint references TipoFuncion(claveTipoFuncion) not null,
	claveIdioma smallint references Idioma(claveIdioma) not null,
	claveSubtitulos smallint references Subtitulos(claveSubtitulos) not null,
	fecha date not null,
	hora time not null,
	disponible bit not null,
	imgPath varchar(50) not null,
)
ALTER TABLE Funciones
ADD CONSTRAINT col_disp2 DEFAULT 1 FOR disponible
go
create table Boletos
(
	boleto bigint primary key identity(1, 1),
	claveFuncion bigint references Funciones (claveFuncion) not null,
	asiento nvarchar(3) not null,
	fila char(3) not null,
	tipoCliente bit not null,
	fechaHoraImpresion date not null,
)
go
create table Ventas
(
	claveVenta bigint primary key identity(1, 1),
	claveCliente bigint references Clientes(claveCliente) null,
	claveUsuario bigint references Usuarios(claveUsuario) not null,
	fechaVenta date not null,
	horaVenta time not null,
	importeTotal money not null,
 )
 go
create table DetallesVentas
 (
	claveVenta bigint references Ventas(claveVenta) not null,
	boleto bigint references Boletos(boleto) not null,
	descuento money not null,
	iva money not null,
	precioUnitario money not null,
	importeParcial money not null,
 )
ALTER TABLE DetallesVentas
ADD CONSTRAINT col_desc DEFAULT 0 FOR descuento,
CONSTRAINT col_iva DEFAULT 0 FOR iva
go

create index i1 on peliculas(indice)