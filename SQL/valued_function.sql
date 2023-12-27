create table employee11(emp_id int identity primary key,
                      emp_name varchar(20)not null,
					  emp_city varchar(20)not null,
					  emp_salary int);
insert into employee11 values('vrushali','nagpur',20000)
insert into employee11 values('mayuri','pune',25000)
insert into employee11 values('sayali','mumbai',32000)
insert into employee11 values('mrunal','pune',22000)
insert into employee11 values('priya','nagpur',29000)

select * from employee11

create function f1()
returns table
as
return(select * from employee11)
select * from f1()