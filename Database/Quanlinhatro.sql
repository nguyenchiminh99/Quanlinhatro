--KIEM TRA SU TON TAI DATABASE
USE MASTER
GO
IF EXISTS (SELECT Name FROM SYS.DATABASES WHERE name='QUANLYNHATRO')
	DROP DATABASE QUANLYNHATRO
GO
CREATE DATABASE QUANLYNHATRO
GO
USE QUANLYNHATRO
GO

CREATE TABLE QUANLY
(
	Username  nvarchar (100) primary key,
	Password nvarchar(100) not null,
	Hoten nvarchar(100) not null
)
GO

CREATE TABLE PHONGTRO
(
	MaPhong int identity primary key not null,
	TrangThai nvarchar(100) check (TrangThai IN (N'Phòng đã cho thuê',N'Phòng Trống')) Default N'Phòng Trống' not null,
	ThongTinPhong nvarchar(50) not null,
	LoaiPhong int not null,
)
GO

CREATE TABLE KHACH_THUE 
(
	MaKhach int identity primary key not null,
	TenKhach nvarchar(30) not null,
	Phai nvarchar(5) not null,
	CMND varchar(11) not null,
	QueQuan nvarchar(20) not null, 
	NgheNghiep nvarchar(20) not null,
)
GO

CREATE TABLE CT_KHACH_THUE
(
	MaKhach int not null,
	MaPhong int not null,
	NgayVaoPhong Date not null,
)

GO

CREATE TABLE GIA_THUE
(
	LoaiPhong int primary key not null,
	GiaTien int not null,
)
GO
CREATE TABLE HOA_DON
(
	MaHoaDon int identity(1,1) primary key not null,
	MaPhong int not null,
	NgayLap Date not null,
	NguoiLap nvarchar(100) not null
	
)
GO

CREATE TABLE DICH_VU 
(
	MaDichVu int identity primary key not null,
	TenDichVu nvarchar(30) not null,
	GiaDichVu int not null,
	DonViTinh nvarchar(30) not null,
)
GO

CREATE TABLE CT_HOADON
(
	MaHoaDon int not null,
	MaDichVu int not null,
	DonViSuDung int not null,
	ThanhTien int not null,
)
GO

ALTER TABLE PHONGTRO
ADD CONSTRAINT FK_PHONGTRO_GIATHUE FOREIGN KEY (LoaiPhong)
REFERENCES GIA_THUE(LoaiPhong)
ON UPDATE CASCADE

ALTER TABLE CT_KHACH_THUE 
ADD CONSTRAINT FK_CTKHACHTHUE_KHACHTHUE FOREIGN KEY (MaKhach)
REFERENCES KHACH_THUE (MaKhach)
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE CT_KHACH_THUE
ADD CONSTRAINT FK_CTKHACHTHUE_PHONGTRO FOREIGN KEY (MaPhong)
REFERENCES PHONGTRO (MaPhong)
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE HOA_DON
ADD CONSTRAINT FK_QUANLY_HOADON FOREIGN KEY(NguoiLap)
REFERENCES QUANLY(Username)

ALTER TABLE HOA_DON
ADD CONSTRAINT FK_HOADON_PHONGTRO FOREIGN KEY (MaPhong)
REFERENCES PHONGTRO (MaPhong)
ON UPDATE CASCADE

ALTER TABLE CT_HOADON
ADD CONSTRAINT FK_HOADON_CTHOADON FOREIGN KEY (MaHoaDon)
REFERENCES HOA_DON (MaHoaDon)
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE CT_HOADON
ADD CONSTRAINT FK_DICHVU_CTHOADON FOREIGN KEY (MaDichVu)
REFERENCES DICH_VU (MaDichVu)
ON UPDATE CASCADE

INSERT INTO QUANLY VALUES ( N'quanli1','123456',N'Nguyễn Chí Minh'),
							(N'quanli2','123456', N'Lê Xuân Vũ')
GO

INSERT GIA_THUE VALUES('1','800000')
INSERT GIA_THUE VALUES('2','1000000')
INSERT GIA_THUE VALUES('3','1500000')
INSERT GIA_THUE VALUES('4','2000000')
INSERT GIA_THUE VALUES('5','2500000')
INSERT GIA_THUE VALUES('6','3000000')
INSERT GIA_THUE VALUES('7','4000000')
GO

INSERT PHONGTRO VALUES (N'Phòng đã cho thuê',N'Có máy lạnh','4'),
									(N'Phòng trống',N'Có máy lạnh','4'),
									(N'Phòng trống',N'Có máy giặt','4'),
									(N'Phòng đã cho thuê',N'Có Tivi','5'),
									(N'Phòng trống',N'Có máy lạnh','5'),
									(N'Phòng đã cho thuê',N'Có máy lạnh','5'),
									(N'Phòng đã cho thuê',N'Có máy lạnh','4'),
									(N'Phòng trống',N'Có máy lạnh','4'),
									(N'Phòng đã cho thuê',N'Có máy lạnh','7'),
									(N'Phòng trống',N'Có máy lạnh','5')									
