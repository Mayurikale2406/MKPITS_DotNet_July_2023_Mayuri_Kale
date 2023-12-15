create table orde(orderid int , custname varchar(20),prodname varchar(20),quantity int,orddate date)
insert into orde values (1,'amit','mouse',4,'2022-9-7')
insert into orde values (1,'mayuri','keyboard',6,'2022-9-8')
insert into orde values (1,'amitabh','laptop',8,'2022-9-23')
insert into orde values (1,'vrushali','Ram',4,'2022-9-4')
insert into orde values (1,'chetan','desktop',8,'2022-9-11')
insert into orde values (1,'sayali','processor',5,'2022-9-17')
insert into orde values (1,'amit','ssd',2,'2022-9-22')
insert into orde values (1,'mrunal','speaker',9,'2022-9-4')
insert into orde values (1,'vibha','headphones',10,'2022-9-9')
insert into orde values (1,'mayuri','mouse',3,'2022-9-5')

select * from orde where prodname like '%a'