------------------------------product table-------------------------
create table product(product_id int primary key,
                     product_name varchar(20),
					 product_rate int,
					 product_quantity int);
insert into product values(1,'facewash',100,10)
insert into product values(2,'body lotion',200,20)
insert into product values(3,'cleansing milk',250,10)
insert into product values(4,'lipstick',220,20)

select * from product
drop table product

----------------------------customer table------------------------------

create table customer(cust_id int primary key,
                      cust_name varchar(20),
                      cust_city varchar(20),
					  cust_state varchar(20));
insert into customer values(101,'amit','nagpur','maharashtra')
insert into customer values(201,'amita','mumbai','maharashtra')
insert into customer values(301,'amitabh','pune','maharashtra')
insert into customer values(401,'amitsha','shambhaji nagar','maharashtra')

select * from customer

------------------------------order table--------------------------------

create table order2(order_id int,
                  order_status varchar(20),
                  product_id int,
				  order_date date,
				  foreign key(product_id)references product(product_id));
insert into order2 values(1,'delivered',2,'2023-12-13')
insert into order2 values(2,'transit',3,'2023-12-11')
insert into order2 values(3,'shipped',4,'2023-12-11')
insert into order2 values(4,'transit',1,'2023-12-11')

select * from order2



select * from product
select * from customer
select * from order2