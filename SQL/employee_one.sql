create table Employee(emp_id int ,
                      emp_name varchar(20) not null,
					  emp_zip int primary key)
insert into Employee values(222,'harry',201010)
insert into Employee values(333,'stephan',02228)
insert into Employee values(444,'lan',60007)
insert into Employee values(555,'katharine',06389)
select * from Employee
drop table Employee

create table employee_zip(emp_zip int,
                          emp_state varchar(20),
						  emp_city varchar(20)
						  constraint fk5
						  foreign key(emp_zip)
						  references Employee(emp_zip));
insert into employee_zip values(201010,'UP','Noida')
insert into employee_zip values(02228,'US','Boston')
insert into employee_zip values(201010,'US','Chicago')
insert into employee_zip values(201010,'UK','Norwich')
select * from 

