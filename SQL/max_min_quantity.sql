create table product(product_id int identity primary key,
                     product_name varchar(20),
					 product_year int,
					 product_quantity int,
					 product_price int);
insert into product values('computer',2020,130,50000)
insert into product values('computer',2020,450,35000)
insert into product values('computer',2020,250,40000)
insert into product values('Hard Disk',2020,190,5500)
insert into product values('computer',2021,250,450000)
insert into product values('Hard Disk',2021,550,4400)
insert into product values('Hard Disk',2021,650,7500)
insert into product values('pen drive',2021,120,800)
insert into product values('mouse',2019,160,1500)
insert into product values('pen drive',2019,270,1200)

select * from product
-----------------------------max quantity-----------------------
select product_name,product_quantity,product_price
from product
where product_price = (select max(product_price)
as
"minimum quantity"
from product)

-----------------------------min quantity---------------------------
select product_name,product_quantity,product_price
from product
where product_price = (select min(product_price)
as
"minimum quantity"
from product)
drop table product