GO
INSERT KHACH_THUE VALUES (N'Nguyễn Văn Tèo','Nam',281030001,N'Bình Định',N'Sinh viên')
INSERT KHACH_THUE VALUES (N'Mạc Thị Bưởi',N'Nữ',281030002,N'Bình Dương',N'Công nhân'	)
INSERT KHACH_THUE VALUES (N'Ô Văn Quen','Nam',281030003,N'Bình Dương',N'Sinh viên')
INSERT KHACH_THUE VALUES (N'Lao VănLực','Nam',281030004,N'TP.HCM',N'Sinh viên')
INSERT KHACH_THUE VALUES (N'Hành văn Chính','Nam',281030005,N'Bình Dương',N'Sinh viên')
INSERT KHACH_THUE VALUES (N'Kim Chi','Nam',281030008,N'Bình Định',N'Nhân viên')		
INSERT KHACH_THUE VALUES (N'Cường Văn Tráng','Nam',281030009,N'Bình Dương',N'Sinh viên')
INSERT KHACH_THUE VALUES (N'Võ Tòng','Nam',281030010,N'TP.HCM',N'Lái xe')
INSERT KHACH_THUE VALUES (N'Lâm Sung','Nam',281030846,N'Bình Định',N'Sinh viên')
INSERT KHACH_THUE VALUES (N'Trần Văn Chất','Nam',281024024,N'Tiền Giang',N'Sinh viên')
INSERT KHACH_THUE VALUES (N'Nguyễn Văn D',N'Nữ',289830025,N'Kiên Giang',N'Sinh viên')
INSERT KHACH_THUE VALUES (N'Trần Thị B',N'Nữ',281530026,N'Bình Định',N'Kế toán')
INSERT KHACH_THUE VALUES (N'Nguyễn Thị E','Nam',281097027,N'TP.HCM',N'Sinh viên')		
INSERT KHACH_THUE VALUES (N'John','Nam',281035028,N'Nghệ An',N'Kinh Doanh')
INSERT KHACH_THUE VALUES (N'Nguyễn Văn Văn','Nam',281064001,N'Bình Định',N'Sinh viên')
INSERT KHACH_THUE VALUES (N'Mạc Thị Chanh',N'Nữ',281039402,N'Ninh Thuận',N'Công nhân'	)
INSERT KHACH_THUE VALUES (N'Ô Văn Kìa','Nam',285030003,N'Bình Dương',N'Sinh viên')
INSERT KHACH_THUE VALUES (N'Lao Văn Phổi','Nam',281830004,N'TP.HCM',N'Sinh viên')
INSERT KHACH_THUE VALUES (N'Hành Văn Học','Nam',281044005,N'Ninh Thuận',N'Sinh viên')
INSERT KHACH_THUE VALUES (N'Kim Chỉ Nam','Nam',281030108,N'Bình Định',N'Nhân viên')		
INSERT KHACH_THUE VALUES (N'Cường Đô La','Nam',281030809,N'Ninh Thuận',N'Sinh viên')
INSERT KHACH_THUE VALUES (N'Võ Ngọc','Nam',281033010,N'TP.HCM',N'Lái xe')
INSERT KHACH_THUE VALUES (N'Lâm Trận','Nam',281039011,N'An Giang',N'Sinh viên')
INSERT KHACH_THUE VALUES (N'Trần Văn Dần','Nam',281034024,N'Tiền Giang',N'Sinh viên')
INSERT KHACH_THUE VALUES (N'Nguyễn Văn Dũng',N'Nữ',281530025,N'Kiên Giang',N'Sinh viên')
GO

INSERT CT_KHACH_THUE VALUES ('1', '1','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('2', '1','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('3', '1','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('4', '1','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('5', '4','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('6', '4','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('7', '4','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('8', '4','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('9', '4','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('10', '6','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('11', '6','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('12', '6','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('13', '6','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('14', '6','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('15', '7','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('16', '7','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('17', '7','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('16', '7','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('19', '9','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('20', '9','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('21', '9','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('22', '9','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('23', '9','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('24', '9','02-07-1999')
INSERT CT_KHACH_THUE VALUES ('25', '9','02-07-1999')
GO

INSERT INTO DICH_VU VALUES(N'Điện','3000', N'Đồng/Kwh')
INSERT INTO DICH_VU VALUES(N'Nước','15000', N'Đồng/Khối')
INSERT INTO DICH_VU VALUES(N'Thu gom rác','20000', N'Đồng/Tháng')
INSERT INTO DICH_VU VALUES(N'Phí giữ xe 2 bánh','30000', N'Đồng/Tháng')
INSERT INTO DICH_VU VALUES(N'Phí giữ xe 2 đạp','15000', N'Đồng/Tháng')
INSERT INTO DICH_VU VALUES(N'Truyền hình cáp','100000', N'Đồng/Tháng')
INSERT INTO DICH_VU VALUES(N'Máy giặt','150000', N'Đồng/Tháng')
INSERT INTO DICH_VU VALUES(N'Máy nước nóng','150000', N'Đồng/Tháng')
INSERT INTO DICH_VU VALUES(N'Máy lạnh','200000', N'Đồng/Tháng')
INSERT INTO DICH_VU VALUES(N'Tivi 32 inch','200000', N'Đồng/Tháng')
GO

--Đổi mật khẩu 
create proc DoiMatKhauADMIN
(
	@taikhoan nvarchar(100),
	@matkhaumoi nvarchar(100)
)
as
	begin
		update TAIKHOAN
			set Password = @matkhaumoi
			where Username = @taikhoan
	end
Select MaPhong from PHONGTRO where TrangThai=N'Phòng đã cho thuê'