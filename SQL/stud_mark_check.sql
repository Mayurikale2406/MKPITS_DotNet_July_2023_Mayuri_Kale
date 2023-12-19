create table mark(stud_rno int identity primary key,stud_name varchar(100)
not null,stud_mark dec(10,3) check(stud_mark>0));
select * from mark
insert into mark values('vrushali',80)
insert into mark values('mayuri',70)

select * from mark
drop table mark

