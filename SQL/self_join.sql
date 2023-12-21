create table eemployee(emp_id int identity primary key,
                      emp_name varchar(20),
					  emp_salary bigint,
					  emp_city varchar(20));
insert into eemployee values ('mayuri',20000,'nagpur'),
                             ('sayali',30000,'pune'),
							 ('vrushali',20000,'nagpur'),
							 ('prachi',20000,'mumbai'),
							 ('trishala',10000,'pune'),
							 ('priya',32000,'mumbai')

select * from eemployee
select S1.emp_name, S2.emp_salary, S2.emp_city  
 from eemployee S1, eemployee S2  
 where S1.emp_id <> S2.emp_id AND S1.emp_city = S2.emp_city  
 order by S2.emp_city  

  drop table eemployee
