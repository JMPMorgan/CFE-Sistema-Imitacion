use MAD

 create table Empleados(
	RFC varchar(30) not null,
	CURP varchar(30) primary key not null,
 );

 create table Clientes(
	CURP varchar(30) primary key not null ,
 );

 create table InfoEmpleados(
 Usuario varchar(30) primary key not null,
 nombreEmpleado varchar(30) not null,
 fechaNacimiento date not null,
 fechaCreacion datetime not null,
 );

 create table InfoCliente(
 CURP varchar(30) primary key not null,
 nombreCliente varchar(30) not null ,
 numCasa varchar(30) not null,
 colonia varchar(30) not null,
 calle varchar(30) not null,
 sexo varchar(30) not null,
 fechaNacimiento date not null,
 fechaCreacion datetime not null,
 );

 create table Usuarios(
 Usuario varchar(30) not null,
 pass varchar(30)not null,
 rolUsuario varchar(30) not null,
 CURP varchar(30) primary key not null  , 
 );

 
 create table contratos(
 fechaCreacion datetime not null,
 numeroServicio varchar(30) not null,
 numeroMedidor int identity(1,1) primary key not null,
 numeroContrato int  not null,
 UserEmpleado varchar(30) not null,
 CURPCliente varchar(30) not null,
 direccionCasa varchar(60) not null,
 entreCalles varchar(30) not null
 );

 create table tarifa(
 nombreTarifa varchar(30) primary key not null,
 precioBasico int not null,
 precioMedio int not null,
 precioExcedente int not null,
 fechaCreacion datetime not null,
 UsuarioEmpleado varchar(30) not null,
);

create table reportTarifa(
fechaCreacion timestamp not null,
nombreTarifa varchar(30) not null,
tarifaBasica int not null,
tarifaMedio int not null,
tarifaExcedente int not null
);

create table consumo(
fechaConsumo date primary key not null,
consumo decimal(6,4) not null,
nombreDeTarifa varchar(30)not null,
numeroMedidor int  not null,
);

create table formaPago(
debito int not null,
credito int not null,
efectivo int not null,
adeudo decimal(6,2),
pagado decimal(6,2),
numeroRecibo int   not null,
);

create table recibos(
numeroServicio int not null,
UserEmpleado varchar(30) not null,
consumoTotal decimal(6,4) not null,
consumoBasico decimal(6,4) not null,
consumoMedio decimal(6,4) not null,
consumoExcedente decimal(6,4) not null,
nombreDeTarifa varchar(30) not null,
fechaCreacion date not null,
numeroMedidor int not null,
numeroRecibo int identity(1,1) not null
primary key(numeroServicio,UserEmpleado)
);

create table reporteGeneral(
fechaCreacion timestamp not null,
CURPUsuario varchar(30) not null,
numeroServicio int not null,
);

create table consumoHistorico(
fechaCreacion date not null,
numeroMedidor int not null,
consumo varchar(25) not null,
numeroServicio int not null,
CURPEmpleado varchar(30) not null,
CURPUsuario varchar(30) not null,

);

create table fechaCreacion(
 ano int not null,
 mes varchar(25) not null,
 fechaCreacion timestamp primary key not null
);

drop table Empleados;

drop table Clientes;

drop table InfoEmpleados;

drop table InfoCliente;

drop table Usuarios;

drop table contratos;

drop table tarifa;

drop table reportTarifa;

drop table consumo;

drop table formaPago;

drop table recibos;

drop table reporteGeneral;

drop table consumoHistorico;

drop table fechaCreacion;

Select CURP,RFC from Empleados where CURP like 'CUPR' and RFC like 'RFC';

Select 

Select * from InfoEmpleados full join Usuarios on InfoEmpleados.Usuario='Hola' full join Empleados on Empleados.CURP= Usuarios.CURP;

Select Empleados.RFC, Empleados.CURP, Usuarios.Usuario from Empleados inner join Usuarios on Empleados.CURP='CUPR'and  Empleados.RFC='RFC' and Usuarios.Usuario='Putito' and Empleados.CURP=Usuarios.CURP;--Para selecionar solo el usuario y la informacion de empleados con la combinacion de Usuario

Select * from Usuarios ;
Select Empleados.CURP,Empleados.RFC,Usuarios.Usuario,Usuarios.Pass,InfoEmpleados.nombreEmpleado,InfoEmpleados.fechaNacimiento from Empleados inner join Usuarios on Usuarios.CURP = Empleados.CURP and Empleados.CURP like'a' inner join InfoEmpleados on Usuarios.Usuario=InfoEmpleados.Usuario ;
Select * from Empleados;
Select * from InfoEmpleados;
Select * from Clientes;
Select * from InfoCliente;
Select * from contratos;

