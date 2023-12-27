create table product(product_id int,
                     product_name varchar(20)not null,
					 product_quantity int,
					 stock_quantity int);

create table productlog(product_id int,
                     product_name varchar(20)not null,
					 operation varchar(20),
					 updatedate datetime,
					 stock_quantity int);

create trigger trr2
on product
after update
as
insert into productlog(product_id,operation,updatedate)
select product_id,'update',GETDATE()from deleted

insert into product values(111,'keyboard',20,10)
insert into product values(222,'USB cable',20,10)
insert into product values(444,'laptop',20,10)
insert into product values(555,'screen guard',20,10)
select * from product
select * from productlog
update product set product_name ='mouse' where product_id=111

drop table product
drop table productlog

