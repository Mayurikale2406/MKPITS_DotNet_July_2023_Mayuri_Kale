-------------------------------------order table-------------------------------

create table orders(order_id int primary key identity,
                    customer_id int,
					order_status varchar(20),
					order_date date);
insert into orders values(11,'dispatched','2023-12-23')
insert into orders values(22,'delivered','2023-12-25')
insert into orders values(33,'on the way','2023-12-11')
insert into orders values(44,'not delivered','2023-12-22')
insert into orders values(55,'dispatched','2023-12-14')
insert into orders values(66,'transit','2023-12-8')
insert into orders values(77,'delivered','2023-12-4')
insert into orders values(88,'delivered','2023-12-7')

select * from orders

-----------------------------------customer table--------------------------------------

create table customer(customer_id int,
                      customer_name varchar(20)not null,
					  customer_city varchar(20)not null,
					  customer_email varchar(20)not null);
insert into customer values(22,'sayali kapse','nagpur','sk@email.com')
insert into customer values(44,'vrushali mohite','pune','vm@email.com')
insert into customer values(66,'mayuri kale','mumbai','mk@email.com')
insert into customer values(77,'sayali kapse','mumbai','sk@email.com')
insert into customer values(88,'sanika kale','hydrabad','sk@email.com')

select * from customer

select * from orders where customer_id in (select customer_id from customer 
                                           where customer_email='sk@email.com')

select * from orders where customer_id in (select customer_id from customer 
                                           where customer_city='hydrabad')
