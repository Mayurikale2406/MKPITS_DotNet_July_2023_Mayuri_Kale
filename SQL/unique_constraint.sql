create table customer12(cust_id int identity primary key,cust_firstName
                        varchar(100) not null, cust_lastName varchar (100) not null,
                        cust_emailid varchar(100) constraint unique_email unique(cust_emailid));
alter table customer12 add cust_age int null default 10
insert into customer12 values('mayuri','kale','m@gmail.com',11)
insert into customer12 values('vrushali','mohite','v@gmail.com',12)
select * from customer12