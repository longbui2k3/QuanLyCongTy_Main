CREATE TABLE TKTruongPhong(
	maTP char(50) references NhanVien(MaNV),
	Username char(100) PRIMARY KEY,
	Pass_word char(100) NOT NULL,
	MaPB char(50) NULL,
)

INSERT INTO TKTruongPhong Values('NV005', 'ttam', '123')
INSERT INTO TKTruongPhong Values('NV006', 'hlinh', '123')
INSERT INTO TKTruongPhong Values('NV007', 'ttuan', '123')
INSERT INTO TKTruongPhong Values('NV008',  'tbac', '123')
INSERT INTO TKTruongPhong Values('NV009',  'tthanh', '123')
INSERT INTO TKTruongPhong Values('NV010',  'thoa', '123')
INSERT INTO TKTruongPhong Values('NV011', 'tchinh', '123')
INSERT INTO TKTruongPhong Values('NV012', 'dphi', '123')
select * from TKTruongPhong order by maTP

CREATE TABLE TKNhanVien(
	MaNV char(50) references NhanVien(MaNV),
	hoVaTen nchar(50) NOT NULL,
	viTri nchar(50) NOT NULL,
	MaPB char(50) references PhongBan(MaPB),
	SDT nchar(20) NOT NULL,
	Email nchar(50) NOT NULL,
	MaNguoiTao char(50) references NhanVien(MaNV),
	Username char(100) PRIMARY KEY,
	Pass_word char(100) NOT NULL,
)
select * from TKNhanVien order by maNV

Insert into TKNhanVien values('NV001', N'Bùi Đức Long', 'CV005', 'PB002', '0777981051', 'buiduclong@gmail.com', 'NV006', 'dlong', 123)
Insert into TKNhanVien values('NV002', N'Vũ Đức Lộc', 'CV007', 'PB002', '0949484333', 'vuducloc@gmail.com', 'NV006', 'dloc', 123)
Insert into TKNhanVien values('NV003', N'Trần Công Minh', 'CV015', 'PB004', '0923532224', 'trancongminh@gmail.com', 'NV008', 'cminh', 123)
Insert into TKNhanVien values('NV004', N'Hoàng Văn B', 'CV019', 'PB006', '0843434445', 'hoangvanb@gmail.com', 'NV010', 'vanb', 123)

CREATE TABLE PHONGBAN(
	MAPB char(50) PRIMARY KEY,
	TENPB nchar(50) NOT NULL,
	DIACHI nchar(50) NOT NULL,
	SODIENTHOAI char(50) NOT NULL,
	TruongPhong char(50) references NhanVien(MaNV),

)


INSERT INTO PHONGBAN VALUES('PB001', N'Kế Toán', N'TPHCM', N'0777981051')
INSERT INTO PHONGBAN VALUES('PB002', N'Công Nghệ Thông Tin', N'TPHCM', N'0984035555')
INSERT INTO PHONGBAN VALUES('PB003', N'Nhân Sự', N'TPHCM', N'0394443325')
INSERT INTO PHONGBAN VALUES('PB004', N'Chăm sóc khách hàng', N'TPHCM', N'0932741143')
INSERT INTO PHONGBAN VALUES('PB005', N'Hành Chính', N'TPHCM', N'074388555')
INSERT INTO PHONGBAN VALUES('PB006', N'Kinh Doanh', N'TPHCM', N'0394443325')
INSERT INTO PHONGBAN VALUES('PB007', N'Kiểm toán', N'TPHCM', N'0327485858')
INSERT INTO PHONGBAN VALUES('PB008', N'Cố vấn', N'TPHCM', N'0948933556')


CREATE TABLE CHUCVU(
	MaChucVu char(50) Primary key,
	TenChucVu nchar(50) NOT NULL,
	MaPB char(50) references PHONGBAN(MaPB),
	LuongChucVu int NOT NULL,
)
select * from CHucVu


