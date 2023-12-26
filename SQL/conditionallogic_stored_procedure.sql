create table employee0(department_id int primary key,
                      emp_id int identity,
                      emp_name varchar(20),
					  department_name varchar(20)not null,
					  emp_salary int);
insert into employee0 values(321,'mayuri','HR',20000)
insert into employee0 values(222,'vrushali','engineer',90000)
insert into employee0 values(876,'sayali','developer',80000)
insert into employee0 values(908,'mayuri','manager',30000)
insert into employee0 values(567,'mayuri','HR',60000)
insert into employee0 values(348,'mayuri','developer',40000)

create proc emp00(@emp_id as int )
as
begin
select * from employee0
where emp_salary>@emp_id
end;
exec emp00 50000

drop table employee0
drop proc emp00