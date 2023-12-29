--------------------nation table-----------------------

create table TableNation(NationID int primary key,
                         NationName varchar(500))
insert into TableNation values(15,'India')
insert into TableNation values(12,'Nepal')
insert into TableNation values(13,'New Zealand')
insert into TableNation values(14,'Austrellia')

select * from TableNation
drop table TableNation

--------------------------table state-------------------------
create table TableState(StateID int primary key,
                        NationID int,
						StateName varchar(500),
						constraint fk1
						foreign key(NationID)references TableNation
						(NationID));
insert into TableState values(111,15,'Maharashtra')
insert into TableState values(222,12,'Bagmati')
insert into TableState values(333,13,'Northland')
insert into TableState values(444,14,'Victoria')
select * from TableState
drop table TableState

----------------------table city---------------------

create table TableCity1(CityID int primary key,
                       StateID int,
					   CityName varchar(500),
					   constraint fk2
					   foreign key (StateID) references
					   TableState (StateID));
insert into TableCity1 values(123,111,'Nagpur')
insert into TableCity1 values(234,222,'Kathmandu')
insert into TableCity1 values(456,333,'Auckland')
insert into TableCity1 values(678,444,'Hobart')
select * from TableCity1

-------------------table course details-------------------

create table TableCourseRegDetail(CourseRegID int primary key,
                                   CategoryID int,
								   FullName varchar(1500),
								   GenderID int);
insert into TableCourseRegDetail values(99,2,'Mayuri Kale',09)
insert into TableCourseRegDetail values(88,3,'Lee Min',08)
insert into TableCourseRegDetail values(77,4,'Robert',07)
insert into TableCourseRegDetail values(66,5,'Maxwell',06)
select * from TableCourseRegDetail
drop table TableCourseRegDetail

----------------------table reg address------------------

create table TableRegAddress(RegAddressID int primary key,
                             CourseRegID int,
							 NationID int,
							 StateID int,
							 CityID int,
							 foreign key(CourseRegID)references
							 TableCourseRegDetail(CourseRegID),
							 constraint fk3
							 foreign key(NationID)references
							 TableNation(NationID),
							 constraint fk4
							 foreign key(StateID)references
							 TableState1(StateID),
							 constraint fk5
							 foreign key(CityID)references
							 TableCity1(CityID));

insert into TableRegAddress values(55,99,15,111,123)
insert into TableRegAddress values(66,88,12,222,234)
insert into TableRegAddress values(77,77,13,333,456)
insert into TableRegAddress values(88,66,14,444,678)

select * from TableRegAddress
-------------------table fee details---------------------------

create table TableFeeDetail(FeeID int primary key,
                            CourseRegID int,
							TotalAmount Decimal,
							MinPer decimal,
							PaidAmount Decimal,
							BalAmount Decimal,
							PaidDate DateTime)
insert into TableFeeDetail values(01,2406,500,50,200,300,'2023-12-11')
insert into TableFeeDetail values(02,2407,1000,70,500,500,'2023-12-11')
insert into TableFeeDetail values(03,2408,1200,80,1000,200,'2023-12-11')
insert into TableFeeDetail values(04,2409,1500,30,1200,300,'2023-12-11')
select * from TableFeeDetail
drop table TableFeeDetail

select * from TableNation
select * from TableState
select * from TableCity1
select * from TableCourseRegDetail
select * from TableRegAddress
select * from TableFeeDetail
