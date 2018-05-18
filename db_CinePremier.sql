--drop database DB_CinePremier
create database DB_CinePremier
go
use DB_CinePremier
go
set dateformat 'dmy'
go

create table Salario
(
	claveSalario int primary key identity(1,1),
	salario decimal(10,2) not null,
	descripcion nvarchar(25) not null,
	disponible bit not null,
)
alter table Salario
add constraint col_disp6 default 1 for disponible
go
create table TipoUsuario
(
	claveTipoUsuario smallint primary key identity(1, 1),
	tipoUsuario nvarchar(25) not null,--1 = Adminstrador, 2 = Gerente, 3 = Supervisor de Cajas, 4 = Cajero, 5 = TEST/ROOT
	disponible bit not null,
)
ALTER TABLE TipoUsuario
ADD CONSTRAINT col_stat1 DEFAULT 1 FOR disponible
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
	claveSalario int references Salario(claveSalario) not null,
	contrasena nvarchar (10) not null,
	disponible bit not null,
)
ALTER TABLE Usuarios
ADD CONSTRAINT col_stat2 DEFAULT 1 FOR disponible,
constraint col_materno1 default '' for materno,
constraint col_numInt1 default '' for numeroInterior
go
create table Idioma
(
	claveIdioma smallint primary key identity(1, 1),
	idioma char(15) not null unique,
	disponible bit not null,
)
ALTER TABLE Idioma
ADD CONSTRAINT col_stat3 DEFAULT 1 FOR disponible
go

create table Subtitulos
(
	claveSubtitulos smallint primary key identity(1, 1),
	subtitulos char(15) not null unique,
	disponible bit not null,
)
ALTER TABLE Subtitulos
ADD CONSTRAINT col_stat4 DEFAULT 1 FOR disponible
go
create table ListaDePrecios
(
	claveListaDePrecios int primary key identity(1,1),
	precio decimal(10,2) not null,
	descripcion nvarchar(25) not null,
	disponible bit not null,
)
alter table ListaDePrecios
add constraint col_disp5 default 1 for disponible
go
create table TipoFuncion
(
	claveTipoFuncion smallint primary key identity(1, 1),
	tipoFuncion char(10) not null unique,--2DR, 3DR, 4DX, IMAX2D, IMAX3D, 3DVIP, 2DVIP, RV
	claveListaDePrecios int references ListaDePrecios(claveListaDePrecios) not null,
	descripcion char(25) null,
	disponible bit not null,
)
ALTER TABLE TipoFuncion
ADD CONSTRAINT col_stat5 DEFAULT 1 FOR disponible
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
	claveListaDePrecios int references ListaDePrecios(claveListaDePrecios) not null,
	disponible bit not null,
)
ALTER TABLE TipoCliente
ADD CONSTRAINT col_stat6 DEFAULT 1 FOR disponible
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
	contrasena nvarchar (10) not null,
	puntos int not null,
	disponible bit not null,
	tipoCliente smallint references TipoCliente(claveTipoCliente) not null,
	puntosUsados int not null,
)
ALTER TABLE Clientes
ADD CONSTRAINT col_stat7 DEFAULT 1 FOR disponible,
CONSTRAINT col_puntos DEFAULT 0 FOR puntos,
CONSTRAINT col_puntosUsados DEFAULT 0 FOR puntosUsados,
CONSTRAINT col_tipoCliente DEFAULT 1 FOR tipoCliente,
constraint col_materno default '' for materno,
constraint col_numInt default '' for numeroInterior
go
create table TipoSala
(
	claveTipoSala smallint primary key identity(1, 1),
	capacidad smallint not null unique,
	descripcion nvarchar(50) null,
	disponible bit not null,
)
ALTER TABLE TipoSala
ADD CONSTRAINT col_stat8 DEFAULT 1 FOR disponible
go
create table Salas
(
	claveSala smallint primary key identity(1, 1),
	claveTipoSala smallint references TipoSala(claveTipoSala) not null,
	disponible bit not null,
)
ALTER TABLE Salas
ADD CONSTRAINT col_stat9 DEFAULT 1 FOR disponible
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
	imgPath nvarchar(50) not null,
)
ALTER TABLE Funciones
ADD CONSTRAINT col_disp2 DEFAULT 1 FOR disponible
go
ALTER TABLE Funciones
Add Constraint clavePelicula Foreign Key (clavePelicula) References Peliculas (claveNombrePelicula)
On Update Cascade On Delete Cascade
go
create table TipoVenta
(
	claveTipoVenta bigint primary key identity(1,1),
	tipoVenta nvarchar(25) not null,
	disponible bit not null
)
ALTER TABLE tipoVenta
ADD CONSTRAINT col_disp3 DEFAULT 1 FOR disponible
go
create table Ventas
(
	claveVenta bigint primary key,
	claveUsuario bigint references Usuarios(claveUsuario) not null,
	claveCliente bigint references Clientes(claveCliente) null,
	horaFechaVenta datetime not null,
	importeTotal decimal(10,2) not null,
)
go
create table Boletos
(
	boleto bigint primary key,
	claveFuncion bigint references Funciones (claveFuncion) not null,
	asiento int not null,
	fila int not null,
	fechaHoraImpresion datetime not null,
	claveVenta bigint references Ventas(claveVenta),
)
go
create table Articulo
(
	claveArticulo nvarchar primary key,
	precio decimal(10,2) not null,
	descripcion nvarchar null,
	disponible bit not null,
)
ALTER TABLE Articulo
ADD CONSTRAINT col_disp4 DEFAULT 1 FOR disponible
go
create table DetallesVentas
(
	claveVenta bigint references Ventas(claveVenta) not null,
	boleto bigint references Boletos(boleto) null,
	claveTipoVenta bigint references TipoVenta(claveTipoVenta) not null,
	claveArticulo nvarchar references Articulo(claveArticulo) null,
	descuento decimal(10,2) not null,
	iva decimal(10,2) not null,
	precioUnitario decimal(10,2) not null,
	importeParcial decimal(10,2) not null,
	fechaHoraRegistro datetime not null,
	sumaPuntos bit not null,--para clientes con membresía
	fechaPuntosUsados date null,
 )
