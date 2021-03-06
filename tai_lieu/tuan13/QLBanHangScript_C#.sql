USE master
GO
IF  EXISTS (
	SELECT name 
		FROM sys.databases 
		WHERE name = 'QLBanHang'
)
DROP DATABASE QLBanHang
GO

CREATE DATABASE QLBanHang
GO

USE QLBanHang
GO
CREATE TABLE LoaiSanPham
(
	MaLoai char(3) PRIMARY KEY,
	TenLoai	nvarchar(50) NOT NULL
)
GO
--
INSERT INTO LoaiSanPham(MaLoai,TenLoai)
VALUES('L01',N'Gia dụng')
INSERT INTO LoaiSanPham(MaLoai,TenLoai)
VALUES('L02',N'Điện lạnh')
INSERT INTO LoaiSanPham(MaLoai,TenLoai)
VALUES('L03',N'Điện tử')
--
GO
CREATE TABLE SanPham
(
	MaSP char(4) PRIMARY KEY,
	TenSP nvarchar(50) NOT NULL,
	MaLoai char(3) REFERENCES LoaiSanPham(MaLoai),
	SoLuong int NULL,
	DonGia int NULL
)
GO
--
INSERT INTO SanPham(MaSP,TenSP,MaLoai,SoLuong,DonGia)
VALUES('SP01',N'Nồi cơm điện','L01',1,10)
INSERT INTO SanPham(MaSP,TenSP,MaLoai,SoLuong,DonGia)
VALUES('SP02',N'Điều hòa','L02',2,20)


-- tạo bảng user
GO
CREATE TABLE NguoiDung
(
	TenDangNhap varchar(10) PRIMARY KEY,
	MatKhau varchar(10) 
)
GO
INSERT INTO NguoiDung(TenDangNhap,MatKhau) VALUES('Admin','13579')
INSERT INTO NguoiDung(TenDangNhap,MatKhau) VALUES('User','02468')

-- tạo bảng KhachHang
GO
CREATE TABLE KhachHang
(
 MaKH char(4) PRIMARY KEY,
 TenKH nvarchar(50),
 SoDT varchar(12),
 DiaChi nvarchar(50)
)
GO
-- Thêm dữ liệu vào bảng khách hàng
INSERT INTO KhachHang(MaKH, TenKH, SoDT, DiaChi) VALUES('KH00',N'Khách vãng lai',null,null)
INSERT INTO KhachHang(MaKH, TenKH, SoDT, DiaChi) VALUES('KH01',N'Trần Văn Ngọc','123456',N'Hà nội')
INSERT INTO KhachHang(MaKH, TenKH, SoDT, DiaChi) VALUES('KH02',N'Nguyễn Ngọc Anh','234567',N'Huế')
INSERT INTO KhachHang(MaKH, TenKH, SoDT, DiaChi) VALUES('KH03',N'Bùi Bích Phương','345678',N'HCM')

-- Tạo bảng HoaDon
GO
CREATE TABLE HoaDon
(
  MaHD char(4) PRIMARY KEY,
  NgayLap date DEFAULT GETDATE(),
  MaKH char(4) FOREIGN KEY REFERENCES KhachHang(MaKH) NULL
)
-- Thêm dữ liệu vào bảng HoaDon
INSERT INTO HoaDon(MaHD, NgayLap,MaKH) VALUES('HD01','2020/3/10','KH01')
INSERT INTO HoaDon(MaHD, NgayLap,MaKH) VALUES('HD02','2020/3/15',NULL)
GO
-- Tạo bảng HoaDonChiTiet
CREATE TABLE HoaDonChiTiet
(
  MAHD char(4) FOREIGN KEY REFERENCES HoaDon(MaHD),
  MaSP char(4) FOREIGN KEY REFERENCES SanPham(MaSP),
  PRIMARY KEY (MaHD,MaSP),
  SoLuongMua int
)
-- Thêm dữ liệu vào bảng HoaDonChiTiet
INSERT INTO HoaDonChiTiet(MAHD, MaSP,SoLuongMua) VALUES('HD01','SP01',10)
INSERT INTO HoaDonChiTiet(MAHD, MaSP,SoLuongMua) VALUES('HD02','SP01',20)