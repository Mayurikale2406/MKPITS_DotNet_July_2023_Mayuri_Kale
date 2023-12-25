create table employe(emp_name varchar(20)not null,
                      emp_occupation varchar(20),
					  working_date date,
					  working_hours float,
					  emp_salary int);
insert into employe values('jolly evans','HR','2020-10-04',9,25000)
insert into employe values('brayden simmons','engineer','2020-10-04',12,65000)
insert into employe values('rose huges','writer','2020-10-04',13,35000)
insert into employe values('laura paul','manager','2020-10-04',10,25000)
insert into employe values('jolly evans','teacher','2020-10-04',12,45000)
insert into employe values('jolly evans','writer','2020-10-04',13,30000)
insert into employe values('jolly evans','manager','2020-10-04',10,35000)
insert into employe values('jolly evans','writer','2020-10-04',9,42000)
insert into employe values('jolly evans','writer','2020-10-04',12,38000)
insert into employe values('jolly evans','HR','2020-10-04',11,30000)

---------------------------count salary--------------------------
select * from employe
select count(emp_salary)
as
'total'
from employe

----------------------------count occupation-------------------------
select count(emp_occupation)
as
'total'
from employe
where emp_occupation = 'manager'

--------------------------count total occupation--------------------------
select emp_occupation,count(emp_occupation)
as
'total'
from employe
group by emp_occupation


select*from employe

drop table employe