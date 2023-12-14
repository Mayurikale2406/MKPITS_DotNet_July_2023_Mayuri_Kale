create  table fees( rno int ,name varchar(20) , course varchar(20), amount int , paiddate date)
insert into fees values (1,'mayuri','dotnet',65000,'2023-6-17')
insert into fees values (2,'vrushali','dotnet',65000,'2023-6-19')
insert into fees values (3,'pranay','java',10000,'2023-6-17')
insert into fees values (4,'sahil','dotnet',10000,'2023-6-20')
insert into fees values (5,'priya','dotnet',65000,'2023-6-19')
insert into fees values (6,'sayali','dotnet',65000,'2023-6-15')
insert into fees values (7,'teju','java',65000,'2023-6-14')
insert into fees values (8,'mrunal','dotnet',65000,'2023-6-13')
insert into fees values (9,'mayuri','java',65000,'2023-6-24')
insert into fees values (10,'maithili','java',65000,'2023-6-17')

select * from fees
select * from fees where paiddate BETWEEN '2023-6-17' and '2023-6-24'
select * from fees where rno  not in (1,3,5)
select * from fees where rno   in (1,3,5)
select * from fees where name  like '%ri'
select * from fees where name like '%li%'