INSERT INTO CHUCVU values('CV001', N'Kế toán trưởng', 'PB001', 30000000)
INSERT INTO CHUCVU values('CV002', N'Kế toán tổng hợp', 'PB001', 13000000)
INSERT INTO CHUCVU values('CV003', N'Kế toán thuế', 'PB001', 10000000)
INSERT INTO CHUCVU values('CV004', N'Kế toán tiền lương', 'PB001', 12000000)

INSERT INTO CHUCVU values('CV005', N'Quản trị hệ thống', 'PB002', 20000000)
INSERT INTO CHUCVU values('CV006', N'Lập trình viên', 'PB002', 20000000)
INSERT INTO CHUCVU values('CV007', N'Chuyên viên hỗ trợ kỹ thuật', 'PB002', 22000000)
INSERT INTO CHUCVU values('CV008', N'Nhân viên phát triển Web', 'PB002', 15000000)
INSERT INTO CHUCVU values('CV024', N'Trưởng phòng IT', 'PB002', 35000000)


INSERT INTO CHUCVU values('CV009', N'Giám đốc nhân sự', 'PB003', 30000000)
INSERT INTO CHUCVU values('CV010', N'Trưởng phòng nhân sự', 'PB003', 21000000)
INSERT INTO CHUCVU values('CV011', N'Chuyên viên tuyển dụng', 'PB003', 10000000)
INSERT INTO CHUCVU values('CV012', N'Chuyên viên đào tạo và phát triển', 'PB003', 17000000)

INSERT INTO CHUCVU values('CV013', N'Nhân viên hỗ trợ khách hàng', 'PB004', 12000000)
INSERT INTO CHUCVU values('CV014', N'Chuyên viên chăm sóc khách hàng', 'PB004', 13000000)
INSERT INTO CHUCVU values('CV015', N'Trưởng phòng CSKH', 'PB004', 25000000)

INSERT INTO CHUCVU values('CV016', N'Nhân viên hành chính', 'PB005', 12000000)
INSERT INTO CHUCVU values('CV017', N'Trưởng phòng hành chính', 'PB005', 12000000)

INSERT INTO CHUCVU values('CV018', N'Nhân viên kinh doanh', 'PB006', 13000000)
INSERT INTO CHUCVU values('CV019', N'Trưởng phòng kinh doanh', 'PB006', 20000000)
INSERT INTO CHUCVU values('CV020', N'Nhân viên Telesales', 'PB006', 13000000)

INSERT INTO CHUCVU values('CV021', N'Nhân viên kiểm toán', 'PB007', 14000000)
INSERT INTO CHUCVU values('CV022', N'Trưởng phòng kiểm toán', 'PB007', 22000000)

INSERT INTO CHUCVU values('CV023', N'Cố vấn cấp cao', 'PB008', 21000000)




/*update CHUCVU set LuongChucVu=10000000 where MaChucVu='CV003'*/

select * from CHUCVU



CREATE TABLE NHANVIEN(
	MANV char(50) PRIMARY KEY,
	HOTEN nchar(50) NOT NULL,
	VITRI nchar(50) REFERENCES Chucvu(MaChucVu),
	QUEQUAN nchar(50) NOT NULL,
	DANTOC nchar(50) NOT NULL,
	GIOITINH nchar(50) NOT NULL,
	NGAYSINH date NULL,
	SODIENTHOAI char(50) NOT NULL,
	MAPB char(50) references PHONGBAN(MAPB),
	TinhTrang nchar(50) NULL,
	Email char(100) NULL,
	HonNhan nchar(50) NULL,
	SoCMND nchar(50) NULL,
	NgayCap nchar(50) NULL,
	NoiCap nchar(50) NULL,
	TonGiao nchar(50) NULL,
	NgayVao date NULL,
	DiaChi nchar(50) NULL,
	Facebook nchar(50) NULL,
	GhiChu nchar(1000) NULL,
	Anh nchar(50) NULL,
)
alter table NhanVien
add Anh nchar(50) NULL
update NhanVien set Anh = '../../.././Images/nv1.png' where GioiTinh = N'Nam'


