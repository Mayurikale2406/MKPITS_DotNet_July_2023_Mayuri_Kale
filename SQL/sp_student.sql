--------------------------------student table------------------------------------

create table student1(stud_id int identity primary key,
                      stud_rno int,
                     admission_no int,
                     stud_firstName varchar(20)not null,
					 stud_lastName varchar(20)not null,
					 age int,stud_city varchar(20)not null)
insert into student1 values(1,111,'vrushali','mohite',22,'nagpur')
insert into student1 values(4,222,'mayuri','kale',22,'nagpur')
insert into student1 values(3,333,'sayali','kapse',21,'pune')
insert into student1 values(5,444,'priya','matre',23,'mumbai')
insert into student1 values(6,555,'sanika','kale',19,'nagpur')
insert into student1 values(17,666,'vrushali','mohite',22,'nagpur')
insert into student1 values(18,777,'mayuri','kale',22,'nagpur')
insert into student1 values(19,888,'sayali','kapse',21,'pune')
insert into student1 values(12,999,'priya','matre',23,'mumbai')
insert into student1 values(9,000,'sanika','kale',19,'nagpur')



select * from student1

--------------------------------------------------fee table------------------------------------

create table stud_fee1(admission_no int,
                      course varchar(20)not null,
					  amount int)
insert into stud_fee1 values(222,'dotnet',30000)
insert into stud_fee1 values(444,'java',20000)
insert into stud_fee1 values(111,'oracle',22000)


select * from student1 inner join stud_fee1 on student1.admission_no=stud_fee1.admission_no
select * from student1 inner join stud_fee1 on student1.admission_no=stud_fee1.admission_no where stud_city='nagpur'

-----------------------------------------sp rollno---------------------------------------
create proc stud1(@stud_id as int)
as
begin
select * from student1
where 3 > stud_rno
end;
exec stud1 3
--------------------------------------------sp city------------------------------------------

create proc stud2(@stud_city as varchar(20))
as
begin
select * from student1
where stud_city=@stud_city
end;
exec stud2 'nagpur'


drop proc stud2
drop proc stud1
drop table student1

