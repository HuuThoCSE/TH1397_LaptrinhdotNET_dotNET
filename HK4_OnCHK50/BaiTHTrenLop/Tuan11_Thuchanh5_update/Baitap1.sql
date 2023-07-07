use master
GO

IF EXISTS (SELECT name FROM sys.databases WHERE name = N'QLPB')
DROP DATABASE QLPB
GO

create database QLPB
GO

use QLPB
GO

create table PHONGBAN(
	MaPB int identity primary key,
	TenPB varchar(100),
	MoTa nvarchar(200)
)
GO

create table NHANVIEN(
	MaNV varchar(100) primary key,
	HoTen nvarchar(500),
	GioiTinh bit,
	NgaySinh date,
	HSL float,
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

create proc Insert_NV (@MaNV varchar(100), @HoTen nvarchar(200), @GioiTinh bit, @NgaySinh date, @HSL float, @MaPB int)
AS
	insert into NHANVIEN VALUES (@MaNV, @HoTen, @GioiTinh, @NgaySinh, @HSL, @MaPB)
GO

EXEC Insert_NV 'NV001', N'Nguyễn Trọng Khôi', 0, '2002-02-12', 2.5, 2
GO

create proc Delete_NV (@MaNV varchar(100))
AS
	delete from NHANVIEN
	where MaNV=@MaNV
GO

EXEC Delete_NV 'NV001'
GO

create proc Update_NV (@MaNV varchar(100), @HoTen nvarchar(200), @GioiTinh bit, @NgaySinh date, @HSL float, @MaPB int)
AS
	update NHANVIEN
	set HoTen=@HoTen, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, HSL=@HSL, MaPB=@MaPB
	where MaNV=@MaNV
GO

EXEC Update_NV 'NV001', N'Nguyễn Trọng Huy', 0, '2002-02-12', 2.5, 2
GO
