use master
go

if db_id('QLKT') is not null
	drop database QLKT
go

create database QLKT
go

use QLKT
go

create table SinhVien(
	SinhvienID int identity primary key,
	HoTen nvarchar(500),
	NgaySinh date,
	GioiTinh bit,
	Email varchar(200) unique /* Không đặt dấu phẩy cuối dòng */
)
go

create table MonHoc(
	MonhocID int identity primary key,
	MonhocTen nvarchar(500),
	SoTinChi int,
	HocKy int
)
go

create table DiemThi(
	DiemthiID int identity primary key,
	SinhvienID int foreign key references SinhVien(SinhvienID),
	MonhocID int foreign key references  MonHoc(MonhocID),
	Diem float
)
go /* Phải có go sau mỗi dòng */

/* ------Sinhvien */

create proc themSV(@HoTen nvarchar(500), @NgaySinh date, @GioiTinh bit, @Email varchar(200))
as
	insert into SinhVien (HoTen, NgaySinh, GioiTinh, Email) VALUES (@HoTen, @NgaySinh, @GioiTinh, @Email)
go

EXEC themSV N'Nguyễn Văn A', '2023-08-07', 1, 'anv@st.vlute.edu.vn' /* Không cần để vào ngoặc */
go

create proc suaSV(@SinhvienID int, @HoTen nvarchar(500), @NgaySinh date, @GioiTinh bit, @Email varchar(200))
as
	update SinhVien 
	set HoTen=@HoTen, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, Email=@Email
	where SinhvienID=@SinhvienID
go

create proc xoaSV(@SinhvienID int)
as
	delete SinhVien 
	where SinhvienID=@SinhvienID
go

/* ------Monhoc */

create proc themMH (@MonhocTen nvarchar(500), @SoTinChi int, @HocKy int)
as
	insert into MonHoc (MonhocTen, SoTinChi, HocKy) values (@MonhocTen, @SoTinChi, @HocKy)
go

exec themMH N'.NET', 4, 2
go

create proc suaMH (@MonhocID int, @MonhocTen nvarchar(500), @SoTinChi int, @HocKy int)
as
	update MonHoc 
	set MonhocTen=@MonhocTen, SoTinChi=@SoTinChi, HocKy=@HocKy
	where MonhocID=@MonhocID
go

create proc xoaMH (@MonhocID int)
as
	delete MonHoc 
	where MonhocID=@MonhocID
go

/* ------Diemthi */
create proc themDT(@SinhvienID int, @MonhocID int, @Diem float)
as
	insert into DiemThi (SinhvienID, MonhocID, Diem) values (@SinhvienID, @MonhocID, @Diem)
go

create proc suaDT(@DiemthiID int, @SinhvienID int, @MonhocID int, @Diem float)
as
	update DiemThi 
	set SinhvienID=@SinhvienID, MonhocID=@MonhocID, Diem=@Diem
	where DiemthiID=@DiemthiID
go

create proc xoaDT(@DiemthiID int)
as
	delete DiemThi
	where DiemthiID=@DiemthiID
go

exec themDT 1, 1, 8 
go


