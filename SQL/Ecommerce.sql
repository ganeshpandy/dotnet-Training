create table users(
	Id int primary key,username varchar(30),Upassword varchar(30),first_name varchar(30),
	last_name varchar(30),Uaddress varchar(30),telephone bigint)
select * from users
create table shopping_session(
	Id int primary key,user_id int foreign key references users(Id),total decimal)

create table discount(
	Id int primary key,name varchar(30),descp text,discount_percent decimal)

create table product(
	Id int primary key,name varchar(30),descp text,sku varchar(30),category varchar(30),price decimal,
	discount_id int foreign key references discount(Id))


create table cart_item(
	Id int,session_id int foreign key references shopping_session(Id),product_id int foreign key references product(Id),
	quantity int)

create table order_items(
	Id int primary key,product_id int foreign key references product(Id))



create table payment_details(
	Id int primary key,order_id int foreign key references order_items(Id),amount int,provider varchar(30),status varchar(30))


create table order_details(
	Id int primary key,user_id int,total decimal,
	payment_id int foreign key references payment_details(Id))

-------------------------------------------------------------------------

select * from users
create procedure Ecomm 
--Users table
@UId int,@Uusername varchar(30),@Upassword varchar(30),@Ufirst_name varchar(30),@Ulast_name varchar(30),@Uaddress varchar(30),@telephone bigint,
--Shopping_session
@SId int,@Suser_id int,@Stotal decimal,
--discount
@DId int,@Dname varchar(30),@Ddescp text,@discount_percent decimal,
--product
@PId int,@Pname varchar(30),@Pdescp text,@Psku varchar(30),@Pcategory varchar(30),@Pprice decimal,@Pdiscount_id int,
--cart_item
@CId int,@Csession_id int,@Cproduct_id int,@Cquantity int,
--Orderitems
@OIId int,@OIproduct int,
--payment details
@PDId int,@PDorder_id int,@PDamount int,@PDprovider varchar(30),@PDstatus varchar(30),
--order details
@ODId int,@ODuser_id int,@ODtotal decimal,@ODpayment_id int

as begin
insert into users values(@UId,@Uusername,@Upassword,@Ufirst_name,@Ulast_name,@Uaddress,@telephone)
insert into shopping_session values(@SId,@Suser_id,@Stotal)
insert into discount values(@DID,@Dname,@Ddescp,@discount_percent)
insert into product values(@PId,@Pname,@Pdescp,@Psku,@Pcategory,@Pprice,@Pdiscount_id)
insert into cart_item values(@CId,@Csession_id,@Cproduct_id,@Cquantity)
insert into order_items values(@OIId,@OIproduct)
insert into payment_details values(@PDId,@PDorder_id,@PDamount,@PDprovider,@PDstatus)
insert into order_details values(@ODId,@ODuser_id,@ODtotal,@ODpayment_id)
end;

exec Ecomm @UId=1,@Uusername='Kohil@mail',@Upassword='Kohil123',@Ufirst_name='Virat',@Ulast_name='A',@Uaddress='Banglore',@telephone=9087654321,
@SId=101,@Suser_id=1,@Stotal=20,
@DID=201,@Dname='GreatIndiansale',@Ddescp='Diwali',@discount_percent=20,
@PId=301,@Pname='samsung',@Pdescp='M31',@Psku='samsung123',@Pcategory='Mobile',@Pprice=11000,@Pdiscount_id=201,
@CId=1001,@Csession_id=101,@Cproduct_id=301,@Cquantity=10,
@OIId=2001,@OIproduct=301,
@PDId=3001,@PDorder_id=2001,@PDamount=11000,@PDprovider='amazon',@PDstatus='shipped',
@ODId=401,@ODuser_id=1,@ODtotal=10,@ODpayment_id=3001;

create procedure EcommerceData as
select * from users,shopping_session,discount,product,cart_item,order_items,payment_details,order_details

exec EcommerceData

drop table users
drop table payment_details
drop table order_details
drop table order_items
drop table discount
drop table product
drop table cart_item
