create table employee(emp_id int primary key,
                     emp_name varchar(20)not null,
					 emp_city varchar(20)not null);
create table emplog(log_id int identity,
                   emp_id int,
				   operation varchar(20),
				   updatedate datetime);

--------------------------insert data-----------------------------------

create trigger tr1
on employee
for insert 
as
insert into emplog(emp_id,operation,updatedate)
select emp_id,'insert',GETDATE()from inserted

insert into employee values(1,'mayuri','nagpur')
select * from employee
select * from emplog

drop table employee
drop table emplog

