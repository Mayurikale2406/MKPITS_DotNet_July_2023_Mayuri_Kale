create table product1(product_id int identity primary key,
                     product_name varchar(20),
					 product_year int,
					 product_quantity int,
					 product_price int);

insert into product1 values('computer',2020,130,50000)
insert into product1 values('computer',2020,450,35000)
insert into product1 values('computer',2020,250,40000)
insert into product1 values('Hard Disk',2020,190,5500)
insert into product1 values('computer',2021,250,450000)
insert into product1 values('Hard Disk',2021,550,4400)
insert into product1 values('Hard Disk',2021,650,7500)
insert into product1 values('pen drive',2021,120,800)
insert into product1 values('mouse',2019,160,1500)
insert into product1 values('pen drive',2019,270,1200)

select * from product1
-------------------min function order by---------------------------
 
select product_name,min(product_price)as"minimun price"
from product1 
group by product_name
having min(product_price)>1000;

-----------------max function order by------------------------------

select product_name,min(product_price)as"minimum price"
from product1
group by product_name
having max(product_price)>50000

drop table product1
