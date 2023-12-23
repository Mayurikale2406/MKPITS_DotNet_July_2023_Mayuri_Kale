select * from products33
alter procedure products33(@min_list_price as decimal,@max_list_price as decimal)
as
begin
select product_name,list_price from products33 where
list_price >= @min_list_price AND
list_price <= @max_list_price
ORDER BY
list_price;
END;

