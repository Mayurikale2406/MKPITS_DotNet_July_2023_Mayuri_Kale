create table employee1(emp_id int primary key,
                     emp_name varchar(20)not null,
					 emp_city varchar(20)not null);
create table emplog1(log_id int identity,
                   emp_id int,
				   operation varchar(20),
				   updatedate datetime);

---------------------------delete table----------------------------

---------------------------------------------
create trigger empu
on employee1
after update
as
insert into emplog1(emp_id,Operation,updatedate)
select emp_id,'update',GETDATE() from deleted

insert into employee1 values(1,'sayali','mumbai')
select * from employee1
select * from emplog1
update employee1 set emp_name='amitabh' where emp_id=1





