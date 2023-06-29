use master
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'QLPB2')
DROP DATABASE QLPB2
GO

create database QLPB2
GO

use QLPB2
GO

create table PHONGBAN(
	MaPB int identity primary key,
	TenPB nvarchar(50),
	MoTa nvarchar(50)
)
GO

create proc ThemPB(@TenPB nvarchar(50), @MoTa nvarchar(50))
as
	insert into PHONGBAN values (@TenPB, @MoTa)
go

create proc XoaPB(@id int)
as
	delete PHONGBAN where MaPB=@id
go

create proc CapNhatPB(@id int, @Ten nvarchar(50), @MT nvarchar(50))
as
	update PHONGBAN set TenPB=@Ten, MoTa=@MT where MaPB=@id

EXEC ThemPB N'Khoa CNTT', N'Giang day CNTT'
EXEC ThemPB N'PĐT', N'Phòng đào tạo'
EXEC ThemPB N'Khoa cơ khí', N'Giảng dạy cơ khí'