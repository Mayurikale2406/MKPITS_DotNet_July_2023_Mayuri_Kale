create proc prod7(@minp as decimal,@maxp as decimal)
as
begin
select * from products33
where list_price > @minp and list_price < @maxp
order by model_year
end;

exec prod7 120,500
 