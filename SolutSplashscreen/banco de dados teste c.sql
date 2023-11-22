create database [teste_c];
use teste_c;
create table cad_usu (id int identity(1,1) primary key not null, nome varchar(30) not null, usu_login varchar(10) not null, senha varchar(10) not null);
insert into cad_usu (nome, usu_login, senha) values ('Pedro', 'PedrinRX', 'Pedro123');
insert into cad_usu (nome, usu_login, senha) values ('Felipe', 'FelipinRX', 'Felipe123');
insert into cad_usu (nome, usu_login, senha) values ('Lucas', 'LucasRX', 'Lucas123');



select * from cad_usu;