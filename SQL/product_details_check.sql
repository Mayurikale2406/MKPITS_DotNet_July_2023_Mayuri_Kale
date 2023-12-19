create table product11(product_id int identity primary key,product_name varchar(100)not null,
product_price dec (10,3)constraint positive1_price check(product_price>0),
discount_price dec (10,3) check(discount_price>0) );
select * from product11
insert into product11 values('table fan',Null,450)
insert into product11 values('Tv',1000,900)
insert into product11 values ('AC',800,500)
select * from product11
