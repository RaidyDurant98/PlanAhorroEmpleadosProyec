create table Empleados(
EmpleadoId int identity(1,1) primary key,
Nombres varchar(100),
NumCel varchar(14),
Direccion varchar(255),
Sueldo float
);

create table PlanAhorros(
PlanId int identity(1,1) primary key,
Descripcion varchar(255),
PorcientoDesc float,
Interes float,
FondoMinimo float
);

create table AfiliacionEmpleados(
Id int identity(1,1) primary key,
Empleado int foreign key references Empleados(EmpleadoId),
FechaAfiliacion date
);

create table AfiliacionEmpleadosDetalle(
Id int identity(1,1) primary key,
Afiliacion int foreign key references AfiliacionEmpleados(Id),
PlanAhorro int foreign key references PlanAhorros(PlanId),
Descripcion varchar(255),
PorcientoDesc float,
Interes float,
FondoMinimo float,
FechaUltimoCargo date
);

Create table Aportes(
AporteId int identity(1,1) primary key,
Empleado int foreign key references Empleados(EmpleadoId),
PlanAhorro int foreign key references PlanAhorros(PlanId),
Aporte float, 
Fecha date
);

Create table InteresesAcumulados(
IntAcumuladoId int identity(1,1) primary key,
Fecha date,
Total float
);

Create table InteresesAcumuladoDetalle(
Id int identity(1,1) primary key,
IntAcumuladoId int foreign key references InteresesAcumulados(IntAcumuladoId),
Empleado int foreign key references Empleados(EmpleadoId),
PlanAhorro int foreign key references PlanAhorros(PlanId),
IntAcumulado float,
Fecha date
);

Create table Auxiliar(
Id int identity(1,1) primary key,
Empleado int foreign key references Empleados(EmpleadoId),
PlanAhorro int foreign key references PlanAhorros(PlanId),
Fecha date,
TotalInteres float
);

select * from Empleados
select * from PlanAhorros
select * from AfiliacionEmpleadosDetalle
select * from AfiliacionEmpleados
select * from Aportes
select * from InteresesAcumulados
select * from InteresesAcumuladoDetalle

/*Selecciona los plan de ahorro que tiene el empleado 
para hacer el aporte voluntario*/
select pl.PlanId, pl.Descripcion 
from AfiliacionEmpleados afil inner join AfiliacionEmpleadosDetalle det
	on afil.Id = det.Afiliacion 
inner join PlanAhorros pl on pl.PlanId = det.PlanAhorro
where afil.Empleado = 1

/*Selecciona todos los empleados que tienen plan de ahorro con su respectivo plan*/
select Emp.EmpleadoId, Emp.Nombres, Emp.Direccion, Emp.NumCel, Pl.PlanId, Pl.Descripcion, Pl.PorcientoDesc, Pl.Interes, pl.FondoMinimo
from AfiliacionEmpleados afil inner join AfiliacionEmpleadosDetalle det
	on afil.Id = det.Afiliacion
inner join Empleados Emp on Emp.EmpleadoId = afil.Empleado
inner join PlanAhorros Pl on Pl.PlanId = det.PlanAhorro

/*Selecciona los empleados que hacen aportes*/
select Ap.AporteId, Emp.Nombres, Pl.Descripcion, Ap.Aporte, emp.EmpleadoId, emp.Direccion, emp.NumCel
from Empleados Emp inner join Aportes Ap
	on Emp.EmpleadoId = Ap.Empleado 
inner join PlanAhorros Pl on Pl.PlanId = Ap.PlanAhorro;

/*Selecciona los datos que necesito para cargar el el interes acumulado de cada socio*/
select Emp.EmpleadoId, Pl.PlanId, Emp.Nombres, Pl.Descripcion, Pl.PorcientoDesc, Emp.Sueldo, det.FechaUltimoCargo, Pl.Interes, Ap.Aporte
from AfiliacionEmpleados afil inner join AfiliacionEmpleadosDetalle det 
	on afil.Id = det.Afiliacion
inner join Empleados Emp on Emp.EmpleadoId = afil.Empleado
inner join PlanAhorros Pl on Pl.PlanId = det.PlanAhorro
left join Aportes Ap on Emp.EmpleadoId = Ap.Empleado And Pl.PlanId = Ap.PlanAhorro
/*where " & condicion & ""*/

