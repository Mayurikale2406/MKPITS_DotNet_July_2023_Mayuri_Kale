create table employe1(empId int primary key,empName varchar(20),designation varchar(20),salary int)
insert into employe1 values(11,'Amit','Manager',60000)
insert into employe1 values(12,'Vrushali','Manager',70000)
insert into employe1 values(15,'Mayuri','Trainy Engineer',60000)
insert into employe1 values(16,'Amit','Developer',90000)
insert into employe1 values(17,'Manish','UI Developer',90000)
insert into employe1 values(13,'Rani','peon',20000)
insert into employe1 values(19,'Raju','peon',20000)

select empName,count(*) from employe1 where designation = 'UI Developer'group by empName
