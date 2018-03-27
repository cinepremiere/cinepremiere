create database DB_CinePremier
go
use DB_CinePremier
go
set dateformat 'dmy'
go
create table TipoUsuario
(
	claveTipoUsuario smallint primary key,
	tipoUsuario nvarchar(25) not null,--1 = Adminstrador, 2 = Gerente, 3 = Supervisor de Cajas, 4 = Cajero, 5 = TEST/ROOT
)
go
create table Usuarios
(
	claveUsuario nvarchar(5) primary key,
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
go
create table Idioma
(
	claveIdioma smallint primary key,
	idioma char(15) not null,
	status bit not null,
)
go
create table Subtitulos
(
	claveSubtitulos smallint primary key,
	subtitulos char(15) not null,
	status bit not null,
)
go
create table TipoFuncion
(
	claveTipoFuncion smallint primary key,
	tipoFuncion char(15) not null,--regular, premier, especial,vip...
	precio money not null,
	descripcion char(15) not null,--2d,3d,4dx,matine
	status bit not null,
)
go
create table Checador
(
	claveUsuario nvarchar(5) references Usuarios(claveUsuario) not null,
	horaIngreso date not null,
	horaSalidaComida date not null,
	horaregresoComida date not null,
	horasalida date not null,
)
go
create table TipoCliente
(
	claveTipoCliente int primary key,
	tipoCliente char(15) not null,
	status bit not null,
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
	puntos int null,
	status bit not null,
	tipoCliente int references TipoCliente(claveTipoCliente) not null,
)
go
create table TipoSala
(
	claveTipoSala smallint primary key,
	capacidad smallint not null,
	descripcion nvarchar(50),
	status bit not null,
)
go
create table Salas
(
	claveSala char(5) primary key,
	claveTipoSala smallint references TipoSala(claveTipoSala),
	status bit not null,
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
	disponible bit not null,
)
go
create table Funciones
(
	claveFuncion nvarchar(5) primary key,
	claveSala char (5) references Salas(claveSala) not null,
	clavePelicula nvarchar (5) references Peliculas (clavePelicula) not null,
	claveTipoFuncion smallint references TipoFuncion(claveTipoFuncion),
	claveIdioma smallint references Idioma(claveIdioma),
	claveSubtitulos smallint references Subtitulos(claveSubtitulos),
	fecha date not null,
	hora time not null,
	disponible bit not null,
	lugaresLibres smallint not null,
)
go
create table Boletos
(
	boleto nvarchar(5) primary key,
	claveFuncion nvarchar (5) references Funciones (claveFuncion) not null,
	asiento nvarchar(3) not null,
	fila char(3) not null,
	tipoCliente bit not null,
	fechaHoraImpresion date not null,
)
go
create table DetallesVentas
 (
	claveDetalleVenta nvarchar(5) primary key,
	boleto nvarchar(5) references Boletos(boleto) not null,
	descuento money,
	iva money,
	precioUnitario money not null,
	importeParcial money not null,
 )
 go
create table Ventas
(
	claveVenta int primary key,
	claveDetalleVenta nvarchar(5) references DetallesVentas(claveDetalleVenta),
	claveCliente nvarchar(5) references Clientes(claveCliente) null,
	claveUsuario nvarchar(5) references Usuarios(claveUsuario) not null,
	fechaVenta date not null,
	horaVenta time not null,
	importeTotal money not null,
 )
 go
 
