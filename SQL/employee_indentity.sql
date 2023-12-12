create table employee (empid int primary key identity (1,1), empname varchar(20))
insert into employee(empname)values('ravi')
insert into employee(empname)values('mayuri')
insert into employee(empname)values('sayali')
insert into employee(empname)values('vrushali')
select * from employee
delete from employee where empid=2

insert into employee (empname) values ('mayuri123')
delete from employee
select * from employee
insert into employee (empname) values ('mayuri123')