------------------------------------------student table--------------------------------

create table student(rno int primary key identity,
                     stud_name varchar(20),
					 stud_email varchar(20),
					 stud_city varchar(20),
					 course_id int);
insert into student values('sayali kapse','sk@gmail.com','nagpur',111)
insert into student values('vrushali mohite','mk@gmail.com','pune',222)
insert into student values('mayuri kale','mk@gmail.com','nagpur',333)
insert into student values('priya matre','pm@gmail.com','hydrabad',444)
insert into student values('vibha gahukar','vg@gmail.com','pune',555)
insert into student values('sanika kale','sk@gmail.com','nagpur',666)
insert into student values('mrunal gajhbhiye','mg@gmail.com','mumbai',777)
insert into student values('sayali kapse','sk1@gmail.com','mumbai ',111)

select * from student

--------------------------------------------fees table-----------------------------------------
create table fees(feesid int,
                 rollno int primary key,
				 feesdate date,
				 amount bigint,
				 course_id int);

insert into fees values(11,3,'2021-8-11',20000,777)
insert into fees values(12,4,'2021-8-12',50000,888)
insert into fees values(13,5,'2021-8-14',30000,111)
insert into fees values(14,6,'2021-8-15',50000,333)
insert into fees values(15,8,'2021-8-16',60000,555)

select * from fees

select * from student where course_id in (select course_id from 
                fees where stud_city ='nagpur')

select * from student where course_id in (select course_id from 
                fees where stud_city ='mumbai')

--------------------------------------------course table-------------------------------------

create table course (course_id int,
                    course_name varchar(20)not null,
					course_fees int not null,
					duration_month int);

insert into course values(2,'dotnet',65000,'6')
insert into course values(5,'java',55000,'10')
insert into course values(8,'php',35000,'8')
insert into course values(3,'sql',95000,'4')
insert into course values(3,'sql',95000,'4')
insert into course values(3,'sql',95000,'4')

select * from course

select * from student where course_id in(select course_id from 
                                         course where course_name='sql')

drop table course

