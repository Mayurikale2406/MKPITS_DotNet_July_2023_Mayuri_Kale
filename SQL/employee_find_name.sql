create table employee(empId int primary key,empName varchar(20),designation varchar(20),salary int)
insert into employee values(11,'Amit','Manager',60000)
insert into employee values(12,'Vrushali','Manager',70000)
insert into employee values(15,'Mayuri','Trainy Engineer',60000)
insert into employee values(16,'Amit','Developer',90000)
insert into employee values(17,'Manish','UI Developer',90000)
insert into employee values(13,'Rani','peon',20000)
insert into employee values(19,'Raju','peon',20000)
select * from employee 
select * from employee where empName='Amit'