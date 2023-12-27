create table customer(cust_id int ,
                      cust_name varchar(20) not null,
					  cust_email varchar(20)not null,
					  cust_city varchar(20)not null);
insert into customer values(11,'mayuri','mk@gmail.com','nagpur')
insert into customer values(13,'swati','sk@gmail.com','pune')
insert into customer values(15,'sayali','sk@gmail.com','mumbai')
insert into customer values(18,'vrushali','vm@gmail.com','nagpur')
insert into customer values(19,'mrunal','mj@gmail.com','hydrabad')

select * from customer
----------------------------------declare cursor---------------------------------
declare 
@cust_id int,
@cust_name varchar(20),
@cust_email varchar(20),
@cust_city varchar(20);

declare cursor_customer3 cursor
for select
cust_id,
cust_name,
cust_email,
cust_city
from customer
where cust_id>13;
---------------------------open cursor-------------------------------

open cursor_customer3
fetch next from cursor_customer3 into
@cust_id,
@cust_name,
@cust_email,
@cust_city

while @@FETCH_STATUS=0
begin
print @cust_name + cast(@cust_id as varchar)+'' +@cust_email+ '' +@cust_city ;
fetch next from cursor_customer3 into
@cust_id,
@cust_name,
@cust_email,
@cust_city
end;
close cursor_customer3;
deallocate cursor_customer3;

drop table customer
