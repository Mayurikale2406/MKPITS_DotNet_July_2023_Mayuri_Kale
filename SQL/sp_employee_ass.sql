create table emp(emp_name varchar(20)not null,
                      emp_city varchar(20)not null)
					  
insert into emp values('vrushali','nagpur')
insert into emp values('vrushali','nagpur')
insert into emp values('vrushali','nagpur')
insert into emp values('vrushali','nagpur')
insert into emp values('vrushali','nagpur')
insert into emp values('vrushali','pune')
insert into emp values('vrushali','nagpur')
insert into emp values('vrushali','pune')
insert into emp values('vrushali','pune')
insert into emp values('vrushali','mumbai')
insert into emp values('vrushali','mumbai')
insert into emp values('vrushali','mumbai')
insert into emp values('vrushali','hydrabad')
insert into emp values('vrushali','nagpur')


select * from emp
create proc prod10
as
begin
select * from emp
end;

exec prod10 select count (emp_name) as 'total' from emp

exec prod10 select count(emp_name)as 'total'from emp where emp_city='pune'
drop table emp