create table employe(empId int primary key,empName varchar(20),designation varchar(20),salary int)
insert into employe values(11,'Amit','Manager',60000)
insert into employe values(12,'Vrushali','Manager',70000)
insert into employe values(15,'Mayuri','Trainy Engineer',60000)
insert into employe values(16,'Amit','Developer',90000)
insert into employe values(17,'Manish','UI Developer',90000)
insert into employe values(13,'Rani','peon',20000)
insert into employe values(19,'Raju','peon',20000)

select * from employe
select * from employe where empName = 'Amit'
select empName , designation , salary from employe