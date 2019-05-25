create database sportplus

use sportplus

create table equipo(
id_equipo varchar(50) primary key,
nombre varchar(50),
num_jugadores varchar(50),
tecnico varchar(50),
fecha_creacion varchar(50),
liga varchar(50),
);

create table partido(
id_partido varchar(50) primary key,
arbitro varchar(50),
asistentes varchar(50),
e_local varchar(50),
e_visitante varchar(50),
estadio varchar (50),
marcador varchar(50),
liga varchar(50)
);

create table liga(
id_liga varchar(50) primary key,
nombre varchar(50),
partidos varchar(50),
num_equipos varchar(50),
deporte varchar(50),
);

create table jugador(
id_jugador varchar(50) primary key,
nombre varchar(50),
apellido varchar(50),
posicion varchar(50),
edad varchar(50),
altura varchar(50),
peso varchar(50),
equipo varchar(50)
);

select * from liga
select * from jugador
select * from partido
select * from equipo

