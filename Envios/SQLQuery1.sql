create database mibase

use mibase

create table Transporte(
id_transporte varchar(50) primary key,
tipo varchar(50),
marca varchar(50),
modelo varchar(50),
serie varchar(50));
select * from Transporte
delete from Transporte

create table Ruta(
id_ruta varchar (50)primary key ,
Distancia varchar(50) ,
Tiempo_estimado varchar(50) ,
lsalida varchar(50) ,
Destino varchar(50));
select * from Ruta
delete from Ruta

create table Carga(
id_carga varchar (50) primary key,
tipo varchar (50),
peso varchar (50),
contenido varchar (50),
descripcion varchar (50),
);
select * from Carga
delete from Carga

create table Chofer(
id_chofer varchar (50) primary key,
nombre varchar (50),
sexo varchar (50),
edad varchar(50),
direccion varchar(50),
tipodelicencia varchar(50),
telefono varchar (50)
);
select * from Chofer
delete from Chofer
