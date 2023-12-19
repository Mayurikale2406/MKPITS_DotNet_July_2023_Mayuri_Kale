create table product2(product_id int identity primary key,product_name varchar(100)
not null,product_price dec(10,2)CHECK(product_price>0));
select * from product2
insert into product2 values ('facewash',120)
insert into product2 values('lotion',0)
select * from product2
drop table product2
