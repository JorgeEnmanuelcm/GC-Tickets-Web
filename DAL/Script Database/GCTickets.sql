Create database GCTickets

use GCTickets

Create table Usuarios(
UsuarioId int primary key identity(1,1),
Nombres varchar(18),
Apellidos varchar(18),
Telefono varchar(15),
Email varchar(32),
Direccion varchar(32),
NombreUsuario varchar(12),
Contrasenia varchar(32)
)

--TipoUsuario int
