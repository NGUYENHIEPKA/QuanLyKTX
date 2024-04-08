CREATE DATABASE QuanLyKTX
GO

USE QuanLyKTX
GO

CREATE TABLE TaiKhoan(
	TaiKhoan NVARCHAR(100) PRIMARY KEY,
	MatKhau	NVARCHAR(100) NOT NULL,
	Loai INT NOT NULL
)
GO

CREATE TABLE SinhVien(
	MaSV CHAR(8) PRIMARY KEY,
	HoTen NVARCHAR(100) NOT NULL,
	NgaySinh DATE NOT NULL,
	GioiTinh NVARCHAR(3) NOT NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	SDT CHAR(10) UNIQUE,
	MaPhong NVARCHAR(5) NOT NULL,
	NgayO DATE NOT NULL,
	HinhAnh VarBinary(max)
)
GO

CREATE TABLE QuanLy(
	MaQL NVARCHAR(8) PRIMARY KEY,
	HoTen NVARCHAR(100) NOT NULL,
	MaKhuQL NVARCHAR(5) NOT NULL,
)
GO

CREATE TABLE KhuVuc(
	MaKhu NVARCHAR(5) PRIMARY KEY,
	MaNguoiQL NVARCHAR(8) NOT NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	TenKhu NVARCHAR(100) NOT NULL,
)
GO

CREATE TABLE Phong(
	MaPhong NVARCHAR(5) PRIMARY KEY,
	MaKhu NVARCHAR(5) NOT NULL,
	MaLoaiPhong NVARCHAR(5) NOT NULL,
	LoaiPhong NVARCHAR(2) NOT NULL,
	SoNguoi INT NOT NULL CHECK (SoNguoi >= 0)
)
GO

CREATE TABLE LoaiPhong(
	MaLoaiPhong NVARCHAR(5) PRIMARY KEY,
	SoNguoiO INT NOT NULL,
	GiaTien FLOAT NOT NULL CHECK (GiaTien > 0)
)
GO

CREATE TABLE DatPhong(
	MaSuKien NVARCHAR(5) PRIMARY KEY,
	MaPhong NVARCHAR(5) NOT NULL,
	MaSV CHAR(8) NOT NULL,
	MaNguoiQL NVARCHAR(8) NOT NULL,
	SoKy INT NOT NULL,
	NgayNhanPhong DATE NOT NULL,
	NgayTraPhong DATE NOT NULL,
	SoTien FLOAT CHECK (SoTien >= 0)
)
GO

CREATE TABLE TienDien(
	MaPhong NVARCHAR(5) NOT NULL,
	NgayLapBieu DATE NOT NULL,
	SoDienCu INT NOT NULL,
	SoDienMoi INT NOT NULL,
	TienDien FLOAT NOT NULL CHECK (TienDien >=0),
	PRIMARY KEY (MaPhong, NgayLapBieu),
	CONSTRAINT CK_SoDienMoi CHECK (SoDienMoi >= SoDienCu)
)
GO

CREATE TABLE TienNuoc(
	MaPhong NVARCHAR(5) NOT NULL,
	NgayLapBieu DATE NOT NULL,
	SoNuocCu INT NOT NULL,
	SoNuocMoi INT NOT NULL,
	TienNuoc FLOAT NOT NULL CHECK (TienNuoc >=0),
	PRIMARY KEY (MaPhong, NgayLapBieu),
	CONSTRAINT CK_SoNuocMoi CHECK (SoNuocMoi >= SoNuocCu)
)
GO

CREATE TABLE HoaDon(
	MaHoaDon INT PRIMARY KEY,
	MaPhong NVARCHAR(5) NOT NULL,
	SoTien FLOAT NOT NULL CHECK (SoTien >= 0),
	PhuongThucThanhToan NVARCHAR(100) NOT NULL,
	LoaiHoaDon NVARCHAR(100) NOT NULL,
	TrangThai BIT NOT NULL,
	NgayTaoHoaDon DATE NOT NULL
)
GO

