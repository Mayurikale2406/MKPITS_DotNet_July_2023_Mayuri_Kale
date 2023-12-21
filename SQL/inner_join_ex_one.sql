create table student(stud_id int identity primary key,
                     admission_no int,
                     stud_firstName varchar(20)not null,
					 stud_lastName varchar(20)not null,
					 age int)
insert into student values(111,'vrushali','mohite',22)
insert into student values(222,'mayuri','kale',22)
insert into student values(333,'sayali','kapse',21)
insert into student values(444,'priya','matre',23)
insert into student values(555,'sanika','kale',19)

select * from student

create table stud_fee(admission_no int,
                      course varchar(20)not null,
					  amount int)
insert into stud_fee values(222,'dotnet',30000)
insert into stud_fee values(444,'java',20000)
insert into stud_fee values(111,'oracle',22000)

select * from student inner join stud_fee on student.admission_no=stud_fee.admission_no



drop table student
