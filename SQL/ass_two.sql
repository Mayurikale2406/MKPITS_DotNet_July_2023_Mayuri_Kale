create table customer1(customer_id int primary key,
                      cust_name varchar(20)not null,
					  city varchar(20)not null,
					  grade int,salesman_id int);
insert into customer1 values(3002,'Nick Rimando','New York',100,5001)
insert into customer1 values(3007,'Brad Davis','New York',200,5001)
insert into customer1 values(3005,'Graham Zusi','California',200,5002)
insert into customer1 values(3008,'Julian Green','London',300,5002)
insert into customer1 values(3004,'Fabian Johnson','Paris',300,5006)
insert into customer1 values(3009,'Geoff Cameron','Berlin',100,5003)
insert into customer1 values(3003,'Jozy Altidor','Moscow',200,5007)
insert into customer1 values(3001,'Brad Guzan','London',400,5005)

select* from customer1

---------------------------------salesman table--------------------

create table salesman1(salesman_id int primary key,
                       salesman_name varchar(20)not null,
					   city varchar(20),commision float);
insert into salesman1 values(5001,'James Hoog','New York',0.15)
insert into salesman1 values(5002,'Nail Knite','Paris',0.13)
insert into salesman1 values(5005,'Pit Alex','London',0.11)
insert into salesman1 values(5006,'Mc Lyon','Paris',0.14)
insert into salesman1 values(5003,'Lauson Hen','San Jose',0.12)
insert into salesman1 values(5007,'Paul Adam','Rome',0.13)
select*from salesman1

------------------------order table--------------------------

create table orders1(ord_no int primary key,
                    purch_amt float,
                    ord_date date,
					customer_id int,
					salesman_id int)
insert into orders1 values(70001,150.5,'2012-10-05',3005,5002)
insert into orders1 values(70009,270.65,'2012-09-10',3001,5005)
insert into orders1 values(70002,65.26,'2012-10-05',3002,5001)
insert into orders1 values(70004,110.5,'2012-08-17',3009,5003)
insert into orders1 values(70007,948.5,'2012-09-10',3005,5002)
insert into orders1 values(70005,2400.6,'2012-07-27',3007,5001)
insert into orders1 values(70008,5760,'2012-09-10',3002,5001)
insert into orders1 values(70010,1983.43,'2012-10-10',3004,5006)
insert into orders1 values(70003,2480.4,'2012-10-10',3009,5003)
insert into orders1 values(70012,250.45,'2012-06-27',3008,5002)
insert into orders1 values(70011,75.29,'2012-08-17',3003,5007)
insert into orders1 values(70013,3045.6,'2012-04-25',3002,5001)
select * from orders1

select * from orders1 where salesman_id=(select salesman_id from 
                salesman1 where salesman_name ='Paul Adam'); 

select*from orders1
WHERE salesman_id IN
    (SELECT salesman_id 
     FROM salesman1 
     WHERE city='London');

SELECT *
FROM orders1
WHERE salesman_id =
    (SELECT DISTINCT salesman_id 
     FROM orders1 
     WHERE customer_id =3007);
