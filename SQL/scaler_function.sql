create table employe(emp_name varchar(20)not null,
                      emp_occupation varchar(20),
					  working_date date,
					  working_hours float,
					  emp_salary int,
					  emp_city varchar(20));
insert into employe values('jolly evans','HR','2020-10-04',9,25000,'nagpur')
insert into employe values('brayden simmons','engineer','2020-10-04',12,65000,'pune')
insert into employe values('rose huges','writer','2020-10-04',13,35000,'nagpur')
insert into employe values('laura paul','manager','2020-10-04',10,25000,'pune')
insert into employe values('jolly evans','teacher','2020-10-04',12,45000,'mumbai')
insert into employe values('jolly evans','writer','2020-10-04',13,30000,'pune')
insert into employe values('jolly evans','manager','2020-10-04',10,35000,'mumbai')
insert into employe values('jolly evans','writer','2020-10-04',9,42000,'nagpur')
insert into employe values('jolly evans','writer','2020-10-04',12,38000,'nagpur')
insert into employe values('jolly evans','HR','2020-10-04',11,30000,'pune')

select * from employe

create function emp2
    (  
       @emp_name varchar(50),  
       @emp_occupation varchar(50),  
       @emp_City varchar(50)  
    )  
    returns varchar(150)  
    as  
    begin return(select @emp_name+ ' ' +@emp_occupation + ' ' + @emp_City)  
    end  

select dbo.emp2(emp_name,emp_occupation,emp_city) as 'detail' from employe


drop table employe