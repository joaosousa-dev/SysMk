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
foreign key (cod_categoria) references categoria (cod_categoria)
)
drop table veiculo
create table locacao
(
cod_locacao int identity(1,1)primary key,
cod_cliente int,
cod_veiculo int,
cod_fun int,
data_aluguel datetime,
data_devolucao datetime,
hora_aluguel time,
foreign key(cod_cliente)references cliente (cod_cliente),
foreign key (cod_veiculo) references veiculo (cod_veiculo),
foreign key (cod_fun) references funcionario (cod_fun)
)

create table categoria
(
cod_categoria int primary key identity(1,1),
nome_categoria varchar(20),
preco float (10)
)

create table contrato
(
cod_contrato int primary key identity(1,1),
)



select * from cliente
select * from veiculo
select * from funcionario
select * from categoria

drop table veiculo