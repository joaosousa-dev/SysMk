create database LocacaoDeCarro

use LocacaoDeCarro

create table funcionario
(
cod_fun int identity(1,1) primary key,
nome varchar (80),
)

create table cliente
(
cod_cliente int  identity(1,1)primary key,
nome varchar (80),
tipo_cnh char (10),
endereço varchar (100),
cnh varchar(11),
cep varchar (12),
cidade varchar (40),
estado varchar (4),
complemento varchar (100)
)

create table acesso 
(
cod_usuario int identity(1,1) primary key,
nome varchar (30),
senha varchar (40)
)

create table veiculo
(
cod_veiculo int identity(1,1) primary key,
marca varchar (30),
modelo varchar (30),
ano int ,
categoria varchar (30),
odometro int ,
estado varchar (40),
placa varchar (10)
)

create table valores
(
tx_veiculo float ,
imp_veiculo float ,
val_add float ,
total float
)

select * from valores
select * from acesso
select * from cliente
select * from veiculo
select * from funcionario

drop table cliente