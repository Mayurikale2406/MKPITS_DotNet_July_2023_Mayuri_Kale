create table employee(emp_name varchar(20)not null,
                      emp_occupation varchar(20),
					  working_date date,
					  working_hours float,
					  emp_salary int);
insert into employee values('jolly evans','HR','2020-10-04',9,25000)
insert into employee values('brayden simmons','engineer','2020-10-04',12,65000)
insert into employee values('rose huges','writer','2020-10-04',13,35000)
insert into employee values('laura paul','manager','2020-10-04',10,25000)
insert into employee values('jolly evans','teacher','2020-10-04',12,45000)
insert into employee values('jolly evans','writer','2020-10-04',13,30000)
insert into employee values('jolly evans','manager','2020-10-04',10,35000)
insert into employee values('jolly evans','writer','2020-10-04',9,42000)
insert into employee values('jolly evans','writer','2020-10-04',12,38000)
insert into employee values('jolly evans','HR','2020-10-04',11,30000)

select * from employee
--------------------------average------------------------------
select AVG(working_hours)
as
"average working hours"
from employee;

-------------------------sum---------------------------------

select SUM(working_hours)
as
"sum working hours"
from employee



drop table employee

select AVG(working_hours)
as
"average working hours"
from employee
where emp_occupation = 'manager';

---------------------------------------

select emp_occupation, 
AVG(working_hours),
as
"average working hours"
from employee
group by emp_occupation;

--------------------------------------------

