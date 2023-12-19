create table product3 (product_id int identity primary key,product_name varchar (100)not null,
product_price dec (10,3),discount_price dec (10,3),check (product_price>0),check (discount_price>0),
check(product_price>discount_price));
insert into product3 values('Laptop',120,100)
insert into product3 values('RAM',200,100)
insert into product3 values('Processor',300,200)

select * from product3
drop table product3