INSERT INTO NHANVIEN VALUES('NV001', N'Bùi Đức Long', 'CV005', N'Thái Bình', N'Kinh', N'Nam', '2003-09-04', '0777981051', 'PB002', N'Đang làm', 'buiduclong@gmail.com','Độc Thân', '0834978378', '2020-04-13', '../../.././Images/nv1.png');
INSERT INTO NHANVIEN VALUES('NV002', N'Vũ Đức Lộc', 'CV007', N'Lâm Đồng', N'Kinh', N'Nam', '2003-02-14', '0949484333', 'PB002', N'Đang làm', 'vuducloc@gmail.com','Đã Kết Hôn','08345485755', '2020-04-13', '../../.././Images/nv1.png');
INSERT INTO NHANVIEN VALUES('NV003', N'Trần Công Minh', 'CV015', N'Hà Tĩnh', N'Kinh', N'Nam', '2003-06-15', '0923532224', 'PB004', N'Đang làm', 'trancongminh@gmail.com','Độc Thân', '224325835355', '2020-04-13','../../.././Images/nv1.png');
INSERT INTO NHANVIEN VALUES('NV004', N'Hoàng Văn B', 'CV019', N'Hà Tĩnh', N'Kinh', N'Nam', '2003-04-13', '0843434445', 'PB006', N'Đang làm', 'hoangvanb@gmail.com','Đã Kết Hôn','1893783748365', '2020-04-13', '../../.././Images/nv1.png');

INSERT INTO NHANVIEN VALUES('NV005', N'Vũ Thị Thanh Tâm', 'CV001', N'Sơn La', N'Kinh', N'Nữ', '1998-12-11', '0495454656', 'PB001', N'Đang làm', 'vuthithanhtam@gmail.com','Độc Thân','989437483774', '2020-04-13','../../.././Images/nv2.png');
INSERT INTO NHANVIEN VALUES('NV006', N'Nguyễn Hồng Linh', 'CV024', N'Kiên Giang', N'Kinh', N'Nam', '1995-01-05', '0495454958', 'PB002', N'Đang làm', 'nguyenhonglinh@gmail.com','Đã Kết Hôn','846567858356', '2020-04-13', '../../.././Images/nv1.png');
INSERT INTO NHANVIEN VALUES('NV007', N'Nguyễn Thanh Tuấn', 'CV010', N'TPHCM', N'Kinh', N'Nam', '1995-09-05', '0978345123', 'PB003', N'Đang làm', 'nguyenthanhtuan@gmail.com','Độc Thân','846567835355', '2020-04-13','../../.././Images/nv1.png');
INSERT INTO NHANVIEN VALUES('NV008', N'Nguyễn Thị Bắc', 'CV015', N'Đồng Nai', N'Kinh', N'Nữ', '1999-09-20', '0495534666', 'PB004', N'Đang làm', 'nguyenthibac@gmail.com','Đã Kết Hôn', '14355835355', '2020-04-13','../../.././Images/nv2.png');
INSERT INTO NHANVIEN VALUES('NV009', N'Nguyễn Tiến Thành', 'CV017', N'TPHCM', N'Kinh', N'Nam', '1993-01-11', '0854123434', 'PB005', N'Đang làm', 'nguyentienthanh@gmail.com','Độc Thân','224325835355', '2020-04-13','../../.././Images/nv1.png');
INSERT INTO NHANVIEN VALUES('NV010', N'Trương Thị Hoa', 'CV019', N'Bình Thuận', N'Kinh', N'Nữ', '1998-01-05', '0495454958', 'PB006', N'Đang làm', 'truongthihoa@gmail.com','Đã Kết Hôn', '756475837583', '2020-04-13', '../../.././Images/nv2.png');
INSERT INTO NHANVIEN VALUES('NV011', N'Nguyễn Thị Chinh', 'CV022', N'TPHCM', N'Kinh', N'Nữ', '2000-03-17', '0899549833', 'PB007', N'Đang làm', 'nguyenthichinh@gmail.com','Độc Thân','83748765545', '2020-04-13', '../../.././Images/nv2.png');
INSERT INTO NHANVIEN VALUES('NV012', N'Hoàng Đức Phi', 'CV023', N'TPHCM', N'Kinh', N'Nam', '1999-11-12', '0963245144', 'PB008', N'Đang làm', 'hoangducphi@gmail.com','Đã Kết Hôn', '847384626327', '2020-04-13', '../../.././Images/nv1.png');


