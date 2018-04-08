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
	Nombres nvarchar(50) not null,
	paterno nvarchar(25) not null,
	materno nvarchar(25) not null,
	claveTipoUsuario smallint references TipoUsuario(claveTipoUsuario) not null,
	calle nvarchar(25) not null,
	numeroExterior nvarchar(5) not null,
	numeroInterior nvarchar (5) not null,
	cp nvarchar (5) not null,
	colonia nvarchar (30) not null,
	localidad nvarchar (30) not null,
	telefonoCasa nvarchar (16) null,
	telefonoMovil nvarchar (16) not null unique,
	inicioContrato date not null,
	inicioTurno time not null,
	finTurno time not null,
	mail nvarchar(50) not null unique,
	suledo money not null,
	constrasena nvarchar (10) not null,
	status bit not null,
)
ALTER TABLE Usuarios
ADD CONSTRAINT col_stat2 DEFAULT 1 FOR status,
constraint col_materno1 default '' for materno,
constraint col_numInt1 default '' for numeroInterior
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
	tipoFuncion char(10) not null unique,--2DR, 3DR, 4DX, IMAX2D, IMAX3D, 3DVIP, 2DVIP, RV
	precio money not null,
	descripcion char(25) null,
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
	costo money not null,
	status bit not null,
)
ALTER TABLE TipoCliente
ADD CONSTRAINT col_stat6 DEFAULT 1 FOR status
go
create table Clientes
(
	claveCliente bigint primary key identity(1, 1),
	Nombres nvarchar(50) not null,
	curp char(18) not null unique,
	paterno nvarchar(25) not null,
	materno nvarchar(25) not null,
	calle nvarchar(25) not null,
	numeroExterior nvarchar(5) not null,
	numeroInterior nvarchar (5) not null,
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
ADD CONSTRAINT col_stat7 DEFAULT 1 FOR status,
CONSTRAINT col_puntos DEFAULT 0 FOR puntos,
CONSTRAINT col_tipoCliente DEFAULT 1 FOR tipoCliente,
constraint col_materno default '' for materno,
constraint col_numInt default '' for numeroInterior
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

create index i1 on peliculas(indice);
create index i2 on tipoUsuario(claveTipoUsuario);
create index i3 on Usuarios(claveUsuario);
create index i4 on Idioma(claveIdioma);
create index i5 on Subtitulos(claveSubtitulos);
create index i6 on TipoFuncion(claveTipoFuncion);
create index i7 on Checador(claveUsuario);
create index i8 on TipoCliente(claveTipoCliente);
create index i9 on Clientes(claveCliente);
create index i10 on TipoSala(claveTipoSala);
create index i11 on Salas(claveSala);
create index i12 on Funciones(claveFuncion);
create index i13 on Boletos(boleto);
create index i14 on Ventas(claveVenta);
create index i15 on DetallesVentas(claveVenta);




--Inserts
--select * from TipoUsuario
insert into TipoUsuario(tipoUsuario)
values('Gerente'),
('Supervisor'),
('Cajero'),
('DBA'),
('Tester')

--select * from Usuarios
insert into Usuarios(curp,Nombres,paterno,materno,claveTipoUsuario,calle,numeroExterior,numeroInterior
,cp,colonia,localidad,telefonoCasa,telefonoMovil,inicioContrato,inicioTurno,finTurno,mail,
suledo,constrasena)
values
('POSC90112254A3HXDF','Carlos','Ponce de León','Sámano',3,'María','22','','08030','Camarón','Ciudad de México','',
'5512462517',getdate(),'09:00','19:00','carlossamano@gmail.com',20000.0000,'123456'),
('ALCE93112254A3HXDF','Eduardo','Alvarado','Cortés',2,'Aldama','15','','08030','Centro','Ciudad de México','',
'5512461039',getdate(),'09:00','19:00','alvarado@gmail.com',22000.0000,'123456'),
('LAMN83112254A3HXDF','Noé Carlos','Lara','Martínez',1,'Violeta','85','I-3','08030','Buenavista','Ciudad de México','',
'5512462219',getdate(),'09:00','19:00','noelaramartinez@gmail.com',25000.0000,'123456')

--select * from Idioma
insert into Idioma(idioma)
values('Español'),
('Ingles'),
('Japonés'),
('Alemán'),
('Francés')

--select * from Subtitulos
insert into Subtitulos(subtitulos)
values
('Español'),
('Inglés'),
('Francés'),
('Japonés'),
('Alemán'),
('N/A')

--select * from TipoFuncion
insert into TipoFuncion(tipoFuncion,precio,descripcion,status)
values('2DR',65.0000,'2D REGULAR',1),
('3DR',85.0000,'3D REGULAR',1),
('4DX',100.0000,'4D',1),
('2DI',90.0000,'2D IMAX',1),
('3DI',110.0000,'3D IMAX',1),
('3DVIP',130.0000,'3D VIP',1),
('2DVIP',115.0000,'2D VIP',1),
('Jr',60.0000,'Sala Junior',1),
('RV',150.0000,'REALIDAD VIRTUAL',1)

--select * from tipocliente
insert into TipoCliente(tipoCliente,costo,status)
values
('PREFERENTE',100,1),
('PREMIER',150,1),
('VIP',200,1)


--select * from Clientes
insert into Clientes(nombres,curp,paterno,materno,calle,numeroExterior,numeroInterior,cp,colonia,localidad
,telefonoCasa,telefonoMovil,fechaRegistro,mail,constrasena,puntos,status,tipoCliente)
values('Lizzete','VEML90112254A3HXDF','Vega','Martinez','Calle 1','23','','08020','Juarez','Ciudad de México','','5512345609',
GETDATE(),'lizz@gmail.com','123456',0,1,1),
('Karina','YEMK90112254A3HXDF','Yerian','Martinez','Calle 5','13','','08010','Yerian','Ciudad de México','','5512345611',
GETDATE(),'yeris@gmail.com','123456',0,2,2),
('Aldo','MAMA90112254A3HXDF','Martinez','Martinez','Calle 20','63','','08015','Doctores','Ciudad de México','','5512345821',
GETDATE(),'aldo@gmail.com','123456',0,3,3)

--select * from TipoSala
insert into TipoSala(capacidad,descripcion,status)
values(20,'ESPECIAL',1),
(50,'STANDAR',1)

--select * from Salas
insert into Salas(claveTipoSala,status)
values(1,1),
(1,1),
(2,1),
(2,1),
(2,1),
(2,1),
(2,1),
(2,1),
(2,1),
(2,1)

--select * from Peliculas
insert into Peliculas(claveNombrePelicula,clasificacion,distribuidor,fechaEstreno,fechaRetiro,
duracion, disponible)
values
(upper('Titanes del Pacífico: La Resurrección'), 'B', 'Universal', GETDATE(), GETDATE()+15, '01:51',1),
(upper('Jumanji'), 'B', 'Universal', GETDATE(), GETDATE()+15, '01:43',1),
(upper('Black Panther'), 'B', 'Disney', GETDATE(), GETDATE()+15, '01:35',1),
(upper('Mazinger Z'), 'B', 'Bandai', GETDATE(), GETDATE()+15, '01:20',1),
(upper('Las Aventuras de Lara Croft'), 'B', 'Universal', GETDATE(), GETDATE()+15, '01:40',1)

--select * from Funciones
insert into Funciones(claveSala,clavePelicula,claveTipoFuncion,claveIdioma,claveSubtitulos,fecha,hora,disponible
,imgPath)
--titanes del pacifico español
values(3,upper('Titanes del Pacífico: La Resurrección'),1,1,6,'2018/04/16','11:00',1,'titanes.png'),
(3,upper('Titanes del Pacífico: La Resurrección'),1,1,6,'2018/04/16','13:30',1,'titanes.png'),
(3,upper('Titanes del Pacífico: La Resurrección'),1,1,6,'2018/04/16','16:00',1,'titanes.png'),
(3,upper('Titanes del Pacífico: La Resurrección'),1,1,6,'2018/04/16','18:30',1,'titanes.png'),
(3,upper('Titanes del Pacífico: La Resurrección'),1,1,6,'2018/04/16','21:00',1,'titanes.png'),
--Jumanji subtitulos esp imax
(4,upper('Jumanji'),4,2,1,'2018/04/16','15:00',1,'jumanji.png'),
(4,upper('Jumanji'),4,2,1,'2018/04/16','17:15',1,'jumanji.png'),
(4,upper('Jumanji'),4,2,1,'2018/04/16','19:30',1,'jumanji.png'),
(4,upper('Jumanji'),4,2,1,'2018/04/16','21:45',1,'jumanji.png'),
--Black Panther 3d imax ingles
(1,upper('Black Panther'),2,2,1,'2018/04/16','17:00',1,'blackpanther.png'),
(1,upper('Black Panther'),2,2,1,'2018/04/16','18:50',1,'blackpanther.png'),
(1,upper('Black Panther'),2,2,1,'2018/04/16','20:40',1,'blackpanther.png'),
(1,upper('Black Panther'),2,2,1,'2018/04/16','22:30',1,'blackpanther.png')

--select * from boletos
insert into Boletos(claveFuncion,asiento,fila,fechaHoraImpresion)
values(3,'12','A',GETDATE()),
(3,'7','B',GETDATE()),
(4,'9','D',GETDATE()),
(5,'2','C',GETDATE()),
(6,'7','B',GETDATE()),
(6,'9','D',GETDATE()),
(8,'2','C',GETDATE()),
(3,'1','B',GETDATE()),
(4,'2','D',GETDATE()),
(5,'3','C',GETDATE())

--select * from Ventas
insert into ventas(claveCliente,claveUsuario,fechaVenta,horaVenta,importeTotal)
values(NULL,1,GETDATE(),'12:00',375),
(1,1,GETDATE(),'12:00',500),
(2,1,GETDATE(),'12:00',150)

--select * from DetallesVentas
insert into DetallesVentas(claveVenta,boleto,descuento,iva,precioUnitario,importeParcial)
values(2,2,0,0,125,125),
(2,2,0,0,125,125),
(2,2,0,0,125,125)