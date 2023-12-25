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

select * from employe

create function f1()
returns table
as
return(select * from employe)
select * from f1()
