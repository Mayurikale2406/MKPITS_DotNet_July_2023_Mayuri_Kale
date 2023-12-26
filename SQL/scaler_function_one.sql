create table incometax(m1 int,m2 int,m3 int)
insert into incometax values(3,4,5)
insert into incometax values(5,7,8)
insert into incometax values(3,2,1)
select * from incometax
create function calculate_tax1(@m1 int ,@m2 int ,@m3 int)
returns int
as
begin
return(select @m1+@m2+@m3)
end;
select dbo.calculate_tax1 (m1,m2,m3) as 'total incometax'from incometax

drop table incometax