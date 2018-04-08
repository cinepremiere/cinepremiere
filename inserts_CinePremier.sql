use DB_CinePremier

select claveNombrePelicula from peliculas where claveNombrePelicula = ''

select * from Peliculas

DELETE FROM Peliculas
WHERE INDICE = 4

select * from Funciones

alter table funciones
add imgPath varchar(50) not null

--consulta para conversion de minutos a formato hora
declare @minutes int
set @minutes = 121
select convert(char(8), dateadd(MINUTE, @minutes, ''), 114) duracion
---------------------------------------------------------------------------------------

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
(upper('Titanes del Pacífico: La Resurrección'), 'B', 'Universal', GETDATE(), GETDATE()+15, '01:51:00',1),
(upper('Jumanji'), 'B', 'Universal', GETDATE(), GETDATE()+15, '01:43:00',1),
(upper('Black Panther'), 'B', 'Disney', GETDATE(), GETDATE()+15, '01:35:00',1),
(upper('Mazinger Z'), 'B', 'Bandai', GETDATE(), GETDATE()+15, '01:20:00',1),
(upper('Las Aventuras de Lara Croft'), 'B', 'Universal', GETDATE(), GETDATE()+15, '01:40:00',1)

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


-- Find the average fragmentation percentage of all indexes  
-- in the DB_Cinepremier.Peliculas table.   
SELECT a.index_id, name, avg_fragmentation_in_percent  
FROM sys.dm_db_index_physical_stats (DB_ID(N'DB_CinePremier'), 
      OBJECT_ID(N'Peliculas.indice'), NULL, NULL, NULL) AS a  
    JOIN sys.indexes AS b 
      ON a.object_id = b.object_id AND a.index_id = b.index_id;   
GO