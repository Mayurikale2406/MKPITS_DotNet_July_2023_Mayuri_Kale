create table store1(store_id int identity primary key,
                     store_name varchar(100)not null,
					 phone int,email varchar(100)
					 not null unique,street varchar(100)
					 not null,city varchar(100) not null,
					 state varchar(100),zip_code varchar(6));
insert into store1 values('Matoshri',9123,'matoshri@gmaul.com',
                          'old subhedar',
                          'Nagpur','Maharashtra','440011')
insert into store1 values('Rakshak Bandhu',2345,'rkmark@gmail.com',
                          'manewada road',
                          'Nagpur','Maharashtra','567889')

select * from store1
drop table store