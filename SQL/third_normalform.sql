---------------------------teacher form-------------------
create table teachers1(teacher_id int,
                      teacher_name varchar(500),
					  state_id int, primary key
					  (teacher_id,state_id));
insert into teachers1 values(1,'amit',11)
insert into teachers1 values(2,'raj',11)
insert into teachers1 values(3,'amita',12)
select * from teachers1
drop table teachers1
-----------------state table-----------------------

create table states(state_id int ,
                   state_name varchar(500),
                   country_id int,primary key(state_id,country_id))
insert into states values(11,'maharashtra',101)
insert into states values(13,'mp',101)
select * from states
drop table states
--------------------country table-----------------

create table country(country_id int,
                     country_name varchar(500));
insert into country values(101,'india')
insert into country values(102,'shrilanka')
select * from country

--------------------------------

select * from teachers
select * from states
select * from country
