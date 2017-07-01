Create table Cobros(
IdCobros int identity(1,1) primary key,
Fecha date,
Referencia varchar(45),
IdRemoto int,
IdRuta int,
Mora money,
Monto money,
Latitud decimal,
Longitud decimal,
EsNulo bit
);

insert into Cobros(Fecha,Referencia,IdRemoto,IdRuta,Mora,Monto,Latitud,Longitud,EsNulo)
values ('20170220','asd123', 1, 1, 123, 1234, 123456, 1234567, 0)
insert into Cobros(Fecha,Referencia,IdRemoto,IdRuta,Mora,Monto,Latitud,Longitud,EsNulo)
values ('20170321','fasdfa1231', 2, 2, 13243, 34534, 123456, 323434, 1)
insert into Cobros(Fecha,Referencia,IdRemoto,IdRuta,Mora,Monto,Latitud,Longitud,EsNulo)
values ('20170415','dafdf00', 3, 3, 123, 4235, 34343, 1234567, 0)
insert into Cobros(Fecha,Referencia,IdRemoto,IdRuta,Mora,Monto,Latitud,Longitud,EsNulo)
values ('20170530','asdfasdf1313', 4, 4, 234, 1234, 223423, 234234, 0)
insert into Cobros(Fecha,Referencia,IdRemoto,IdRuta,Mora,Monto,Latitud,Longitud,EsNulo)
values ('20170606','asdfasf31', 5, 5, 123, 2344, 12323456, 234234, 0)

