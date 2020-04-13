
----Creacion de la Base de Datos con dos tablas: Clientes y Prestamos

CREATE DATABASE DATA_PRESTAMOS
GO
USE DATA_PRESTAMOS

CREATE TABLE CLIENTES
(
ID_CLIENTE		INT		IDENTITY(1,1)	NOT NULL,
NOMBRE			NVARCHAR(50)			NOT NULL,
APELLIDO		NVARCHAR(50)			NOT NULL,
CEDULA			NVARCHAR(50)			NOT NULL,
DIRECCION		NVARCHAR(50)			NOT NULL,
EDAD			TINYINT					NOT NULL,
TELEFONO		NVARCHAR(50)			NOT NULL,	

CONSTRAINT PK_CLIENTE PRIMARY KEY(ID_CLIENTE),
)

CREATE TABLE PRESTAMOS
(
ID_PRESTAMO			INT		IDENTITY(1,1)	NOT NULL,
ID_CLIENTE			INT						NOT NULL,
MONTO_PRESTAMO		MONEY					NOT NULL,
CUOTAS				INT						NOT NULL,
INTERES				INT						NOT NULL,
MODALIDAD			NVARCHAR(30)			NOT NULL,
FECHA_ADQUISICION	DATE					NOT NULL,
PAGO_TOTAL			MONEY,
MONTO_SALDADO		MONEY,
MONTO_RESTANTE		MONEY,

CONSTRAINT PK_PRESTAMO PRIMARY KEY(ID_PRESTAMO),
CONSTRAINT FK_CLIENTE FOREIGN KEY(ID_CLIENTE)
REFERENCES CLIENTES(ID_CLIENTE)
)
------------------------------------------------------------------------------
--Store Procedures para tabla prestamos
------------------------------------------------------------------------------

--Consulta los datos de los prestamos existentes
CREATE PROC	MostrarPrestamos
as
select p.ID_PRESTAMO as #PRESTAMO, c.ID_CLIENTE as '#CLIENTE', c.NOMBRE, c.APELLIDO, FORMAT(p.MONTO_PRESTAMO, 'c0') as MONTO, CUOTAS, INTERES, p.MODALIDAD, p.FECHA_ADQUISICION AS 'FECHA'
from PRESTAMOS p
join CLIENTES c
on p.ID_CLIENTE = c.ID_CLIENTE
go

--Elimina un prestamo existente
CREATE PROC EliminarPrestamo
@id int
as
delete from PRESTAMOS where ID_PRESTAMO = @id
go

--Consulta los nombres de los clientes existentes para la creacion de un nuevo prestamo
CREATE PROC MostarNombres
as
select ID_CLIENTE, NOMBRE from CLIENTES
go

--Solicita los datos de prestamos (si los hay) del cliente indicado
CREATE PROC BuscarPrestamo
@nombre nvarchar(50)
as
select p.ID_PRESTAMO as #PRESTAMO, c.ID_CLIENTE as '#CLIENTE', c.NOMBRE, c.APELLIDO, FORMAT(p.MONTO_PRESTAMO, 'c0') as MONTO, CUOTAS, INTERES, p.MODALIDAD, p.FECHA_ADQUISICION AS 'FECHA'
from PRESTAMOS p
join CLIENTES c
on p.ID_CLIENTE = c.ID_CLIENTE
where LOWER(c.NOMBRE) = LOWER(@nombre)
go

--Obtiene el ID de un cliente para evitar confictos de nombres duplicados mientras se crea un prestamo
CREATE PROC GetID
@nom nvarchar(50),
@id int output
as
set @id = (select ID_CLIENTE from CLIENTES where NOMBRE = @nom)  
go

--Crea un nuevo prestamo para un cliente
CREATE PROC  InsertarNuevoPrestamo
@idCliente int,
@monto money,
@cuota int,
@interes int,
@modalidad nvarchar(15),
@fecha date
as
insert into PRESTAMOS(ID_CLIENTE, MONTO_PRESTAMO, CUOTAS, INTERES, MODALIDAD, FECHA_ADQUISICION, PAGO_TOTAL, MONTO_SALDADO, MONTO_RESTANTE)
values(@idCliente, @monto,@cuota, @interes, @modalidad, @fecha, @monto + @monto*@interes/100, 0, @monto + @monto*@interes/100)
go

--Se encarga de registrar los pagos de prestamos
CREATE PROC	 EntrarPago
@idPrestamo int,
@pago money
as
update PRESTAMOS set
MONTO_SALDADO = (select MONTO_SALDADO from PRESTAMOS where ID_PRESTAMO = @idPrestamo) + @pago
where ID_PRESTAMO = @idPrestamo

update PRESTAMOS set
MONTO_RESTANTE = ((select PAGO_TOTAL from PRESTAMOS where ID_PRESTAMO = @idPrestamo) - (select MONTO_SALDADO from PRESTAMOS where ID_PRESTAMO = @idPrestamo))
where ID_PRESTAMO = @idPrestamo
go

--Consulta los balances de pago total, saldado y restante
CREATE PROC BalancesPrestamos
@idPrestamo int
as
select ID_PRESTAMO, PAGO_TOTAL, MONTO_SALDADO, MONTO_RESTANTE 
from PRESTAMOS
where ID_PRESTAMO = @idPrestamo
go

--Realiza cambios en un prestamo creado
CREATE PROC ActualizarPrestamo
@idPrestamo int,
@monto money,
@cuota int,
@modalidad nvarchar(15),
@interes int,
@fecha date
as
update PRESTAMOS set
MONTO_PRESTAMO = @monto,
CUOTAS = @cuota,
MODALIDAD = @modalidad,
INTERES = @interes,
FECHA_ADQUISICION = @fecha,
PAGO_TOTAL = @monto + @monto*@interes/100,
MONTO_RESTANTE = (@monto + @monto*@interes/100) - (select MONTO_SALDADO from PRESTAMOS where ID_PRESTAMO = @idPrestamo)
where ID_PRESTAMO = @idPrestamo
go


-------------------------------------------------------------------------------
-- Procedimientos para la tabla Clientes
-------------------------------------------------------------------------------

--Mostrar Clientes
CREATE PROC MostrarClientes
as
select * from CLIENTES
go

--Insertar clientes
CREATE PROC InsertarCliente
@nombre nvarchar(50),
@apellido nvarchar(50),
@cedula nvarchar(50),
@direccion nvarchar(50),
@edad tinyint,
@telefono nvarchar(50)
as
insert into CLIENTES values(@nombre, @apellido, @cedula, @direccion, @edad, @telefono)
go

--Editar registros
CREATE PROC EditarClientes
@nombre nvarchar(50),
@apellido nvarchar(50),
@cedula nvarchar(50),
@direccion nvarchar(50),
@edad tinyint,
@telefono nvarchar(50),
@id int
as
update CLIENTES set
NOMBRE = @nombre,
APELLIDO = @apellido,
CEDULA = @cedula,
DIRECCION = @direccion,
EDAD = @edad,
TELEFONO = @telefono
where ID_CLIENTE = @id
go

--Eliminar Cliente
CREATE PROC EliminarCliente
@id int
as
delete from CLIENTES where ID_CLIENTE = @id
go

--Buscar Cliente
CREATE PROC BuscarCliente
@nombre nvarchar(50)
as
select * from CLIENTES
where LOWER(NOMBRE) = LOWER(@nombre)
go

exec MostrarPrestamos


-----Utiles para cuando el programa este listo y tenga que resetear la Identidad

--RESETEAR SEMILLA
DBCC CHECKIDENT ('PRESTAMOS', RESEED, 0)


