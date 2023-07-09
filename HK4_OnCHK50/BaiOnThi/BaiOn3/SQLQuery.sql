use master
go

if db_id('QuanLyLop') is not null
	drop database QuanLyLop
go

create database QuanLyLop
go

use QuanLyLop
go

create table Lop(
	LopID int identity primary key,
	LopMa varchar(8) unique,
	LopTen nvarchar(200),
	SoSinhVien int 
)
go

create table SinhVien(
	SinhvienID int identity primary key,
	MSSV varchar(8) unique,
	SinhvienHo nvarchar(100),
	SinhvienTen nvarchar(100),
	SinhvienNgaySinh date,
	SinhvienSDT varchar(13),
	SinhvienEmail nvarchar(500) unique,
	SinhvienStatus int DEFAULT 1,
	LopID int foreign key references Lop(LopID)
)
go

create table SuKien(
	SukienID int identity primary key,
	SukienTen nvarchar(500),
	SukienTimeStart datetime,
	SukienTimeEnd datetime,
	SukienDiadiem nvarchar(500),
)
go

create table ThamGia(
	SinhvienID int foreign key references SinhVien(SinhvienID),
	SukienID int foreign key references SuKien(SukienID)
)
go

create proc themLop(
	@LopMa varchar(8),
	@LopTen nvarchar(200),
	@SoSinhVien int 
)
as
	insert into Lop(LopMa, LopTen, SoSinhVien) values (@LopMa, @LopTen, @SoSinhVien)
go

exec themLop N'1KMT21A', N'Khoa học máy tính 2021', 1
go

create proc suaLop(
	@LopID int,
	@LopMa varchar(8),
	@LopTen nvarchar(200),
	@SoSinhVien int 
)
as
	update Lop
	set
		LopMa = @LopMa,
		LopTen = @LopTen,
		SoSinhVien = @SoSinhVien 
	where LopID= @LopID
go

create proc themSinhvien(
	@MSSV varchar(8),
	@SinhvienHo nvarchar(100),
	@SinhvienTen nvarchar(100),
	@SinhvienNgaySinh date,
	@SinhvienSDT varchar(13),
	@SinhvienEmail nvarchar(500),
	@LopID int
)
as
	insert into SinhVien	(MSSV, SinhvienHo, SinhvienTen, SinhvienNgaySinh, SinhvienSDT, SinhvienEmail, LopID)
	values					(@MSSV, @SinhvienHo, @SinhvienTen, @SinhvienNgaySinh, @SinhvienSDT, @SinhvienEmail, @LopID)
go

exec themSinhvien '21022001', N'Mai Châu Tuấn', 'Lâm', '10/08/2002', '0927161049', '21022001@st.vlute.edu.vn', 1
go

create proc suaSinhVien(
	@SinhvienID int,
	@MSSV varchar(8),
	@SinhvienHo nvarchar(100),
	@SinhvienTen nvarchar(100),
	@SinhvienNgaySinh date,
	@SinhvienSDT varchar(13),
	@SinhvienEmail nvarchar(500),
	@LopID int
)
as
	update SinhVien
	set
		MSSV=@MSSV,
		SinhvienHo = @SinhvienHo,
		SinhvienTen = @SinhvienTen,
		SinhvienNgaySinh = @SinhvienNgaySinh,
		SinhvienSDT = @SinhvienSDT,
		SinhvienEmail = @SinhvienEmail,
		LopID=@LopID
	where SinhvienID = @SinhvienID
go