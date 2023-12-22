create table orders1(order_id int primary key identity,
                     cust_id int,order_date date,
					 product_name varchar(20),
					 quantity int,rate int);
insert into orders1 values(122,'2023-09-11','router',1,1200)
insert into orders1 values(133,'2023-08-9','MI Tv',2,12000)
insert into orders1 values(144,'2023-09-11','AC',6,13000)
insert into orders1 values(155,'2023-11-12','FAN',4,16000)
insert into orders1 values(166,'2023-08-7','Projector',2,18000)
insert into orders1 values(177,'2022-08-18','Oven',7,20000)
insert into orders1 values(188,'2022-10-20','laptop',9,11000)
insert into orders1 values(199,'2022-11-11','heater',5,10000)
insert into orders1 values(111,'2023-12-14','AC',3,19000)
insert into orders1 values(777,'2023-08-11','MI Tv',1,15000)

select * from orders1

select * from orders1 where cust_id>order_id


