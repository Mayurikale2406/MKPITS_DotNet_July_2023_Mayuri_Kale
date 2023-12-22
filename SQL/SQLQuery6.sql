create table studentt(rno int primary key identity,
                     stud_name varchar(20),
					 stud_email varchar(20),
					 stud_city varchar(20),
					 course_id int,
					 stud_birth_date date);
insert into studentt values('sayali kapse','sk@gmail.com','nagpur',111,'2001-6-22')
insert into studentt values('vrushali mohite','mk@gmail.com','pune',222,'2000-3-22')
insert into studentt values('mayuri kale','mk@gmail.com','nagpur',333,'2000-12-14')
insert into studentt values('priya matre','pm@gmail.com','hydrabad',444,'1999-1-28')
insert into studentt values('vibha gahukar','vg@gmail.com','pune',555,'2001-1-29')
insert into studentt values('sanika kale','sk@gmail.com','nagpur',666,'2006-9-28')
insert into studentt values('mrunal gajhbhiye','mg@gmail.com','mumbai',777,'2000-8-11')
insert into studentt values('sayali kapse','sk1@gmail.com','mumbai ',111,'2001-8-9')

select * from studentt


drop table studentt