/*Me retorna todos los empleados afiliados tengan caro de interes o no*/
select Emp.Nombres, Pl.Descripcion, dt.Fecha, dt.IntAcumulado, DATEDIFF(day, det.FechaUltimoCargo, GETDATE()) as diferenciadias
from AfiliacionEmpleados afil inner join AfiliacionEmpleadosDetalle det
	on afil.Id = det.Afiliacion
inner join Empleados Emp on Emp.EmpleadoId = Afil.Empleado
inner join PlanAhorros Pl on Pl.PlanId = det.PlanAhorro
left join InteresesAcumuladoDetalle dt on Emp.EmpleadoId = dt.Empleado and pl.PlanId = dt.PlanAhorro
left join InteresesAcumulados intac on intac.IntAcumuladoId = dt.IntAcumuladoId

/*Me selecciona el empleado el plan de ahorro y el total que tiene de intereses*/
select Emp.Nombres, Pl.Descripcion, Sum(IntAc.Total) total
from InteresesAcumulados IntAc inner join InteresesAcumuladoDetalle IntAcDet
	on IntAc.IntAcumuladoId = IntAcDet.IntAcumuladoId
inner join Empleados Emp on Emp.EmpleadoId = IntAcDet.Empleado
inner join PlanAhorros Pl on pl.PlanId = IntAcDet.PlanAhorro
group by Emp.Nombres, Pl.Descripcion

/*Creando vista de los empleado que pertenecen a un plan de ahorro en especifico*/
GO  
CREATE VIEW VistaEmpleadoAfiliados  
AS  
select Emp.EmpleadoId, Emp.Nombres, Emp.Direccion, Emp.NumCel, Pl.PlanId, Pl.Descripcion, Pl.PorcientoDesc, Pl.Interes, pl.FondoMinimo
from AfiliacionEmpleados afil inner join AfiliacionEmpleadosDetalle det
	on afil.Id = det.Afiliacion
inner join Empleados Emp on Emp.EmpleadoId = afil.Empleado
inner join PlanAhorros Pl on Pl.PlanId = det.PlanAhorro   
GO 

/*Creando vista de los empleados que hacen sus aportes*/
GO  
CREATE VIEW VistaDepositosEmpleados  
AS  
select Emp.EmpleadoId, Emp.Nombres, Emp.Direccion, Emp.NumCel, Pl.PlanId, Pl.Descripcion, Ap.Aporte, ap.Fecha
from Empleados Emp inner join Aportes Ap
	on Emp.EmpleadoId = Ap.Empleado 
inner join PlanAhorros Pl on Pl.PlanId = Ap.PlanAhorro;
GO 

/*Actualiza la fecha del ultimo cargo cuando se cargan los intereses*/
update AfiliacionEmpleadosDetalle set FechaUltimoCargo = IntDet.Fecha 
from InteresesAcumulados IntAc inner join InteresesAcumuladoDetalle IntDet 
	on IntAc.IntAcumuladoId = IntDet.IntAcumuladoId
inner join Empleados Emp on Emp.EmpleadoId = IntDet.Empleado
inner join PlanAhorros Pl on Pl.PlanId = IntDet.PlanAhorro
where DATEDIFF(day, FechaUltimoCargo, IntAc.Fecha) > 0 and IntAc.IntAcumuladoId = " & id & "

select IntDet.Fecha 
from InteresesAcumulados IntAc inner join InteresesAcumuladoDetalle IntDet 
	on IntAc.IntAcumuladoId = IntDet.IntAcumuladoId
inner join Empleados Emp on Emp.EmpleadoId = IntDet.Empleado
inner join PlanAhorros Pl on Pl.PlanId = IntDet.PlanAhorro
inner join AfiliacionEmpleadosDetalle aed on DATEDIFF(day, aed.FechaUltimoCargo, getdate()) > 0

select * from AfiliacionEmpleadosDetalle
select * from AfiliacionEmpleados
select * from InteresesAcumuladoDetalle

truncate table PlanAhorros
truncate table empleados
truncate table AfiliacionEmpleados
truncate table afiliacionEmpleadosDetalle
truncate table Aportes
truncate table interesesAcumuladoDetalle

DBCC CHECKIDENT (Empleados, reseed, 0) 
DBCC CHECKIDENT (PLanAhorros, reseed, 0)
DBCC CHECKIDENT (AfiliacionEmpleados, reseed, 0)
DBCC CHECKIDENT (InteresesAcumulados, reseed, 0)

delete from AfiliacionEmpleados
delete from Empleados
delete from PlanAhorros
delete from InteresesAcumulados