Select Empleados.CURP,InfoEmpleados.Usuario,Usuarios.Usuario from Empleados  inner join  InfoEmpleados on Empleados.CURP like 'curp'   inner Join Usuarios on Usuarios.Usuario like 'curp';
Update InfoEmpleados Set nombreEmpleado='empleado', fechaNacimiento='05-05-2020' where Usuario like'user';
Insert into Empleados (RFC,CURP)
VALUES ('RFC','CUPR');
 INSERT into Usuarios(Usuario,pass,rolUsuario,CURP) VALUES('Putito','1234','Empleado','1234');
 INSERT into Usuarios(Usuario,pass,rolUsuario,CURP) VALUES('Putito','1234','Empleado','CUPR');
 Select Usuarios.Usuario from Usuarios where CURP like 'curp';

 Select Usuarios.Usuario,Usuarios.pass,Usuarios.rolUsuario from Usuarios where Usuario ='usuario' and pass='1234';


 Select Clientes.CURP,InfoCliente.sexo,InfoCliente.numCasa,InfoCliente.colonia,InfoCliente.calle,Usuarios.Usuario from Clientes inner join InfoCliente on InfoCliente.CURP=Clientes.CURP and Clientes.CURP='a' inner join Usuarios on Usuarios.pass=Clientes.CURP ;

 Select Clientes.CURP,Usuarios.Usuario,Usuarios.rolUsuario from Clientes inner join Usuarios on Usuarios.CURP =  Clientes.CURP and Usuarios.rolUsuario='Cliente';

 Select Empleados.CURP,Empleados.RFC,Usuarios.Usuario,Usuarios.rolUsuario from Empleados inner join Usuarios on Usuarios.CURP = Empleados.CURP ;

 Select InfoCliente.numCasa,InfoCliente.nombreCliente,InfoCliente.colonia,InfoCliente.calle,InfoCliente.sexo,InfoCliente.nombreCliente,InfoCliente.fechaNacimiento,Usuarios.pass from InfoCliente inner join Usuarios on Usuarios.CURP='CURP' and Usuarios.CURP=InfoCliente.CURP;

 Select Clientes.CURP,Usuarios.CURP,InfoCliente.CURP from Clientes  inner join Usuarios on Usuarios.CURP=Clientes.CURP inner join InfoCliente on InfoCliente.CURP=Clientes.CURP where Clientes.CURP='curpcliente';

 Delete from InfoCliente where CURP='curpcliente';
 
 Select InfoCliente.nombreCliente,InfoCliente.calle,InfoCliente.colonia,InfoCliente.NumCasa,Usuarios.Usuario,InfoCliente.CURP from InfoCliente inner join Usuarios on Usuarios.CURP=InfoCliente.CURP and InfoCliente.CURP='curp';

 Select * from contratos where direccionCasa='a' and entreCalles='u';
 
 Select * from contratos where CURPCliente='curpcliente';

 Select contratos.numeroServicio,contratos.CURPCliente,contratos.direccionCasa,contratos.UserEmpleado,Usuarios.Usuario from contratos inner join Usuarios on Usuarios.CURP=contratos.CURPCliente and Usuarios.CURP='curpcliente' and contratos.numeroMedidor=1;

 select * from consumo  where fechaConsumo = '2020-01-11';

 select * from formaPago where numeroRecibo=1;

 select * from consumo;

 select * from recibos;

 Select fechaCreacion,numeroServicio,numeroMedidor,formaPago.pagado,formaPago.adeudo from recibos inner join formaPago on recibos.numeroMedidor=1 and formaPago.numeroRecibo=recibos.numeroRecibo and FORMAT(GETDATE(),'MM')=05 and FORMAT(GETDATE(),'yyyy')=2021  and recibos.numeroServicio=1;

 Select FORMAT(GETDATE(),'MM'),FORMAT(GETDATE(),'yyyy'),numeroServicio from recibos where numeroRecibo=1;

 SELECT fechaCreacion,UserEmpleado,numeroMedidor,consumoTotal from recibos where FORMAT(GETDATE(),'MM')=5 and numeroMedidor=1;

	Select contratos.numeroMedidor from contratos  inner join formaPago on formaPago.numeroRecibo=1 and contratos.CURPCliente='curpcliente';

	Select recibos.fechaCreacion,recibos.numeroServicio,formaPago.pagado,formaPago.adeudo from recibos inner join formaPago on formaPago.numeroRecibo=1 and recibos.numeroMedidor=1;

Select fechaCreacion,numeroServicio,numeroMedidor,formaPago.pagado,formaPago.adeudo from recibos inner join formaPago on recibos.numeroMedidor=1 and formaPago.numeroRecibo=recibos.numeroRecibo;
 Select fechaCreacion,numeroServicio,numeroMedidor,formaPago.pagado,formaPago.adeudo from recibos inner join formaPago on recibos.numeroMedidor=1 and formaPago.numeroRecibo=recibos.numeroRecibo and FORMAT(GETDATE(),'MM')=5 and FORMAT(GETDATE(),'yyyy')=2021;
 
 Select * from recibos inner join formaPago on FORMAT(GETDATE(),'yyyy')=2021 and numeroMedidor=1 and numeroServicio=1 and recibos.numeroRecibo=formaPago.numeroRecibo;
 Select * from tarifa where FORMAT(GETDATE(),'yyyy')=2021;
 
 DROP PROCEDURE Agregar_Consumo;

 CREATE PROCEDURE Agregar_Consumo(
 @fechaConsumo date ,
 @consumo decimal,
 @nombreDeTarifa varchar(30),
 @numeroMedidor int
 )
 AS
 BEGIN
 INSERT INTO consumo(fechaConsumo,consumo,nombreDeTarifa,numeroMedidor) VALUES(@fechaConsumo,@consumo,@nombreDeTarifa,@numeroMedidor)
 END

 DROP PROCEDURE Generar_Recibo;

 CREATE PROCEDURE Generar_Recibo(
 @numeroServicio int,
 @UserEmpleado varchar(30),
 @consumoTotal Decimal(6,4),
 @consumoBasico Decimal(6,4),
 @consumoMedio Decimal(6,4),
 @consumoExcedente Decimal(6,4),
 @nombreDeTarifa varchar(30),
 @fechaCreacion date,
 @numeroMedidor int)
 AS
 BEGIN
 INSERT INTO recibos(numeroServicio,UserEmpleado,consumoTotal,consumoBasico,consumoMedio,consumoExcedente,nombreDeTarifa,fechaCreacion,numeroMedidor)
 VALUES(@numeroServicio,@UserEmpleado,@consumoTotal,@consumoBasico,@consumoMedio,@consumoExcedente,@nombreDeTarifa,@fechaCreacion,@numeroMedidor)
 END
