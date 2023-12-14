create table customerr (custname varchar(20),sername varchar(20),custid int )
insert into customerr values('mayuri', 'Kale', 12)
insert into customerr values('vrushali','mohite',13)
insert into customerr values('sayali','kapse',14)
insert into customerr values('mayuri','matre',15)
insert into customerr values('chetan','raut',17)
insert into customerr values('mayuri','kale',16)

select custname ,sername , custid  from customerr order by LEN(custname) 
