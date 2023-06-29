use master
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'QLPB1')
DROP DATABASE QLPB_21022008
GO

create database QLPB_21022008
GO

use QLPB_21022008
GO

create table PHONGBAN(
	MaPB int identity primary key,
	TenPB varchar(100),
	MoTa nvarchar(200)
)
GO

create table NHANVIEN(
	MaNV int identity primary key,
	HoTen nvarchar(500),
	NgaySinh date,
	MaPB int,
	constraint FK_NHANVIEN_PHONGBAN foreign key (MaPB)
		references PHONGBAN(MaPB)
)
GO

create proc Insert_PB (@TenPB nvarchar(100), @MoTa nvarchar(200))
AS
	insert into PHONGBAN (TenPB, MoTa) VALUES (@TenPB, @MoTa)
GO

EXEC Insert_PB N'CNTT', N'Công nghệ thông tin.'
GO

EXEC Insert_PB N'CKDL', N'Cơ khí động lực.'
GO

create proc Delete_PB (@MaPB int)
AS
	delete from PHONGBAN
	where MaPB=@MaPB
GO

EXEC Delete_PB 1
GO

create proc Update_PB (@MaPB int, @TenPB nvarchar(100), @MoTa nvarchar(200))
AS
	update PHONGBAN
	set TenPB=@TenPB, MoTa=@MoTa
	where MaPB=@MaPB
GO

EXEC Update_PB 2, N'CKDL', N'Cơ khí động lực'
GO

create proc Insert_NV (@HoTen nvarchar(200), @NgaySinh date, @MaPB int)
AS
	insert into NHANVIEN VALUES (@HoTen, @NgaySinh, @MaPB)
GO

EXEC Insert_NV N'Nguyễn Hữu Thọ', '2002-02-12', 1
GO

create proc Delete_NV (@MaNV varchar(100))
AS
	delete from NHANVIEN
	where MaNV=@MaNV
GO

EXEC Delete_NV 'NV001'
GO

create proc Update_NV (@MaNV varchar(100), @HoTen nvarchar(200), @NgaySinh date, @MaPB int)
AS
	update NHANVIEN
	set HoTen=@HoTen, NgaySinh=@NgaySinh, MaPB=@MaPB
	where MaNV=@MaNV
GO

EXEC Update_NV 'NV001', N'Nguyễn Trọng Huy', '2002-02-12', 2
GO
