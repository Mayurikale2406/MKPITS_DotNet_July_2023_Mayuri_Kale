create table employee4(department_id int primary key,
                      emp_id int identity,
                      emp_name varchar(20),
					  department_name varchar(20)not null);
insert into employee4 values(122,'mayuri','electronic')
insert into employee4 values(200,'sayali','civil')
insert into employee4 values(120,'vrushali','mechanical')
insert into employee4 values(130,'priya','electronics')
insert into employee4 values(118,'vrushali','it')
insert into employee4 values(222,'mayuri','computer')
insert into employee4 values(098,'prachi','telecom')
insert into employee4 values(456,'ayushi','elelctronics')
insert into employee4 values(789,'mrunal','eletrical')
insert into employee4 values(987,'sakshi','it')

select * from employee4

create proc prod00(@emp_id as int)
as
begin
select * from employee4
where department_id=@emp_id
end;
exec prod00 987
exec prod00 789

drop table employee4
