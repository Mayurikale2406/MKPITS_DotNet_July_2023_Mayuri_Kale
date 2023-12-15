create table salesmann(ord_no int,purch_amt int,ord_date date,customer_id int,salesman_id int)
insert into salesmann values(70001,150.5 ,'2012-10-05' ,3005 , 5002)
insert into salesmann values(70009,270.65, '2012-09-10',3001 , 5005)
insert into salesmann values(70004,110.5, '2012-08-17',3009 , 5003)
insert into salesmann values(70009, 270.65,'2012-09-10',3001, 5005)
insert into salesmann values(70004, 110.5,  '2012-08-17',3009 ,5003)
insert into salesmann values(70004, 110.5,'2012-08-17', 3009 ,5003)
select ord_date,salesman_id,ord_no,purch_amt,customer_id from salesmann
select distinct ord_no from salesmann


