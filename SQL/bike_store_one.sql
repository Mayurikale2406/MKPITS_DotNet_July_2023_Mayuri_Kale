--------------------------------store table--------------------------
create table store(store_id int identity primary key,
                     store_name varchar(100)not null,
					 phone int,email varchar(100)
					 not null unique,street varchar(100)
					 not null,city varchar(100) not null,
					 state varchar(100),zip_code varchar(6));
insert into store values('Matoshri',9123,'matoshri@gmaul.com',
                          'old subhedar',
                          'Nagpur','Maharashtra','440011')
insert into store values('Rakshak Bandhu',2345,'rkmark@gmail.com',
                          'manewada road',
                          'Nagpur','Maharashtra','567889')

select * from store
drop table store

-----------------------------------staff table-------------------------

create table staffs(staff_id int identity primary key,
                    first_name varchar(20) not null,
					last_name varchar(20),email varchar(20)
					unique,phone int,active varchar(20)not null,
					store_id int,constraint fk21 foreign key(store_id)
					references store(store_id),
					manager_id int);
select * from staffs
insert into staffs values('mayuri','kale',
		                          'mk@gmail.com',1234,
								  'present',2,1)
insert into staffs values('vrushali','mohite',
		                          'vm@gmail.com',2345,
								  'absent',1,3)
select * from staffs
drop table staffs

------------------------category table--------------------------------

create table categories(category_id int identity primary key,
                        category_name varchar(100)not null);
insert into categories values('cycle')
insert into categories values('electric bike')
insert into categories values('scooter')
select * from categories

drop table categories


---------------------------brand table-------------------------

create table brand(brand_id int identity primary key,
                   brand_name varchar(100)not null);
insert into brand values('lady bird')
insert into brand values('ola bike')
insert into brand values('vespa')

select * from brand

---------------product table---------------------------------
CREATE TABLE products33 (product_id int identity primary key,
	                   product_name varchar(255) NOT NULL,
					   brand_id int NOT NULL,
					   category_id int NOT NULL,
					   model_year int NOT NULL,
					   list_price int NOT NULL ,constraint fk5
					   
					   FOREIGN KEY (category_id) 
					   REFERENCES categories(category_id));
	                   
insert into products33 values('break',1,1,2023,500)
insert into products33 values('battery',2,2,2022,600)
insert into products33 values('cluch',3,3,2021,400)


select * from products33
drop table products33

----------------------------customer-----------------------------

create table customer10(customer_id int identity primary key,
                       first_name varchar(100)not null,last_name varchar(100)not null,
					   phone varchar(20)not null,email varchar(20) not null,
					   street varchar(20)not null,city varchar(20) not null,
					   state_name varchar(20)not null,zip_code varchar(20));

insert into customer10 values('sayali','kapse','098765432','sk@gmail.com',
                               'nandanwan','nagpur','maharashtra',440055)
insert into customer10 values('mrunal','gajhbhiye','1234567890','mg@gmail.com',
                               'chatrapati square','nagpur','maharashtra',440067)

select * from customer10

-----------------------------orders------------------------------------

create table orders1(order_id int identity primary key,
                    customer_id int,
					order_status varchar(100)not null,
					order_date date,
					required_date date,
					shipped_date date,
					store_id int not null,
					staff_id int not null,
					constraint fk6
					foreign key(customer_id)references customer10(customer_id),
					constraint fk7
					foreign key (store_id)references store(store_id),
					constraint fk8
					foreign key(staff_id)references staffs(staff_id));

select * from orders1

insert into orders1 values(1,'delivered','2023-08-11','2023-10-11','2023-09-08',1,1)
insert into orders1 values(2,'delivered','2023-09-11','2023-10-11','2023-09-08',2,2)
select * from orders1

drop table orders1

------------------------------order item-------------------------------------

create table order_item(order_id int identity,
                        item_id int,
						product_id int,
						quantity int not null,
						list_price int not null,
						discount int not null,
						foreign key(order_id)references orders1(order_id),
						foreign key(product_id)references products33(product_id));
select * from order_item

 insert into order_item values(22,2,5,400,200)
 insert into order_item values(23,2,6,300,200)

 select * from order_item

drop table order_item

---------------------------------------stocks-----------------------------

create table stock(store_id int,product_id int,quantity int,
                    foreign key (store_id)references store (store_id),
					foreign key(product_id)references products33(product_id));
insert into stock values(1,2,3)
insert into stock values(2,3,5)

select * from stock

------------------------------------------------------------------
select * from store
select * from staffs
select * from categories
select * from brand
select * from products33
select * from customer10
select * from orders1
select * from order_item
select * from stock