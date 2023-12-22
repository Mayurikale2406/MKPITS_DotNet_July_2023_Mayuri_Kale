create proc prod3(@minprice as decimal)
as
begin
select * from products33
where list_price < @minprice
order by list_price
end;
exec prod3 120

drop proc prod3

