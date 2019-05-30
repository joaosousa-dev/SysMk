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

create table logins
(
usuario varchar (30) primary key ,
senha varchar (40)
)

select * from logins
insert into logins Values('admin','admin')


create table veiculo
(
cod_veiculo int identity(1,1) primary key,
placa varchar (10),
marca varchar (30),
modelo varchar (30),
ano int ,
situacao varchar(15),
categoria varchar (30),
odometro int ,
estado varchar (40),
cod_categoria int,
foreign key (cod_categoria) references categoria (cod_categoria)
)

create table categoria
(
cod_categoria int primary key identity(1,1),
nome varchar(20),
preco float (10)
)
drop table categoria
drop table veiculo
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

drop table veiculo