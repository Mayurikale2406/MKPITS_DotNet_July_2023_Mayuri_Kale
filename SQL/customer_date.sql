create table customer1(cust_id int,cust_name varchar(20),join_date date,city varchar(20),grade varchar(20),salesman_id int)
select*from customer1
insert into customer1 values(3002,'Nick Rimando','2023-4-5','New York',100,5001)
insert into customer1 values(3007,'Brad Davis','2023-5-9', 'New York' ,200 ,5001)
insert into customer1 values(3005,'Graham Zusi','2023-4-8','California',200,5002)
insert into customer1 values(3008,'Julian Green','2023-6-11','London',300,5002)
insert into customer1 values(3004,'Fabian Johnson','2023-9-12','Paris',300,5006)
insert into customer1 values(3009,'Geoff Cameron','2023-7-15','Berlin',100,5003)
insert into customer1 values(3003, 'Jozy Altidor','2023-9-18','Moscow',200,5007)

select * from customer1
select * from  customer1  where salesman_id<5001
drop table customer1