ALTER TABLE DetallesVentas
ADD 
CONSTRAINT col_sumaPuntos DEFAULT 0 FOR sumaPuntos,
CONSTRAINT col_desc DEFAULT 0 FOR descuento,
CONSTRAINT col_iva DEFAULT 0 FOR iva
go
create table Cancelados
(
	claveVenta bigint references Ventas(claveVenta) not null,
	boleto bigint references Boletos(boleto) null,
	fechaHoraCancelado datetime not null,
	motivo nvarchar(100) not null,
	claveUsuario bigint references Usuarios(claveUsuario) not null,
	contrasena nvarchar (10) not null,
)

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
create index i16 on TipoVenta(claveTipoVenta);
create index i17 on Articulo(claveArticulo);
create index i18 on Cancelados(claveVenta);
create index i19 on ListaDePrecios(claveListaDePrecios);
create index i20 on Salario(claveSalario)
go

create schema SCH_Ventas
go
create sequence SCH_Ventas.AI_Ventas
as bigint
start with 1
increment by 1
MINVALUE 1
NO CACHE
go

create schema SCH_Boletos
go
create sequence SCH_Boletos.AI_Boletos
as bigint
start with 1
increment by 1
MINVALUE 1
NO CACHE
go

create schema SCH_Funciones
go
create sequence SCH_Funciones.AI_Funciones
as bigint
start with 1
increment by 1
MINVALUE 1
NO CACHE
go

--Inserts
--select * from salario
insert into Salario(salario,descripcion)
values(4575,'Empleado de S'),
(5000.00,'Mantenimiento'),
(6500.00,'Cajero'),
(3590.00,'Recepcionista'),
(12000.00,'Supervisor'),
(15000.00,'Gerente'),
(8000.00,'Soporte Técnico')

