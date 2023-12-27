create table product2(product_id int,product_name varchar(20),
                     product_price int,product_quantity int);
insert into product2 values(111,'keyboard',500,2)
insert into product2 values(222,'mouse',300,3)
insert into product2 values(222,'laptop',1000,3)
insert into product2 values(222,'USB cable',100,5)

select * from product2
drop table product2
-------------------------------------declare cursor-------------------------------------------------
declare
@product_id int,
@product_name varchar(20),
@product_price int,
@product_quantity int

declare cursor_product2 cursor
for select
product_id,
product_name,
product_price,
product_quantity
from product2
where product_price>300 
------------------------------------open cursor---------------------------------
open cursor_product2
fetch next from cursor_product2 into
@product_id,
@product_name,
@product_price,
@product_quantity

while @@FETCH_STATUS=0
begin
print @product_name+ ''+ cast (@product_id as varchar) + '' + cast(@product_price as varchar)+ '' +cast(@product_quantity as varchar)
fetch next from cursor_product2 into
@product_id,
@product_name,
@product_price,
@product_quantity
end;

close cursor_product2;
deallocate cursor_product2;

