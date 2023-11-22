create database [BD_FelipeTsutsumi09];
use BD_FelipeTsutsumi09;
create table login_FelipeTsutsumi09 (id int identity(1,1) primary key not null, matr_func int not null, loginu varchar(10) not null, senha varchar(10) not null, adm char(1) not null, cargo varchar(30) not null, salario money not null, depend_m14 char(1) not null);
insert into login_FelipeTsutsumi09 (matr_func, loginu, senha, adm, cargo, salario, depend_m14) values (1, 'fefe', 'fefe123', 1, 'diretor', 5000, 1);