--select * from listadeprecios
insert into ListaDePrecios(precio,descripcion)
values
(55,'Fun 2dR'),
(65,'Fun 2dImax'),
(75,'Fun 3dR'),
(85,'Fun 3dImax'),
(130,'Fun 2dVIP'),
(150,'Fun 3dVIP'),
(165,'Fun 4DX'),
(70,'Fun JR'),
(200,'Fun VR'),
(50,'Mem Preferente'),
(100,'Mem Premier'),
(150,'Mem VIP'),
(0,'IVA')

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
claveSalario,contrasena)
values
('POSC90112254A3HXDF','Carlos','Ponce de León','Sámano',3,'María','22','','08030','Camarón','Ciudad de México','',
'5512462517',getdate(),'09:00','19:00','carlossamano@gmail.com',1,'123456'),
('ALCE93112254A3HXDF','Eduardo','Alvarado','Cortés',2,'Aldama','15','','08030','Centro','Ciudad de México','',
'5512461039',getdate(),'09:00','19:00','alvarado@gmail.com',4,'123456'),
('LAMN83112254A3HXDF','Noé Carlos','Lara','Martínez',1,'Violeta','85','I-3','08030','Buenavista','Ciudad de México','',
'5512462219',getdate(),'09:00','19:00','noelaramartinez@gmail.com',5,'123456')

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
insert into TipoFuncion(tipoFuncion,claveListaDePrecios,descripcion,disponible)
values('2DR',1,'2D REGULAR',1),
('3DR',2,'3D REGULAR',1),
('4DX',3,'4D',1),
('2DI',4,'2D IMAX',1),
('3DI',5,'3D IMAX',1),
('3DVIP',6,'3D VIP',1),
('2DVIP',7,'2D VIP',1),
('Jr',8,'Sala Junior',1),
('RV',9,'REALIDAD VIRTUAL',1)


--select * from tipocliente
insert into TipoCliente(tipoCliente,claveListaDePrecios,disponible)
values
('PREFERENTE',1,1),
('PREMIER',2,1),
('VIP',3,1)


--select * from Clientes
insert into Clientes(nombres,curp,paterno,materno,calle,numeroExterior,numeroInterior,cp,colonia,localidad
,telefonoCasa,telefonoMovil,fechaRegistro,mail,contrasena,puntos,disponible,tipoCliente)
values('Lizzete','VEML90112254A3HXDF','Vega','Martinez','Calle 1','23','','08020','Juarez','Ciudad de México','','5512345609',
GETDATE(),'lizz@gmail.com','123456',1,1,1),
('Karina','YEMK90112254A3HXDF','Yerian','Martinez','Calle 5','13','','08010','Yerian','Ciudad de México','','5512345611',
GETDATE(),'yeris@gmail.com','123456',0,2,2),
('Aldo','MAMA90112254A3HXDF','Martinez','Martinez','Calle 20','63','','08015','Doctores','Ciudad de México','','5512345821',
GETDATE(),'aldo@gmail.com','123456',0,3,3)

--select * from TipoSala
insert into TipoSala(capacidad,descripcion,disponible)
values(20,'ESPECIAL',1),
(50,'STANDAR',1)

--select * from Salas
insert into Salas(claveTipoSala,disponible)
values
(1,1),
(1,1),
(1,1),
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
(upper('Titanes del Pacífico: La Resurrección'), 'B-15', 'UNIVERSAL', GETDATE(), GETDATE()+15, '01:51',1),
(upper('Jumanji'), 'B-15', 'UNIVERSAL', GETDATE(), GETDATE()+15, '01:43',1),
(upper('Black Panther'), 'B-15', 'DISNEY', GETDATE(), GETDATE()+15, '01:35',1),
(upper('Mazinger Z'), 'B-15', 'BANDAI', GETDATE(), GETDATE()+15, '01:20',1),
(upper('Las Aventuras de Lara Croft'), 'B-15', 'UNIVERSAL', GETDATE(), GETDATE()+15, '01:40',1)

