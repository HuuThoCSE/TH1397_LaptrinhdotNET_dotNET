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
	SinhvienGioitinh bit,
	SinhvienNgaySinh date,
	SinhvienSDT varchar(13),
	SinhvienEmail nvarchar(500) unique,
	SinhvienStatus int DEFAULT 1,
	LopID int foreign key references Lop(LopID)
)
go

create table Hocky(
	HockyID int identity primary key,
	HockyMa varchar(3)
)
go

insert into Hocky (HockyMa) values ('HK4')
go

create table SuKien(
	SukienID int identity primary key,
	SukienTen nvarchar(500),
	HockyID int foreign key references Hocky(HockyID),
	SukienTimeStart datetime,
	SukienTimeEnd datetime,
	SukienDiadiem nvarchar(500),
)
go

create table SinhVienSuKien(
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
	@SinhvienGioitinh bit,
	@SinhvienNgaySinh date,
	@SinhvienSDT varchar(13),
	@SinhvienEmail nvarchar(500),
	@LopID int
)
as
	insert into SinhVien	(MSSV, SinhvienHo, SinhvienTen, SinhvienGioitinh, SinhvienNgaySinh, SinhvienSDT, SinhvienEmail, LopID)
	values					(@MSSV, @SinhvienHo, @SinhvienTen, @SinhvienGioitinh, @SinhvienNgaySinh, @SinhvienSDT, @SinhvienEmail, @LopID)
go

exec themSinhvien '21022001', N'Mai Châu Tuấn', N'Lâm', 1, '10/08/2002', '0927161049', '21022001@st.vlute.edu.vn', 1
exec themSinhvien '21022002', N'Âu Thị Anh', N'Thư', 0, '04/10/2003', '0833507096', '21022002@st.vlute.edu.vn', 1
exec themSinhvien '21022003', N'Nguyễn Võ Nhật', N'Tân', 1, '07/27/2003', '0896656874', '21022003@st.vlute.edu.vn', 1
exec themSinhvien '21022004', N'Phan Nguyễn Đình', N'Trí', 1, '10/23/2003', '0704884465', '21022004@st.vlute.edu.vn', 1
exec themSinhvien '21022005', N'Đỗ Phi', N'Long', 1, '06/03/2003', '0328702525', '21022005@st.vlute.edu.vn', 1
exec themSinhvien '21022006', N'Tăng Huỳnh Thanh', N'Phú', 1, '07/07/2003', '0764816715', '21022006@st.vlute.edu.vn', 1
exec themSinhvien '21022007', N'Nguyễn Văn', N'Huyên', 1, '03/17/2003', '0763978508', '21022007@st.vlute.edu.vn', 1
exec themSinhvien '21022008', N'Nguyễn Hữu', N'Thọ', 1, '05/26/2003', '0355733881', '21022008@st.vlute.edu.vn', 1
exec themSinhvien '21022009', N'Trương Phát', N'Thành', 1, '05/22/2003', '0902516196', '21022009@st.vlute.edu.vn', 1
exec themSinhvien '21022010', N'Lê Nguyễn Quang', N'Bình', 1, '10/08/2003', '0783893382', '21022010@st.vlute.edu.vn', 1
exec themSinhvien '21022011', N'Nguyễn Văn', N'Hoàng', 1, '10/30/2003', '0798149594', '21022011@st.vlute.edu.vn', 1
exec themSinhvien '21022012', N'Trần Khánh', N'Duy', 1, '07/12/2003', '0961731090', '21022012@st.vlute.edu.vn', 1
exec themSinhvien '21022013', N'Phan An', N'Hưng', 1, '04/29/2003', '0769341049', '21022013@st.vlute.edu.vn', 1
exec themSinhvien '21022014', N'Trần Thế', N'Anh', 1, '10/08/2003', '0799908676', '21022014@st.vlute.edu.vn', 1
exec themSinhvien '21022015', N'Huỳnh Phước', N'Đức', 1, '02/08/2003', '0392907834', '21022015@st.vlute.edu.vn', 1
exec themSinhvien '21022016', N'Lê Hoàng', N'Tâm', 1, '06/15/2003', '0339461629', '21022016@st.vlute.edu.vn', 1
exec themSinhvien '21022017', N'Nguyễn Trọng', N'Huy', 1, '05/11/2002', '0353416459', '21022017@st.vlute.edu.vn', 1
exec themSinhvien '21022018', N'Trần Diễm', N'Quỳnh', 0, '12/04/2003', '0941451473', '21022018@st.vlute.edu.vn', 1
exec themSinhvien '21022019', N'Huỳnh Bảo', N'Thắng', 1, '01/19/2003', '0382803225', '21022019@st.vlute.edu.vn', 1
exec themSinhvien '21022020', N'', '', 1, '01/01/2021', '', '', 1
exec themSinhvien '21022021', N'Nguyễn Thị Bích', N'Ngọc', 0, '01/09/2003', '0395481689', '21022021@st.vlute.edu.vn', 1
exec themSinhvien '21022022', N'Phan Hải', N'Quân', 1, '10/08/2003', '0932960900', '21022022@st.vlute.edu.vn', 1
exec themSinhvien '21022023', N'Lê Anh', N'Khoa', 1, '04/22/2003', '0794283117', '21022023@st.vlute.edu.vn', 1
exec themSinhvien '21022024', N'Lê Võ Khánh ', N'Duy', 1, '11/17/2003', '0774839797', '21022024@st.vlute.edu.vn', 1
exec themSinhvien '21022025', N'Bùi Thanh', N'Khiết', 1, '12/02/2003', '0364435911', '21022025@st.vlute.edu.vn', 1
exec themSinhvien '21022026', N'Trần Huy', N'Hoàng', 1, '12/24/2003', '0986561109', '21022026@st.vlute.edu.vn', 1
exec themSinhvien '21022027', N'Hồ Minh', N'Trí', 1, '10/11/2003', '0589956278', '21022027@st.vlute.edu.vn', 1
go

