create table customer (cust_id int primary key identity,
                       cust_name varchar (20)not null,
					   mob_no varchar(10) not null)
insert into customer values('mayuri kale','2345678901')
insert into customer values('vrushali mohite','1234567890')
insert into customer values('sayali kapse','3456789012')
insert into customer values('priya matre','1245789032')

select * from customer

create table orders(order_id int primary key identity,
                    order_date date,cust_id int,
					product_name varchar(20)not null,
					quantity int,rate int);

insert into orders values('2023-5-21',1,'facewash',4,120)
insert into orders values('2023-4-12',3,'body lotion',3,100)
insert into orders values('2023-2-12',4,'lipstick',1,300)

select * from customer inner join orders on customer.cust_id=orders.cust_id