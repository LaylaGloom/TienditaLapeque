drop table if exists prestamos;
create table prestamos(
id_prestamos int unsigned not null auto_increment primary key,
nom_cliente varchar(150),
fecha_p timestamp default current_timestamp,
monto_deuda double unsigned,
monto_abono double unsigned,
estado enum('pagado','en deuda') default 'en deuda');

drop table if exists venta;
drop table if exists ventas;
create table ventas(
id_venta int unsigned not null,
fecha_venta timestamp default current_timestamp,
producto varchar(50),
precio float,
cp_vendidos int(11) unsigned,
nombre_usuario varchar(10),
subtotal float4);