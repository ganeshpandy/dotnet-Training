CREATE TABLE Student(
					Id int primary key,
					StudName varchar(20),
					Address varchar(20),
					DOB Date
);
create table Teacher(
TeacherId int foreign key references Student(Id),TeacherName varchar(30),

);
CREATE TABLE Orderr(
	OrderId int,
	CustomerName varchar(40),
	OrderName varchar(40),
	OrderDate Date,	
	);

	select * from Student;
	select * from Teacher;
	
	select * from Orderr;

	insert into Teacher values
	(102,'Arun'),(103,'Bala')

	insert into Student values
	(102,'Ban','trichy','2010/01/01'),(103,'charles','madurai','2011/11/11')

	alter table Orderr add Phno int
	alter table Orderr alter column OrderId bigint

	--adding new column
	alter table Student add Phno int	

	

	

	insert into Orderr values(1,'Arun','mobile','2022/11/11',1234567),
	(2,'Arun','mobile','2022/11/11',1234567)
	truncate table Orderr

	update Orderr set CustomerName='Sai'where OrderId=1
	insert into Orderr values(3,'jeeva','mobile','2000/10/10',123345),
	(4,'Raj','mobile','2000/10/10',12334567),
	(5,'selva','mobile','2000/09/01',12334)


	create table Teacher(TeacherId bigint FOREIGN KEY REFERENCES Student(Id),TeacherName varchar(40))

	drop table Teacher
	drop table Student