create table studentt(rno int primary key identity,
                     stud_name varchar(20),
					 stud_email varchar(20),
					 stud_city varchar(20),
					 course_id int);
insert into studentt values('sayali kapse','sk@gmail.com','nagpur',111)
insert into studentt values('vrushali mohite','mk@gmail.com','pune',222)
insert into studentt values('mayuri kale','mk@gmail.com','nagpur',333)
insert into studentt values('priya matre','pm@gmail.com','hydrabad',444)
insert into studentt values('vibha gahukar','vg@gmail.com','pune',555)
insert into studentt values('sanika kale','sk@gmail.com','nagpur',666)
insert into studentt values('mrunal gajhbhiye','mg@gmail.com','mumbai',777)
insert into studentt values('sayali kapse','sk1@gmail.com','mumbai ',111)

select * from studentt

create table coursee (course_id int,
                    course_name varchar(20)not null,
					course_fees int not null,
					duration_month int);

insert into coursee values(111,'dotnet',65000,'6')
insert into coursee values(444,'java',55000,'10')
insert into coursee values(777,'php',35000,'8')
insert into coursee values(333,'sql',95000,'4')
insert into coursee values(666,'sql',95000,'4')
insert into coursee values(222,'sql',95000,'4')

select * from coursee
select * from studentt where course_id in (select course_id from coursee where course_name='sql')

drop table studentt

drop table coursee



