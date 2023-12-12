create table studentt(rno int primary key,studname varchar(20),studemailid varchar(20), studAdd varchar(20))
insert into  studentt values(1,'mayuri','mayu@gmail.com','Nagpur')
insert into  studentt values(2,'sayali','sayali@gmail.com','mumbai')
insert into  studentt values(5,'vrushali','vrushali@gmail.com','pune')
insert into  studentt values(7,'priya','priya@gmail.com','Nagpur')
insert into  studentt values(3,'prachi','prachi@gmail.com','Nagpur')
select * from studentt order by studname desc
select * from studentt order by rno  desc


