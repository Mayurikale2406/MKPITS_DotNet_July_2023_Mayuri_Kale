create table stud(stud_id int identity primary key,
                      admission_id int,
                    stud_name varchar(20)not null,
					stud_age int,stud_city varchar(20));
insert into stud values(222,'onkar kale',24,'nagpur')
insert into stud values(333,'vrushali mohite',25,'pune')
insert into stud values(444,'sayali kapse',26,'bhandara')
insert into stud values(555,'mayuri kale ',22,'nagpur')
insert into stud values(666,'prachi dahiwale',24,'bhandara')

select * from stud
drop table stud

create table stud_mark(sub_name varchar(20),
                      mark int,
                      admission_id int);

insert into stud_mark values('physics',80,444)
insert into stud_mark values('science',70,555)
insert into stud_mark values('maths',60,222)

select * from stud cross join stud_mark where stud.admission_id=stud_mark.admission_id