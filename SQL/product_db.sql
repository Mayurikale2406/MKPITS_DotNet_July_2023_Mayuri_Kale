create table product(product_id int primary key,product_name varchar(20));
insert into product values(11,'facewash')
insert into product values(22,'lotion')
insert into product values(33,'lipstick')
insert into product values(44,'facewash')
select * from product
drop table product

create table product_details(product_quantity int,
                             product_rate int,
							 product_id int foreign key
							 );
insert into product_details