select * from NhanVien
CREATE TABLE LUONG(
	MaNhanVien char(50) references NHANVIEN(MANV),
	HoVaTen nchar(50) NOT NULL,
	PhongBan nchar(50) NOT NULL,
	ViTri nchar(50) NOT NULL,
	NgayCong int NOT NULL, 
	LuongViTri int NOT NULL,
	SoCongChuan int NOT NULL,
	LuongThucTe int NOT NULL,
	LuongPhuCap int NOT NULL,
	Thuong int NOT NULL,
	KhauTru int NOT NULL,
	TamUng int NOT NULL,
	ThucNhan int NOT NULL,	
	NamLamViec int NOT NULL,
	ThangLamViec int CONSTRAINT KTThang check (ThangLamViec >= 1 and ThangLamViec <= 12)
)

/*Alter table Luong
alter column ViTri char(50) NULL
Alter table Luong WITH CHECK ADD FOREIGN KEY(ViTri) REFERENCES CHucvu(MaChucVu);*/
INSERT INTO LUONG VALUES('NV001', N'Bùi Đức Long', 'PB001', 'CV005', 23,  20000000, 24, 18000000, 5000000, 1000000, 200000, 0, 21000000, 2022, 2)
INSERT INTO LUONG VALUES('NV001', N'Bùi Đức Long', 'PB001', 'CV005', 21,  20000000, 24, 15000000, 5000000, 1000000, 200000, 0, 20000000, 2022, 3)
INSERT INTO LUONG VALUES('NV001', N'Bùi Đức Long', 'PB001', 'CV005', 24,  20000000, 24, 20000000, 5000000, 1000000, 200000, 0, 21000000, 2022, 4)

INSERT INTO LUONG VALUES('NV002', N'Vũ Đức Lộc', 'PB002', 'CV007', 23,  20000000, 24, 18000000, 5000000, 1000000, 200000, 0, 21000000, 2022, 2)
INSERT INTO LUONG VALUES('NV002', N'Vũ Đức Lộc', 'PB002', 'CV007', 21,  20000000, 24, 15000000, 5000000, 1000000, 200000, 0, 20000000, 2022, 3)
INSERT INTO LUONG VALUES('NV002', N'Vũ Đức Lộc', 'PB002', 'CV007', 24,  20000000, 24, 20000000, 5000000, 1000000, 200000, 0, 21000000, 2022, 4)


INSERT INTO LUONG VALUES('NV003', N'Trần Công Minh', 'PB001', 'CV015', 23,  20000000, 24, 18000000, 5000000, 1000000, 200000, 0, 21000000, 2022, 2)
INSERT INTO LUONG VALUES('NV003', N'Trần Công Minh', 'PB001', 'CV015', 21,  20000000, 24, 15000000, 5000000, 1000000, 200000, 0, 20000000, 2022, 3)
INSERT INTO LUONG VALUES('NV003', N'Trần Công Minh', 'PB001', 'CV015', 24,  20000000, 24, 20000000, 5000000, 1000000, 200000, 0, 21000000, 2022, 4)
Select * from Luong


