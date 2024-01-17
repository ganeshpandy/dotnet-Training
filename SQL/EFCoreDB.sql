create table Student(
	DepartmentId int primary key,
	StudentId int,
	Name nvarchar(30),
	Degree nvarchar(40),
	Marks int,
	DOB date)
	--2011/11/11
insert into Student values(1,101,'Alex','BSC',230,'2010/10/10'),
						(2,102,'Axel','BCA',340,'2009/8/9'),
						(3,103,'Charles','MCA',345,'2011/6/11'),
						(4,104,'Naruto','BSC',450,'2010/5/10'),
						(5,105,'Steve','BSC',444,'2010/2/10')


create table Department(StaffId int foreign key references Student(DepartmentId),
	StaffName nvarchar(30),
	CourseName nvarchar(30))

insert into Department values(1,'Arun','ComputerScience'),
						(2,'Bala','Computer Application'),
						(3,'Daniel','Computer Application'),
						(4,'Ethy','Physics'),
						(5,'Ferd','Chemistry')

create view StudentDetails as
select
    s.StudentId,
    s.Name,s.Degree,    
    d.CourseName,d.StaffName
from Student s
JOIN Department d on s.DepartmentId = d.StaffId;

select * from StudentDetails
drop view  StudentDetails
create procedure GetStudent
    @StudentId int
as
select * from Student where StudentId = @StudentId;

