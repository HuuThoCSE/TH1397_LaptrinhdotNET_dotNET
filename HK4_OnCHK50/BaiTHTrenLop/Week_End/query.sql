USE master
GO

drop database QLSV2
GO

create database QLSV2
GO

use QLSV2
GO

create table SINHVIEN(
	MaSV int identity,
	HoTen nvarchar(200),
	NgaySinh date,
	GioiTinh bit,
	constraint PK_SINHVIEN primary key (MaSV)
)
GO

create proc ThemSV(@TEN nvarchar(200), @NS date, @GT bit)
as
	insert into SINHVIEN(HoTen, NgaySinh, GioiTinh) VALUES (@TEN, @NS, @GT)
GO

exec ThemSV N'Nguyễn Hữu Thọ', '2003-05-26', 1
exec ThemSV N'Nguyễn Hữu Phước', '2003-08-01', 1
exec ThemSV N'Nguyễn Hữu Lộc', '2003-12-10', 1
exec ThemSV N'Nguyễn Thị Hồng Ngát', '2003-08-26', 0
exec ThemSV N'Nguyễn Lan Tường', '2003-05-26', 0
GO