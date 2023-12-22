select * from products33
alter procedure
as
begin
select product_name,list_price from products33
order by list_price
end;