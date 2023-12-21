create table customerr(cust_id int primary key,
                     cust_name varchar(20),
					 cust_city varchar(20),
					 cust_age int);
insert into customerr values(11,'amit','nagpur',22)
insert into customerr values(22,'mansi','pune',43)
insert into customerr values(44,'priya','nagpur',23)
insert into customerr values(55,'prachi','mumbai',21)
insert into customerr values(78,'mayuri','banglore',25)
insert into customerr values(88,'vrushali','bhandara',26)

select * from customerr

create table product(product_id int primary key identity
                     ,cust_id int,product_name varchar(20),quantity int,rate int);
insert into product values(22,'shampoo',2,300)
insert into product values(78,'hairoil',4,500)
insert into product values(55,'hairserum',2,270)

-------------------------------left join query--------------------------------------
select * from customerr left outer join product on customerr.cust_id=product.cust_id

-------------------------------right join query-------------------------------------

select * from customerr right outer join product on customerr.cust_id=product.cust_id

-------------------------------full outer join--------------------------------------

select * from customerr full outer join product on customerr.cust_id=product.cust_id