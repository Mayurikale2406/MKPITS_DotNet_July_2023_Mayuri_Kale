create table incometax(income decimal ,taxrate decimal)
insert into incometax values(3,4)
insert into incometax values(5,7)
insert into incometax values(3,2)
select * from incometax
create function calculate_tax2(@income decimal ,@taxrate decimal )
returns decimal
as
begin
return(select @income*@taxrate)
end;
select dbo.calculate_tax2 (income,taxrate) as 'total incometax'from incometax

drop table incometax