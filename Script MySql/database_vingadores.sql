
create database vingadores;

use vingadores;

create table tb_heroi (
  id_heroi         int primary key auto_increment,
  nm_heroi         varchar(200),
  nm_nome          varchar(200),
  ds_sexo          varchar(200),
  vl_forca         int,
  vl_poder         int,
  ds_status        varchar(200)
);

insert into tb_heroi (nm_heroi, nm_nome, ds_sexo, vl_forca, vl_poder, ds_status)
              values ('Capitão América', 'Steve Rogers', 'M', 120, 0, 'Inativo');
              