create proc suaSinhVien(
	@SinhvienID int,
	@MSSV varchar(8),
	@SinhvienHo nvarchar(100),
	@SinhvienTen nvarchar(100),
	@SinhvienGioitinh bit,
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
		SinhvienGioitinh = @SinhvienGioitinh,
		SinhvienNgaySinh = @SinhvienNgaySinh,
		SinhvienSDT = @SinhvienSDT,
		SinhvienEmail = @SinhvienEmail,
		LopID=@LopID
	where SinhvienID = @SinhvienID
go

create proc themSuKien(
	@SukienTen nvarchar(500),
	@HockyID int,
	@SukienTimeStart datetime,
	@SukienTimeEnd datetime,
	@SukienDiadiem nvarchar(500)
)
as
	insert into SuKien(SukienTen, HockyID, SukienTimeStart, SukienTimeEnd, SukienDiadiem)
		values (@SukienTen, @HockyID, @SukienTimeStart, @SukienTimeEnd, @SukienDiadiem)
go

create proc suaSuKien(
	@SukienID int,
	@SukienTen nvarchar(500),
	@HockyID int,
	@SukienTimeStart datetime,
	@SukienTimeEnd datetime,
	@SukienDiadiem nvarchar(500)
)
as
	update SuKien
	set SukienTen=@SukienTen, 
		HockyID=@HockyID, 
		SukienTimeStart=@SukienTimeStart, 
		SukienTimeEnd=@SukienTimeEnd, 
		SukienDiadiem=@SukienDiadiem
	where 
	SukienID = @SukienID
go

create proc joinSukien(
	@SinhvienID int,
	@SukienID int
)
as
	insert into SinhVienSuKien values (@SinhvienID, @SukienID)
go
