CREATE DATABASE MyShop
go

Drop Database MyShop
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
	LoaiACC nvarchar(50),
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
CREATE TABLE DanhMuc(
	IDDM int Identity not null primary key,
	TenDM nvarchar(50),
	
)
go
CREATE TABLE SanPham(
	IDSP int Identity not null primary key,
	TenSP nvarchar(50),
	MauSac nvarchar(20),
	SLKho int,
	XuatXu nvarchar(20),
	GiaBan float,
	DonViTinh nvarchar(20) ,
	IDDM int,
	FOREIGN KEY (IDDM) REFERENCES dbo.DanhMuc(IDDM)
)
go

CREATE TABLE KhachHang(
	IDKH int Identity not null primary key,
	TenKH nvarchar(20),
	SDT int,
)
go
ALTER TABLE KhachHang
ALTER COLUMN SDT nvarchar(50);
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
	TongTien float,
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
create proc [dbo].[SP_GetID]
@name nvarchar(50)
as
begin
	select IDAcc from Account where TenTK=@name
end
GO
/*----------*/
CREATE FUNCTION [dbo].[FN_DOANHTHU_THEONHOMHANG](
@NGAYD DATETIME,
@NGAYC DATETIME
)
RETURNS TABLE AS RETURN
SELECT C.IDDM, D.TenDM, SUM(A.TongTien) AS THANHTIEN FROM ChiTietHoaDon A, HoaDon B, SanPham C, DanhMuc D
WHERE A.IDHD = B.IDHD
AND A.IDSP=C.IDSP
AND C.IDDM = D.IDDM
AND B.NgayLap >= CONVERT (DATETIME, @NGAYD, 103)
AND B.NgayLap <=CONVERT (DATETIME, @NGAYC, 103)
GROUP BY C.IDDM, D.TenDM


--Nha Cung Cap
insert into NhaCungCap values(N'Công ty may mặc A', 'Quan 1' ,0912121212)
insert into NhaCungCap values(N'Công ty may mặc B', 'Quan 2' ,0934343434)
insert into NhaCungCap values(N'Công ty may mặc C', 'Quan 3' ,0956565656)
insert into NhaCungCap values(N'Công ty may mặc d','Quan 4' , 0978787878)

--Account
insert into Account values('vi', N'Nhân Viên','1' )
insert into Account values('phat', N'Admin','2')

--Nhan vien
insert into NhanVien values(N'Phan Thị Yến Vi', 0977777777, 3000000, '1')
insert into NhanVien values(N'Thái Tán Phát', 0988888888, 3000000, '2')

--Danh Muc
insert into DanhMuc values(N'Áo thun')
insert into DanhMuc values(N'Quần Jean')

--San Pham
insert into SanPham values(N'Áo thun trơn', N'Trắng',100,'VietNam', 200000 ,'VND',1)
insert into SanPham values(N'Áo thun con mèo', N'Đen',100,'VietNam', 250000 ,'VND',1)
insert into SanPham values(N'Áo polo đơn sắc', N'Xám',100,'VietNam', 300000 ,'VND',1)
insert into SanPham values(N'Áo polo họa tiết', N'Trắng',100,'VietNam', 350000 ,'VND',1)
insert into SanPham values(N'Quân Jean', N'Xanh dương',100,'VietNam', 400000 ,'VND',2)
insert into SanPham values(N'Quần Jean rách', N'Xanh đen',100,'VietNam', 450000 ,'VND',2)


--Phieu Nhap
insert into PhieuNhap values(N'Phiếu nhập áo thun trơn', '2023-01-10', 8000000, '1', '1')
insert into PhieuNhap values(N'Phiếu nhập áo thun con mèo', '2023-01-10', 12000000, '2', '1')
insert into PhieuNhap values(N'Phiếu nhập quần jean', '2023-01-23', 19000000, '4', '1')
insert into PhieuNhap values(N'Phiếu nhập quần jean rách', '2023-01-30', 21000000, '4', '2')
insert into PhieuNhap values(N'Phiếu nhập polo đơn sắc', '2023-01-10', 280000000, '1', '2')
insert into PhieuNhap values(N'Phiếu nhập polo họa tiết ', '2023-01-25', 30000000, '3', '1')

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
insert into HoaDon values ('2023-03-15', 400000,'1')
insert into HoaDon values ('2023-03-15', 400000, '2')
insert into HoaDon values ('2023-03-15', 900000, '3')
insert into HoaDon values ('2023-03-15', 300000, '4')
insert into HoaDon values ('2023-03-16', 700000, '5')
insert into HoaDon values ('2023-03-17', 400000, '6')
insert into HoaDon values ('2023-03-18', 450000, '7')
insert into HoaDon values ('2023-03-18', 300000, '8')
insert into HoaDon values ('2023-03-18', 500000, '9')
insert into HoaDon values ('2023-03-19', 1000000, '10')
insert into HoaDon values ('2023-04-21', 1200000, '1')
insert into HoaDon values ('2023-04-23', 400000, '2')
insert into HoaDon values ('2023-04-23', 200000, '3')

--CHi tiets hoa don
insert into ChiTietHoaDon values('2', 200000, 400000, '1', '1')
insert into ChiTietHoaDon values('1', 400000, 400000,'2', '2')
insert into ChiTietHoaDon values('3', 300000, 900000,'5', '3')
insert into ChiTietHoaDon values('1', 300000, 300000,'1', '4')
insert into ChiTietHoaDon values('2', 350000, 700000,'3', '5')
insert into ChiTietHoaDon values('1', 400000, 400000,'1', '6')
insert into ChiTietHoaDon values('1', 450000, 450000,'6', '7')
insert into ChiTietHoaDon values('1', 300000, 300000,'3', '8')
insert into ChiTietHoaDon values('2', 250000, 500000,'2', '9')
insert into ChiTietHoaDon values('4', 250000, 1000000,'2', '10')
insert into ChiTietHoaDon values('3', 400000, 1200000,'5', '11')
insert into ChiTietHoaDon values('2', 200000, 400000,'1', '12')
insert into ChiTietHoaDon values('1', 200000, 200000, '1', '13')



















