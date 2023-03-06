CREATE TABLE TAIKHOAN(
	hoVaTen nchar(50) NOT NULL,
	viTri nchar(50) NOT NULL,
	SDT nchar(20) NOT NULL,
	Email nchar(50) NOT NULL,
	Username char(100) PRIMARY KEY,
	Pass_word char(100) NOT NULL
)

select * from TAIKHOAN