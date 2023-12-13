create table student (Name varchar(20),Rno int primary key, City varchar(20))
insert into student values ('mayuri', 12 , 'Nagpur')
insert into student values ('vrushali', 13 , 'Nagpur')
insert into student values ('sayali', 14 , 'Pune')
insert into student values ('priya', 15 , 'Amravati')
select * from student
select name,count(*)from student where city <> 'nagpur'group by name order by name 