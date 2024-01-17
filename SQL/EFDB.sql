create procedure GetStudent as
select * from Student
exec GetStudent
drop procedure PutStudent

create procedure GetStudentById @Id int as 
select * from Student where ID=@Id

create procedure AddStudent @Id int,@StudName varchar(30),@Address varchar(30),@Date date 
as
insert into Student values(@Id,@StudName,@Address,@Date)

Exec AddStudent @Id=12,@StudName='Rohit',@Address='Mumbai',@Date='2010/10/9'

create procedure PutStudent @Id int,@StudName varchar(30) 
as
update Student set StudName=@StudName where Id=@Id

exec PutStudent  @Id=0,@StudName='kohil' 

CREATE PROCEDURE DeleteStudent @id int AS
DELETE Student WHERE Id= @id
 
EXEC DeleteStudent @id = 2
exec AddStudent
drop procedure AddStudent