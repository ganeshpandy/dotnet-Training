--create new table 
create table LoginPage(
	Id int primary key,Name varchar(30),password varchar(40),Email varchar(40),
	Phno bigint)
--insert the values into table
insert into LoginPage values
(1,'Alex','alex123','alex123','1234433'),
(2,'Bolt','Bolt123','Bolt123','454221'),
(4,'Charles','Charles123','alex123','1234433'),
(5,'Daniel','Daniel123','alex123','1234433')
--update a particular record
update LoginPage set address='trichy',email='a@1' where Name='bolt'
--delete record(values)in a table
truncate table LoginPage
--display all the record
select * from LoginPage
--rename column name
EXEC sp_rename 'LoginPage.password', 'ConfirmPassowrd', 'COLUMN';
--add column
alter table LoginPage add address varchar(40)
--drop column
alter table LoginPage drop column address
--alter contraints
alter table table_name add constraint column_name constraints_name(column_name)

create table Employee(
	Id  int,
	Name varchar(30),
	Address varchar(40),
	Email varchar(40))
	
insert into Employee values
(1,'Alex','london','1234433'),
(2,'Bolt','egypt','454221'),
(6,'Charles','america','1234433'),
(5,'Daniel','russia','1234433')

select * from Employee

create table FoodOrder(
	OrderId  int,
	Name varchar(30),
	FoodName varchar(40),
	Amount int)

insert into FoodOrder values
(6,'Charles','FiredRice','120'),
(5,'Daniel','Biryani','100'),
(10,'james','GrillChicken','200')
select * from FoodOrder
--alter column name
EXEC sp_rename 'FoodOrder.HotelName', 'FoodName', 'COLUMN';
--alter constraints
ALTER TABLE YourTableName
ADD CONSTRAINT YourNewPrimaryKeyConstraintName PRIMARY KEY (NewColumn1, NewColumn2);
--display 3 tables record
select * from LoginPage 
inner join Employee on LoginPage.Id=Employee.Id
inner join FoodOrder on LoginPage.Id=FoodOrder.OrderId

select * from FoodOrder
truncate table FoodOrder

create table MovieTicket(
	TicketId  int,
	Name varchar(30),
	MovieName varchar(40),
	Amount int)

insert into MovieTicket values
(1,'Alex','LEO','120'),
(2,'Bolt','LEO','150'),
(4,'Charles','LEO','200')

--display 4 tables record
select Loginpage.Id,Employee.Name,MovieTicket.MovieName,FoodOrder.FoodName from LoginPage 
left join Employee on LoginPage.Id=Employee.Id
left join FoodOrder on LoginPage.Id=FoodOrder.OrderId
left join MovieTicket on Loginpage.Id=MovieTicket.TicketId

select * from MovieTicket

select * from LoginPage inner join Employee on LoginPage.Id=Employee.id
select * from LoginPage left join Employee on LoginPage.Id=Employee.id
select * From LoginPage right join Employee on LoginPage.Id=Employee.id

select * from LoginPage
select * from Employee
select LoginPage.ID,LoginPage.Name,Employee.Address from LoginPage cross join Employee  

drop table Employee
