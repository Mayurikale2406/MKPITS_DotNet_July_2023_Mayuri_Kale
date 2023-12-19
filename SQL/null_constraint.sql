create table product10(product_id int identity primary key,product_name varchar(100)not null,
product_price dec (10,3)constraint positive4_price check(product_price>0),
discount_price dec (10,3) check(discount_price>0) );

insert into product10 values('water bottle',1000,null)

select * from product10