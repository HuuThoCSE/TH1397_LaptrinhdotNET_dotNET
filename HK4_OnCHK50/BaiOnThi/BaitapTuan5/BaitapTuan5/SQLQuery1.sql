create database QLPB
GO

use QLPB
GO

create table PHONGBAN(
	MaPB int identity,
	TenPB nvarchar(200),
	MoTa nvarchar(500),
	constraint PK_PHONGBAN primary key (MaPB)
)

insert into PHONGBAN (TenPB, MoTa) VALUES('CNTT', N'Công nghệ thông tin.')
insert into PHONGBAN (TenPB, MoTa) VALUES('LAW', N'Kinh tế luật.')
