create database SistemaPrestamo
go 
use SistemaPrestamo
go 
create table prestamo(
id  int primary key identity (1,1),
Nombres varchar (50) not null,
Apellidos varchar (50) not null,
Edad int not null,
Telefono int not null,
Direccion varchar (150) not null,
Cedula varchar (50) not null,
 pagoPrestamo int not null,
 interesPrestamo int not null,
 montoPrestamo int not null,
  tiempoPrestamo int not null,
  cuotaPrestamo int not null
     
)