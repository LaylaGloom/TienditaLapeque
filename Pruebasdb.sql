drop table prestamos;
insert into prestamos (nom_cliente, monto_deuda,monto_abono) values('trinidad',50.50,20);

update prestamos set monto_abono=499.99, estado='pagado' where id_prestamos=3;
update prestamos set monto_abono=monto_abono+(monto_deuda-monto_abono), estado='pagado' where id_prestamos=3;
insert into prestamos values (3,'tomoe','2018/04/15',45,25,'en deuda');

update usuarios set contrasena='checo123' where id_usuario=4;

select sum(subtotal) as total, sum(cp_vendidos) as productos from ventas where fecha_venta between '2018-04-14' and '2018-04-30';

insert into ventas (id_venta,producto,precio,cp_vendidos,nombre_usuario,subtotal) values (1,'submarinos',12,1,'Admin',12);
insert into ventas values (2,'2018/05/16 12:50:00','submarinos',12,1,'Admin',12);

Select * from ventas where fecha_venta between '2018-04-14' and '2018-04-30';

SELECT nombre FROM usuarios AS username WHERE nombre LIKE 'gato';

INSERT INTO usuarios (nombre,apepat,apemat,id_rango,contrasena) VALUES('ruth','hernandez','mora',1,'admin12345');