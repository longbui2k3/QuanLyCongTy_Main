﻿CREATE TABLE TAIKHOAN(
	hoVaTen nchar(50) NOT NULL,
	viTri nchar(50) NOT NULL,
	SDT nchar(20) NOT NULL,
	Email nchar(50) NOT NULL,
	Username char(100) PRIMARY KEY,
	Pass_word char(100) NOT NULL
)

select * from TAIKHOAN
CREATE TABLE PHONGBAN(
	MAPB char(50) PRIMARY KEY,
	TENPB nchar(50) NOT NULL,
	DIACHI nchar(50) NOT NULL,
	SODIENTHOAI char(50) NOT NULL
)
INSERT INTO PHONGBAN VALUES('PB001', N'Kế Toán', N'TPHCM', N'0777981051')
INSERT INTO PHONGBAN VALUES('PB002', N'IT', N'TPHCM', N'0984035555')
INSERT INTO PHONGBAN VALUES('PB003', N'Nhân Sự', N'TPHCM', N'0394443325')
SELECT * From PHONGBAN
CREATE TABLE NHANVIEN(
	MANV char(50) PRIMARY KEY,
	HOTEN nchar(50) NOT NULL,
	VITRI nchar(50) NOT NULL,
	QUEQUAN nchar(50) NOT NULL,
	DANTOC nchar(50) NOT NULL,
	GIOITINH nchar(50) NOT NULL,
	NGAYSINH nchar(50) NOT NULL,
	SODIENTHOAI char(50) NOT NULL,
	MAPB char(50) references PHONGBAN(MAPB),
	TinhTrang nchar(50) NULL
)
alter table Nhanvien 
add Email char(100) NULL

Update nhanvien set Email = 'trancongminh@gmail.com' where MaNV='NV003'

select * from Nhanvien
INSERT INTO NHANVIEN VALUES('NV001', N'Bùi Đức Long', N'Trưởng Phòng', N'Thái Bình', N'Kinh', N'Nam', '04/09/2003', '0777981051', 'PB001');
INSERT INTO NHANVIEN VALUES('NV002', N'Vũ Đức Lộc', N'Giám Đốc', N'Lâm Đồng', N'Kinh', N'Nam', '14/02/2003', '0949484333', 'PB002');
INSERT INTO NHANVIEN VALUES('NV003', N'Trần Công Minh', N'Phó Giám Đốc', N'Hà Tĩnh', N'Kinh', N'Nam', '15/06/2003', '0923532224', 'PB001');
INSERT INTO NHANVIEN VALUES('NV004', N'Hoàng Văn B', N'Nhân Viên', N'Hà Tĩnh', N'Kinh', N'Nam', '13/04/2003', '0843434445', 'PB003', N'Đang làm', 'hoangvanb@gmail.com');
SELECT * FROM NHANVIEN
/*
ALTER TABLE NHANVIEN ALTER COlumn LUONG int NOT NULL;
ALTER TABLE NHANVIEN DROP COlumn LUONG;*/

CREATE TABLE LUONG(
	MaNhanVien char(50) references NHANVIEN(MANV),
	HoVaTen nchar(50) NOT NULL,
	PhongBan nchar(50) NOT NULL,
	ViTri nchar(50) NOT NULL,
	NgayCong int NOT NULL, 
	LuongViTri int NOT NULL,
	SoCongChuan int NOT NULL,
	LuongNgayCong int NOT NULL,
	LuongPhuCap int NOT NULL,
	Thuong int NOT NULL,
	KhauTru int NOT NULL,
	TamUng int NOT NULL,
	ThucNhan int NOT NULL,	
)
SELECT * FROM NHANVIEN, PHONGBAN 
