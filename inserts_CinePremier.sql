use DB_CinePremier

select claveNombrePelicula from peliculas where claveNombrePelicula = ''

select * from Peliculas

DELETE FROM Peliculas
WHERE INDICE = 4

select * from Funciones

alter table funciones
add imgPath varchar(50) not null

declare @minutes int
set @minutes = 121
select convert(char(8), dateadd(MINUTE, @minutes, ''), 114) duracion
insert into Peliculas(claveNombrePelicula,clasificacion,distribuidor,fechaEstreno,fechaRetiro,
duracion, disponible)
values('PIRATAS DEL CARIBE: LA VENGANZA DE SALAZAR','B-15','FOX','2018/03/30','2018/04/14','01:50:00',1)

insert into Peliculas(claveNombrePelicula,clasificacion,distribuidor,fechaEstreno,fechaRetiro,duracion, disponible)values('LA LEYENDA DEL CHARRO NEGRO','B-15','CORAZÓN','2018/03/30','2018/04/14','01:30:00',1)

select GETDATE()

insert into Peliculas(claveNombrePelicula,clasificacion,distribuidor,fechaEstreno,fechaRetiro,
duracion, disponible)
values
(upper('Titanes del Pacífico: La Resurrección'), 'B', 'Universal', GETDATE(), GETDATE()+15, '01:51:00'),
(upper('Jumanji'), 'B', 'Universal', GETDATE(), GETDATE()+15, '01:43:00'),
(upper('Black Panther'), 'B', 'Disney', GETDATE(), GETDATE()+15, '01:35:00'),
(upper('Mazinger Z'), 'B', 'Bandai', GETDATE(), GETDATE()+15, '01:20:00'),
(upper('Las Aventuras de Lara Croft'), 'B', 'Universal', GETDATE(), GETDATE()+15, '01:40:00')

select * from Idioma

insert into Idioma(idioma)
values('Español'),
('Ingles'),
('Japonés'),
('Alemán'),
('Francés')

select * from Subtitulos

insert into Subtitulos(subtitulos)
values('Español'),
('Inglés'),
('Francés'),
('Japonés'),
('Alemán')



-- Find the average fragmentation percentage of all indexes  
-- in the HumanResources.Employee table.   
SELECT a.index_id, name, avg_fragmentation_in_percent  
FROM sys.dm_db_index_physical_stats (DB_ID(N'DB_CinePremier'), 
      OBJECT_ID(N'Peliculas.indice'), NULL, NULL, NULL) AS a  
    JOIN sys.indexes AS b 
      ON a.object_id = b.object_id AND a.index_id = b.index_id;   
GO  