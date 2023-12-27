create table product(product_id int primary key identity,
                     product_name varchar(20)not null,
					 brand_id int,
					 model_year decimal,
					 list_price decimal);
insert into product values('vespa',111,2021,20000)
insert into product values('bike',122,2020,30000)
insert into product values('car',199,2019,50000)
insert into product values('electric bike',987,2018,40000)

select * from product
drop table product
Declare
@product_name varchar(50),
@list_price decimal;
declare cursor_product cursor
for select
product_name,
list_price
from product;

------------------------open cursor---------------------
open cursor_product;

-------------------fetch cursor-------------------------
fetch next from cursor_product into
@product_name,
@list_price;
while @@FETCH_STATUS=0
begin
print @product_name + cast(@list_price as varchar)
fetch next from cursor_product into
@product_name,
@list_price;
end;

----------------------close cursor---------------------

close cursor_product;
-----------------------deallocate cursor-----------------

deallocate cursor_product;

