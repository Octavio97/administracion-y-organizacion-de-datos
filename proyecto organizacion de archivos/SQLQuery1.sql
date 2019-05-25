create database pagweb

use pagweb

create table categoria(
id_cat varchar (50) primary key,
nombre varchar (50), 
fecha varchar (50)
)
select * from categoria

create table pagina(
id_web nvarchar(50) primary key,
nombre nvarchar(50),
direccion nvarchar (50),
valoracion nvarchar (50),
fecha nvarchar (50),
descripcion varchar(50),
tiempo varchar(50),
categoria varchar(50)
)
select * from pagina as p

