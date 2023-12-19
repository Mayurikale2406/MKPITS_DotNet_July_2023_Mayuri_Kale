create table product3(product_id int identity primary key,product_name varchar(100) not null,
product_price dec(10,2),constraint positive_price check(product_price>0));
insert into product3 values('facewash',120)
insert into product3 values('lotion',120)
insert into product3 values('',120)
select * from product3
drop table product3