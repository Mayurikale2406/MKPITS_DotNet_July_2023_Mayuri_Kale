----------------------------------------sales table-------------------------------------
create table sales(sale_id int primary key identity,
                   customer_name varchar(20),
				   sale_amount int,
				   quantity int);
insert into sales values('mayuri kale',2000,2)
insert into sales values('mayuri kale',3000,2)
insert into sales values('mayuri kale',8000,2)
insert into sales values('mayuri kale',10000,2)
insert into sales values('mayuri kale',6000,2)
insert into sales values('mayuri kale',25000,2)
insert into sales values('mayuri kale',34000,2)
insert into sales values('mayuri kale',1000,2)

select * from sales

create proc sale1(@sale_amount int)
as
begin
select * from sales
where sale_amount>1000
end;
exec sale1 1000


create proc sale2(@sale_amount int)
as
begin
select * from sales
where sale_amount<10000
end;
exec sale1 10000

drop proc sale2


