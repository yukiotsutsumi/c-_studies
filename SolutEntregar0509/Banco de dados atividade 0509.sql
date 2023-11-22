create database [login_ecologize];
create table cad_usu (usu_login varchar(20) primary key not null, senha varchar(20) not null, nome varchar(30) not null);
insert into cad_usu (usu_login, senha, nome) values ('Felipe_Tsutsumi', 'felipe123', 'Felipe');
insert into cad_usu (usu_login, senha, nome) values ('André_Peres', 'andre123', 'André');