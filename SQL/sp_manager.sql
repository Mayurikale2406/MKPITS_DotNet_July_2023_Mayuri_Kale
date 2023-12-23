------------------------------------------employee table--------------------------------------

create table employee(emp_id int identity primary key,
                      emp_name varchar(20)not null,
					  designation varchar(20)not null,emp_salary int);
insert into employee values('mayuri kale','Manager',220000)
insert into employee values('mrunal gajbhiye','Manager',34000)
insert into employee values('sayali kapse','clerk',10000)
insert into employee values('vrushali mohite','clerk',10000)
insert into employee values('sanika kale','Manager',35000)
insert into employee values('priya matre','Manager',250000)

select * from employee
create proc emp1(@designation varchar(20),@emp_salary int)
as
begin
select * from employee
where emp_salary>20000
end;
exec emp1 'manager',20000
drop table employee
drop proc emp1