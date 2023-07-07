/*use master
go

drop database SchoolManagement
go

create database SchoolManagement
go

use SchoolManagement
go

create table Teachers(
	TeacherID int identity,
	Name nvarchar(50),
	Subject nvarchar(30),
	constraint PK_Teacher primary key (TeacherID)
)
go

create table Classes(
	ClassID int identity,
	ClassName nvarchar(500),
	TeacherID int,
	constraint PK_Classes primary key (ClassID),
	constraint FK_Classes_Teachers foreign key (TeacherID)
		references Teachers(TeacherID)
)
go

create table Students(
    StudentID int identity,
    Name nvarchar(50),
	Age int,
	ClassID int
	constraint PK_Students primary key (StudentID),
	constraint FK_Students_Classses foreign key (ClassID)
		references Classes(ClassID)
)
go

insert into Teachers (Name, Subject) VALUES (N'Lê Hoàng An', N'Cấu trúc máy tính')
insert into Teachers (Name, Subject) VALUES (N'Nguyễn Thị Kim Ngân', N'Lập trình Ứng dụng')
insert into Teachers (Name, Subject) VALUES (N'Trần Hồ Đạt', N'Phần mềm mã nguồn mở')
insert into Teachers (Name, Subject) VALUES (N'Phan Anh Cang', N'Trí tuệ nhân tạo')
insert into Teachers (Name, Subject) VALUES (N'Trần Phan An Trường', N'Internet vạn vật')
go

insert into Classes (ClassName, TeacherID) VALUES (N'CTMT01', 1)
insert into Classes (ClassName, TeacherID) VALUES (N'LTUD01', 2)
insert into Classes (ClassName, TeacherID) VALUES (N'PMNM01', 3)
insert into Classes (ClassName, TeacherID) VALUES (N'TTNT01', 4)
insert into Classes (ClassName, TeacherID) VALUES (N'IOT01', 5)
go

insert into Students (Name, Age, ClassID) VALUES (N'Nguyễn Văn A', 18, 1)
insert into Students (Name, Age, ClassID) VALUES (N'Nguyễn Văn B', 18, 2)
insert into Students (Name, Age, ClassID) VALUES (N'Nguyễn Văn C', 18, 3)
insert into Students (Name, Age, ClassID) VALUES (N'Nguyễn Văn D', 18, 4)
insert into Students (Name, Age, ClassID) VALUES (N'Nguyễn Văn E', 18, 5) 
go */
use master;
go

if db_id('SchoolManagement1') is not null
    drop database SchoolManagement1;
go

create database SchoolManagement1;
go

use SchoolManagement1;
go

create table Teachers (
	TeacherID int identity primary key,
	Name nvarchar(50),
	Subject nvarchar(30)
);
go

create table Classes (
	ClassID int identity primary key,
	ClassName nvarchar(50),
	TeacherID int foreign key references Teachers(TeacherID)
);
go

create proc themClass(@ClassName nvarchar(5), @TeacherID int)
as
	insert into Classes(ClassName, TeacherID) VALUES (@ClassName, @TeacherID)
go

create proc suaClass(@ClassID int, @ClassName nvarchar(5), @TeacherID int)
as
	update Classes
	set ClassName=@ClassName, TeacherID=@TeacherID
	where ClassID=@ClassID
go

create proc xoaClass(@ClassID int)
as
	delete Classes
	where ClassID=@ClassID
go

create table Students (
	StudentID int identity primary key,
	Name nvarchar(50),
	Age int,
	ClassID int foreign key references Classes(ClassID)
);
go

create table Subjects (
	SubjectID int identity primary key,
	SubjectName nvarchar(50)
);

create table TeacherSubjects(
	TeacherID int foreign key references Teachers(TeacherID),
	SubjectID int foreign key references Subjects(SubjectID)
);

create proc addTeachers(@Name nvarchar(50), @Subject nvarchar(30))
as
	insert into Teachers(Name, Subject) values (@Name, @Subject)
go

create proc suaTeachers(@id int, @Name nvarchar(50), @Subject nvarchar(30))
as
	update Teachers
	set Name=@Name, Subject=@Subject
	where TeacherID=@id
go

create proc xoaTeachers(@id int)
as
	delete Teachers
	where TeacherID=@id
go

USE SchoolManagement1;
SELECT * FROM sys.procedures;

insert into Teachers (Name, Subject) values
    (N'Lê Hoàng An', N'Cấu trúc máy tính'),
    (N'Nguyễn Thị Kim Ngân', N'Lập trình Ứng dụng'),
    (N'Trần Hồ Đạt', N'Phần mềm mã nguồn mở'),
    (N'Phan Anh Cang', N'Trí tuệ nhân tạo'),
    (N'Trần Phan An Trường', N'Internet vạn vật');
go

insert into Classes (ClassName, TeacherID) values
    (N'CTMT01', 1),
    (N'LTUD01', 2),
    (N'PMNM01', 3),
    (N'TTNT01', 4),
    (N'IOT01', 5);
go

insert into Students (Name, Age, ClassID) values
    (N'Nguyễn Văn A', 18, 1),
    (N'Nguyễn Văn B', 18, 2),
    (N'Nguyễn Văn C', 18, 3),
    (N'Nguyễn Văn D', 18, 4),
    (N'Nguyễn Văn E', 18, 5);
go
