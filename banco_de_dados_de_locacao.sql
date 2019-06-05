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
telefone varchar(15),
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
usuario varchar (20) primary key ,
senha varchar (100)
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
odometro int ,
estado varchar (40),
cod_categoria int,
categoria varchar(50),
tanque varchar(10),
foreign key (cod_categoria) references categoria (cod_categoria)
)
drop table categoria
create table locacao
(
cod_locacao int identity(1,1)primary key,
cod_cliente int,
nome_cliente varchar(80),
cod_veiculo int,
modelo_veiculo varchar(50),
cod_fun int,
nome_fun varchar(80),
data_aluguel date,
data_devolucao date,
situacao varchar(20)
foreign key(cod_cliente)references cliente (cod_cliente),
foreign key (cod_veiculo) references veiculo (cod_veiculo),
foreign key (cod_fun) references funcionario (cod_fun)
)

create table categoria
(
cod_categoria int primary key identity(1,1),
nome varchar(20),
preco float (10)
)

create table contrato
(
cod_contrato int primary key identity(1,1),
)



select * from categoria
select * from veiculo
select * from funcionario
select * from locacao

drop table categoria
drop table veiculo
drop table locacao