ALTER TABLE dbo.SinhVien ADD FOREIGN KEY (MaPhong) REFERENCES dbo.Phong(MaPhong)
ALTER TABLE dbo.QuanLy ADD FOREIGN KEY (MaKhuQL) REFERENCES dbo.KhuVuc(MaKhu)
ALTER TABLE dbo.KhuVuc ADD FOREIGN KEY (MaNguoiQL) REFERENCES dbo.QuanLy(MaQL)
ALTER TABLE dbo.DatPhong ADD FOREIGN KEY (MaNguoiQL) REFERENCES dbo.QuanLy(MaQL)
ALTER TABLE dbo.DatPhong ADD FOREIGN KEY (MaSV) REFERENCES dbo.SinhVien(MaSV)
ALTER TABLE dbo.Phong ADD FOREIGN KEY (MaKhu) REFERENCES dbo.KhuVuc(MaKhu)
ALTER TABLE dbo.TienDien ADD FOREIGN KEY (MaPhong) REFERENCES dbo.Phong(MaPhong)
ALTER TABLE dbo.TienNuoc ADD FOREIGN KEY (MaPhong) REFERENCES dbo.Phong(MaPhong)
ALTER TABLE dbo.HoaDon ADD FOREIGN KEY (MaPhong) REFERENCES dbo.Phong(MaPhong)
ALTER TABLE dbo.HoaDon ADD FOREIGN KEY (MaPhong, NgayTaoHoaDon) REFERENCES dbo.TienDien(MaPhong, NgayLapBieu)
ALTER TABLE dbo.HoaDon ADD FOREIGN KEY (MaPhong, NgayTaoHoaDon) REFERENCES dbo.TienNuoc(MaPhong, NgayLapBieu)
GO


-- Thêm trigger
CREATE TRIGGER UTG_AddSinhVien ON SinhVien AFTER INSERT
AS 
BEGIN
	DECLARE @MaSV CHAR(8), @MaPhong NVARCHAR(5)
	SELECT @MaSV = MaSV, @MaPhong = MaPhong FROM INSERTED
	INSERT INTO TaiKhoan VALUES (@MaSV, @MaSV, 0)
	UPDATE Phong SET SoNguoi = SoNguoi + 1 WHERE @MaPhong = MaPhong
END
GO

CREATE TRIGGER UTG_DeleteSinhVien ON SinhVien INSTEAD OF DELETE
AS
BEGIN
	DECLARE @MaSV CHAR(8), @MaPhong NVARCHAR(5)
	SELECT @MaSV = MaSV, @MaPhong = MaPhong FROM DELETED
	DELETE FROM DatPhong WHERE MaSV = @MaSV
	DELETE FROM SinhVien WHERE MaSV = @MaSV
	DELETE FROM TaiKhoan WHERE TaiKhoan = @MaSV
	UPDATE Phong SET SoNguoi = SoNguoi - 1 WHERE MaPhong = @MaPhong
END
GO

CREATE TRIGGER UTG_SuKienDatPhong ON DatPhong AFTER INSERT
AS
BEGIN
	DECLARE @MaPhong NVARCHAR(5), @SoTien FLOAT, @MaSV CHAR(8)
	SELECT @MaPhong = MaPhong, @MaSV = MaSV FROM INSERTED
	SELECT @SoTien = GiaTien FROM Phong INNER JOIN LoaiPhong ON Phong.LoaiPhong = LoaiPhong.MaLoaiPhong
	WHERE Phong.MaPhong = @MaPhong
	UPDATE DatPhong SET NgayTraPhong = DATEADD (MONTH, SoKy * 4, GETDATE()), SoTien = @SoTien * SoKy WHERE MaSV= @MaSV
END
GO

CREATE TRIGGER UTG_AddBill on HoaDon AFTER INSERT
AS
BEGIN 
	DECLARE @TienDien FLOAT, @TienNuoc FLOAT, @MaPhong NVARCHAR(5), @NgayTaoHoaDon DATE
	SELECT @MaPhong = MaPhong, @NgayTaoHoaDon = NgayTaoHoaDon FROM INSERTED
	SELECT @TienDien = TienDien FROM TienDien WHERE MaPhong = @MaPhong AND NgayLapBieu = @NgayTaoHoaDon
	SELECT @TienNuoc = TienNuoc FROM TienNuoc WHERE MaPhong = @MaPhong AND NgayLapBieu = @NgayTaoHoaDon
	DECLARE @TongTien FLOAT = @TienDien + @TienNuoc
	UPDATE HoaDon SET SoTien = @TongTien WHERE MaPhong = @MaPhong and NgayTaoHoaDon = @NgayTaoHoaDon
END
GO