--select * from Funciones
insert into Funciones(claveSala,clavePelicula,claveTipoFuncion,claveIdioma,claveSubtitulos,fecha,hora,disponible
,imgPath)
--titanes del pacifico español
values(3,upper('Titanes del Pacífico: La Resurrección'),1,1,6,'2018/04/16','11:00',1,'titanes.jpg'),
(3,upper('Titanes del Pacífico: La Resurrección'),1,1,6,'2018/04/16','13:30',1,'titanes.jpg'),
(3,upper('Titanes del Pacífico: La Resurrección'),1,1,6,'2018/04/16','16:00',1,'titanes.jpg'),
(3,upper('Titanes del Pacífico: La Resurrección'),1,1,6,'2018/04/16','18:30',1,'titanes.jpg'),
(3,upper('Titanes del Pacífico: La Resurrección'),1,1,6,'2018/04/16','21:00',1,'titanes.jpg'),
--Jumanji subtitulos esp imax
(4,upper('Jumanji'),4,2,1,'2018/04/16','15:00',1,'jumanji.jpg'),
(4,upper('Jumanji'),4,2,1,'2018/04/16','17:15',1,'jumanji.jpg'),
(4,upper('Jumanji'),4,2,1,'2018/04/16','19:30',1,'jumanji.jpg'),
(4,upper('Jumanji'),4,2,1,'2018/04/16','21:45',1,'jumanji.jpg'),
--Black Panther 3d imax ingles
(1,upper('Black Panther'),2,2,1,'2018/04/16','17:00',1,'blackpanther.jpg'),
(1,upper('Black Panther'),2,2,1,'2018/04/16','18:50',1,'blackpanther.jpg'),
(1,upper('Black Panther'),2,2,1,'2018/04/16','20:40',1,'blackpanther.jpg'),
(1,upper('Black Panther'),2,2,1,'2018/04/16','22:30',1,'blackpanther.jpg')

--select * from tipoVenta
insert into TipoVenta(tipoVenta)
values
('Boleto'),
('Membresia'),
('Tarjeta de Descuento'),
('Dulceria'),
('Articulo')

--select * from Ventas
insert into ventas(claveVenta,claveCliente,claveUsuario,horaFechaVenta,importeTotal)
values
(NEXT VALUE FOR SCH_Ventas.AI_Ventas,NULL,1,CONVERT(datetime, GETDATE(),103),85),
(NEXT VALUE FOR SCH_Ventas.AI_Ventas,NULL,1,CONVERT(datetime, GETDATE(),103),85),
(NEXT VALUE FOR SCH_Ventas.AI_Ventas,NULL,1,CONVERT(datetime, GETDATE(),103),85),
(NEXT VALUE FOR SCH_Ventas.AI_Ventas,NULL,1,CONVERT(datetime, GETDATE(),103),170)

--select * from boletos
insert into Boletos(boleto,claveFuncion,asiento,fila,fechaHoraImpresion,claveVenta)
values
(NEXT VALUE FOR SCH_Boletos.AI_Boletos,3,1,1,CONVERT(datetime, GETDATE(),103),1),
(NEXT VALUE FOR SCH_Boletos.AI_Boletos,4,2,3,CONVERT(datetime, GETDATE(),103),2),
(NEXT VALUE FOR SCH_Boletos.AI_Boletos,5,2,2,CONVERT(datetime, GETDATE(),103),3),
(NEXT VALUE FOR SCH_Boletos.AI_Boletos,6,8,4,CONVERT(datetime, GETDATE(),103),4),
(NEXT VALUE FOR SCH_Boletos.AI_Boletos,6,9,4,CONVERT(datetime, GETDATE(),103),4)

--select * from DetallesVentas
insert into DetallesVentas(claveVenta,boleto,claveTipoVenta,
descuento,iva,precioUnitario,importeParcial,fechaHoraRegistro)
values
(1,1,1,0,0,85,85,CONVERT(datetime, GETDATE(),103)),
(2,2,1,0,0,85,85,CONVERT(datetime, GETDATE(),103)),
(3,3,1,0,0,85,85,CONVERT(datetime, GETDATE(),103)),
(4,4,1,0,0,85,85,CONVERT(datetime, GETDATE(),103)),
(4,5,2,0,0,85,85,CONVERT(datetime, GETDATE(),103))