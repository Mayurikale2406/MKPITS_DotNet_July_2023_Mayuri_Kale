create table customer(cust_id int,cust_name varchar(20),city varchar(20),grade varchar(20),salesman_id int)
select*from customer
insert into customer values(3002,'Nick Rimando','New York',100,5001)
insert into customer values(3007,'Brad Davis', 'New York' ,200 ,5001)
insert into customer values(3005,'Graham Zusi','California',200,5002)
insert into customer values(3008,'Julian Green','London',300,5002)
insert into customer values(3004,'Fabian Johnson','Paris',300,5006)
insert into customer values(3009,'Geoff Cameron','Berlin',100,5003)
insert into customer values(3003, 'Jozy Altidor','Moscow',200,5007)

select * from customer
select * from customer where grade=200
drop table customer
