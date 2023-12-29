-----------------------table product details---------------------
create table TableProductGSTDetails(Product_Gst_ID int primary key,
                                    Gst_Detail_Name varchar(500),
									CGST Decimal,
									SGST Decimal,
									IGST Decimal);
insert into TableProductGSTDetails values(11,'mayuri',121,123,124)
insert into TableProductGSTDetails values(12,'maxwell',123,124,122)
insert into TableProductGSTDetails values(13,'leemin',124,125,129)
insert into TableProductGSTDetails values(14,'warner',125,126,128)
select * from TableProductGSTDetails

-------------------table product category-------------------

create table TableProductCategory(Product_Category_ID int primary key,
                                  Product_Type_Name varchar(500),
								  Product_Gst_ID int,
								  constraint fk1
								  foreign key (Product_Gst_ID)
								  references TableProductGSTDetails
								  (Product_Gst_ID));
insert into TableProductCategory values(111,'myntra',11)
insert into TableProductCategory values(121,'flipkart',12)
insert into TableProductCategory values(112,'amazon',13)
insert into TableProductCategory values(100,'shopsy',14)
select * from TableProductCategory
drop table TableProductCategory

---------------------table product----------------------------

create table TableProduct(ProductID int primary key,
                          ProductTypeID int,
						  ProductName varchar(500));
insert into TableProduct values(2001,211,'Shirt')
insert into TableProduct values(2002,311,'Steel')
insert into TableProduct values(2003,411,'Electronics product')
insert into TableProduct values(2004,511,'Artificial Flower')
select * from TableProduct

---------------------------table invoice details-------------------

create table TableInvoiceDetails(Invoice_Detail_ID int primary key,
                                 Customer_Name varchar(500),
								 Customer_Contact varchar(15),
								 Product_Category_ID int,
								 ProductID int,
								 Residential_Type_ID int,
								 Invoice_Date DateTime,
								 Quantity Decimal,
								 Price Decimal,
								 CGST Decimal,
								 SGST Decimal,
								 IGST Decimal,
								 CGST_value Decimal,
								 SGST_value Decimal,
								 IGST_value Decimal,
								 TotalAmount Decimal,
								 constraint fk4
								 foreign key(Product_Category_ID)
								 references TableProductCategory
								 (Product_Category_ID),
								 constraint fk5
								 foreign key(ProductID)
								 references TableProduct
								 (ProductID));
insert into TableInvoiceDetails values(098,'vrushali',09876,111,
                                       2001,56,'2023-09-12',3,500,
									   8,9,10,11,12,13,1000)
insert into TableInvoiceDetails values(087,'priya',09874,121,
                                       2002,56,'2023-09-13',3,500,
									   2,3,4,14,16,17,9000)
insert into TableInvoiceDetails values(067,'vrushali',09856,112,
                                       2003,56,'2023-09-14',3,500,
									   9,10,11,12,13,14,8000)
insert into TableInvoiceDetails values(045,'vrushali',09834,100,
                                       2004,56,'2023-09-15',3,500,
									   10,11,12,15,10,17,6000)
select * from TableInvoiceDetails

select * from TableProductGSTDetails
select * from TableProductCategory
select * from TableProduct
select * from TableInvoiceDetails