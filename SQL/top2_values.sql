create table product1(productName varchar(20),price bigint)
insert into product1 values ('keyboard',2000)
insert into product1 values('laptop',50000)
insert into product1 values('mouse',1000)
insert into product1 values('desktop',2000)
insert into product1 values('RAM',500)
insert into product1 values('SSD', 800)
select top 2 productName,price from product order by price desc

