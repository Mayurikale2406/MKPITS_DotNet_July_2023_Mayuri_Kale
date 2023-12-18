create table vendors_groupss(group_id int identity primary key,group_name varchar(100)not null);
select * from vendors_groupss

create table vendorss1(vendors_id int identity primary key,vendors_name varchar(100)not null,
group_id int not null,constraint fk_group foreign key(group_id)references vendors_groupss(group_id));

insert into vendors_groupss values('chennai super kings')
insert into vendors_groupss values('mumbai indians')
insert into vendors_groupss values('rajashtan')
insert into vendors_groupss values('kolkata')


insert into vendorss1(vendors_name,group_id)values('sayali',5)
insert into vendorss1(vendors_name,group_id)values('prachi',2)
insert into vendorss1(vendors_name,group_id)values('priya',3)
insert into vendorss1(vendors_name,group_id)values('mrunal',4)
select * from vendorss1

drop table vendorss1
drop table vendors_groupss

