CREATE DATABASE MyShop
go

USE MyShop
go

CREATE TABLE NhaCungCap(
	IDNCC int Identity not null primary key,
	TenNCC nvarchar(50),
	DiaChi nvarchar(50),
	SDT int,
)
go

CREATE TABLE Account(
	IDAcc int Identity not null primary key,
	TenTK nvarchar(50),
	PassTK int
)
go

CREATE TABLE NhanVien(
	IDNV int Identity not null primary key, 
	TenNV nvarchar(50),
	SDT int,
	Luong float,
	IDAcc int,
	FOREIGN KEY (IDAcc) REFERENCES dbo.Account(IDAcc)
)
go

CREATE TABLE PhieuNhap(
	IDPN int Identity primary key ,
	TenPN nvarchar(50),
	NgayNhap date,
	TongTien float,
	IDNCC int,
	IDNV int,
	FOREIGN KEY (IDNCC) REFERENCES dbo.NhaCungCap(IDNCC),
	FOREIGN KEY (IDNV) REFERENCES dbo.NhanVien(IDNV)
)
GO

CREATE TABLE SanPham(
	IDSP int Identity not null primary key,
	TenSP nvarchar(50),
	MauSac nvarchar(20),
	SLKho int,
	XuatXu nvarchar(20),
	GiaBan float,
	DonViTinh nvarchar(20) ,
)
go

CREATE TABLE KhachHang(
	IDKH int Identity not null primary key,
	TenKH nvarchar(20),
	SDT int,
)
go

CREATE TABLE HoaDon(
	IDHD int Identity not null primary key,
	NgayLap date,
	TongTien float,
	IDKH int,
	FOREIGN KEY (IDKH) REFERENCES dbo.KhachHang(IDKH)
)
go

CREATE TABLE ChiTietPN(
	IDCTPN int Identity not null primary key,
	SoLuong int,
	DonGia float,
	IDSP int NOT NULL,
	IDPN int NOT NULL ,
	FOREIGN KEY (IDSP) REFERENCES dbo.SanPham(IDSP),
	FOREIGN KEY (IDPN) REFERENCES dbo.PhieuNhap(IDPN),
)
go

CREATE TABLE ChiTietHoaDon (
	IDCTHD int Identity not null primary key,
	SoLuong int,
	DonGia float,
	IDSP int not null,
	IDHD int not null,
	FOREIGN KEY (IDSP) REFERENCES dbo.SanPham(IDSP),
	FOREIGN KEY (IDHD) REFERENCES dbo.HoaDon(IDHD),
)
GO
-- Stored Procedure
CREATE PROC SP_GetAccountByUsername
@userName nvarchar(100),
@password nvarchar(100)
AS
BEGIN
	declare @kq int	
	SELECT @kq = count(*) FROM dbo.Account
	WHERE TenTK = @userName and PassTK = @password
	Select @kq as KQ
END
GO

/*----------*/
set dateformat dmy

--Nha Cung Cap
insert into NhaCungCap values(N'Công ty may mặc A', 'Quan 1' ,0912121212)
insert into NhaCungCap values(N'Công ty may mặc B', 'Quan 2' ,0934343434)
insert into NhaCungCap values(N'Công ty may mặc C', 'Quan 3' ,0956565656)
insert into NhaCungCap values(N'Công ty may mặc d','Quan 4' , 0978787878)

--Account
insert into Account values('vi', '1' )
insert into Account values('phat' ,'2')

--Nhan vien
insert into NhanVien values(N'Phan Thị Yến Vi', 0977777777, 3000000, '1')
insert into NhanVien values(N'Thái Tán Phát', 0988888888, 3000000, '2')

--San Pham
insert into SanPham values(N'Áo thun trơn', N'Trắng',100,'VietNam', 200000 ,'VND')
insert into SanPham values(N'Áo thun con mèo', N'Đen',100,'VietNam', 250000 ,'VND')
insert into SanPham values(N'Áo polo đơn sắc', N'Xám',100,'VietNam', 300000 ,'VND')
insert into SanPham values(N'Áo polo họa tiết', N'Trắng',100,'VietNam', 350000 ,'VND')
insert into SanPham values(N'Quân Jean', N'Xanh dương',100,'VietNam', 400000 ,'VND')
insert into SanPham values(N'Quần Jean rách', N'Xanh đen',100,'VietNam', 450000 ,'VND')

--Phieu Nhap
insert into PhieuNhap values(N'Phiếu nhập áo thun trơn', '10-01-2023', 8000000, '1', '1')
insert into PhieuNhap values(N'Phiếu nhập áo thun con mèo', '10-01-2023', 12000000, '2', '1')
insert into PhieuNhap values(N'Phiếu nhập quần jean', '18-01-2023', 19000000, '4', '1')
insert into PhieuNhap values(N'Phiếu nhập quần jean rách', '19-01-2023', 21000000, '4', '2')
insert into PhieuNhap values(N'Phiếu nhập polo đơn sắc', '23-01-2023', 280000000, '1', '2')
insert into PhieuNhap values(N'Phiếu nhập polo họa tiết ', '25-01-2023', 30000000, '3', '1')

--Chi tiet phieu nhap
insert into ChiTietPN values('100', 80000, '1', '1')
insert into ChiTietPN values('100', 120000, '2', '2')
insert into ChiTietPN values('100', 190000, '3', '3')
insert into ChiTietPN values('100', 210000, '4', '4')
insert into ChiTietPN values('100', 280000, '5', '5')
insert into ChiTietPN values('100', 300000, '6', '6')

--Khach hàng
insert into KhachHang values ('Huynh Minh Hoang', 0343250236)
insert into KhachHang values ('Nguyen Thanh Thuyen', 0343250236)
insert into KhachHang values ('Cao Tien Hieu', 0343250236)
insert into KhachHang values ('Phan Minh Quan' ,0343250236)
insert into KhachHang values ('Nguyen Hong An', 0343250236)
insert into KhachHang values ('Vo Bui Minh Hoang', 0343250236)
insert into KhachHang values ('Tran Tien Dat', 0343250236)
insert into KhachHang values ('Tran Thanh', 0343250236)
insert into KhachHang values ('Harri Won', 0343250236)
insert into KhachHang values ('Son Tung', 0343250236)

--Hoa don
insert into HoaDon values ('15-03-2023', 400000,'1')
insert into HoaDon values ('15-03-2023', 400000, '2')
insert into HoaDon values ('15-03-2023', 900000, '3')
insert into HoaDon values ('16-03-2023', 300000, '4')
insert into HoaDon values ('16-03-2023', 700000, '5')
insert into HoaDon values ('17-03-2023', 400000, '6')
insert into HoaDon values ('18-03-2023', 450000, '7')
insert into HoaDon values ('18-03-2023', 300000, '8')
insert into HoaDon values ('18-03-2023', 500000, '9')
insert into HoaDon values ('19-03-2023', 1000000, '10')

--CHi tiets hao don
insert into ChiTietHoaDon values('2', 200000, '1', '1')
insert into ChiTietHoaDon values('1', 400000, '2', '2')
insert into ChiTietHoaDon values('3', 300000, '5', '3')
insert into ChiTietHoaDon values('1', 300000, '1', '4')
insert into ChiTietHoaDon values('2', 350000, '3', '5')
insert into ChiTietHoaDon values('1', 400000, '1', '6')
insert into ChiTietHoaDon values('1', 450000, '6', '7')
insert into ChiTietHoaDon values('1', 300000, '3', '8')
insert into ChiTietHoaDon values('2', 250000, '2', '9')
insert into ChiTietHoaDon values('4', 250000, '2', '10')



















