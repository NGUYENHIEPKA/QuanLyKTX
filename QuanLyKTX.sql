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
	MaTang NVARCHAR(5) NOT NULL,
	HinhAnh VarBinary(max)
)
GO

CREATE TABLE QuanLy(
	MaQL NVARCHAR(8) PRIMARY KEY,
	HoTen NVARCHAR(100) NOT NULL,
	MaTangQL NVARCHAR(5) NOT NULL,
)
GO

CREATE TABLE Tang(
	MaTang NVARCHAR(5) PRIMARY KEY,
	MaNguoiQL NVARCHAR(8) NOT NULL,
)
GO

CREATE TABLE Phong(
	MaPhong NVARCHAR(5) PRIMARY KEY,
	MaTang NVARCHAR(5) NOT NULL,
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
ALTER TABLE dbo.SinhVien ADD FOREIGN KEY (MaTang) REFERENCES dbo.Tang(MaTang)
ALTER TABLE dbo.QuanLy ADD FOREIGN KEY (MaTangQL) REFERENCES dbo.Tang(MaTang)
ALTER TABLE dbo.Tang ADD FOREIGN KEY (MaNguoiQL) REFERENCES dbo.QuanLy(MaQL)
ALTER TABLE dbo.DatPhong ADD FOREIGN KEY (MaNguoiQL) REFERENCES dbo.QuanLy(MaQL)
ALTER TABLE dbo.DatPhong ADD FOREIGN KEY (MaSV) REFERENCES dbo.SinhVien(MaSV)
ALTER TABLE dbo.Phong ADD FOREIGN KEY (MaTang) REFERENCES dbo.Tang(MaTang)
ALTER TABLE dbo.TienDien ADD FOREIGN KEY (MaPhong) REFERENCES dbo.Phong(MaPhong)
ALTER TABLE dbo.TienNuoc ADD FOREIGN KEY (MaPhong) REFERENCES dbo.Phong(MaPhong)
ALTER TABLE dbo.HoaDon ADD FOREIGN KEY (MaPhong) REFERENCES dbo.Phong(MaPhong)
ALTER TABLE dbo.HoaDon ADD FOREIGN KEY (MaPhong, NgayTaoHoaDon) REFERENCES dbo.TienDien(MaPhong, NgayLapBieu)
ALTER TABLE dbo.HoaDon ADD FOREIGN KEY (MaPhong, NgayTaoHoaDon) REFERENCES dbo.TienNuoc(MaPhong, NgayLapBieu)
GO

-- Trigger
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
	DECLARE @TongNuoc FLOAT = @TienDien + @TienNuoc
	UPDATE HoaDon SET SoTien = @TongNuoc WHERE MaPhong = @MaPhong and NgayTaoHoaDon = @NgayTaoHoaDon
END
GO

-- Hàm
CREATE FUNCTION XemDanhSachSinhVien() RETURNS TABLE
AS 
RETURN(
	SELECT * FROM SinhVien
)
GO

CREATE FUNCTION XemDanhSachPhong() RETURNS TABLE
AS 
RETURN(
	SELECT * FROM Phong
)
GO
-- Thủ tục
CREATE PROC UTP_ThemSinhVien
@MaSV CHAR(8),
@HoTen NVARCHAR(100),
@NgaySinh DATE,
@GioiTinh NVARCHAR(3),
@DiaChi NVARCHAR(100),
@SDT CHAR(10),
@MaPhong NVARCHAR(5),
@MaTang NVARCHAR(5),
@SoKy INT,
@HinhAnh VarBinary(max)
AS
BEGIN
	DECLARE @Count INT = 0
	SELECT @Count = COUNT(*) FROM SinhVien WHERE MaSV = @MaSV
	IF (@Count = 0)
	BEGIN DECLARE @Count1 INT, @Count2 INT
	SELECT @Count = LoaiPhong.SoNguoiO, @Count2 = Phong.SoNguoi FROM Phong INNER JOIN LoaiPhong ON Phong.LoaiPhong = LoaiPhong.MaLoaiPhong
	WHERE Phong.MaPhong = @MaPhong
	PRINT (@Count1)
	PRINT (@Count2)
	IF(@Count2 < @Count1)
		BEGIN
			INSERT INTO SinhVien VALUES (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @MaPhong, @MaTang, @HinhAnh)
			DECLARE @MaQL NVARCHAR(8)
			SELECT @MaQL = MaQL FROM QuanLy WHERE MaTangQL = @MaTang
			PRINT(2)
			INSERT INTO DatPhong (MaPhong, MaSV, MaNguoiQL, SoKy, NgayNhanPhong) VALUES (@MaPhong, @MaSV, @MaQL, @SoKy, GETDATE())
		END
	END
END
GO

CREATE PROC UTP_SuaSV
@MaSV CHAR(8),
@HoTen NVARCHAR(100),
@NgaySinh DATE,
@GioiTinh NVARCHAR(3),
@DiaChi NVARCHAR(100),
@SDT CHAR(10),
@HinhAnh VarBinary(max)
AS
BEGIN
	UPDATE SinhVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi,
	SDT = @SDT, HinhAnh = @HinhAnh WHERE MaSV = @MaSV
END
GO

CREATE PROC UTP_XoaSuKienDatPhong
@MaSuKien NVARCHAR(5)
AS
BEGIN
	DELETE FROM DatPhong WHERE MaSuKien = @MaSuKien
END
GO

CREATE PROC UTP_XoaSinhVien
@MaSV CHAR(8)
AS
BEGIN
	DELETE FROM SinhVien WHERE MaSV = @MaSV
END
GO

CREATE PROC UTP_CapNhatChoOSinhVien
@MaSV CHAR(8),
@HoTen NVARCHAR(100),
@NgaySinh DATE,
@GioiTinh NVARCHAR(3),
@DiaChi NVARCHAR(100),
@SDT CHAR(10),
@MaPhong NVARCHAR(5),
@MaTang NVARCHAR(5)
AS
BEGIN
	DECLARE @Count1 INT, @Count2 INT
	SELECT @Count1 = LoaiPhong.SoNguoiO, @Count2 = Phong.SoNguoi FROM Phong INNER JOIN LoaiPhong ON Phong.LoaiPhong = LoaiPhong.GiaTien
	WHERE Phong.MaPhong = @MaPhong
	IF(@Count2 < @Count1)
		UPDATE SinhVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, SDT = @SDT,
		MaPhong = @MaPhong, MaTang = @MaTang
END

create proc UTP_ThemHoaDonDien
	@Maphong nvarchar(5),
	@Thang int , 
	@SoDienDauThang int , 
	@SoDienCuoiThang int
as 
begin 
	declare @TongDien float = (@SoDienCuoiThang - @SoDienDauThang)
	if (@TongDien <= 50)
		insert into TienDien values (@Maphong,@Thang,@SodienDauThang,@SodienCuoiThang,@TongDien * 1806)
	else if (@TongDien > 50 and @TongDien <= 100)
		insert into TienDien values (@Maphong,@Thang,@SodienDauThang,@SodienCuoiThang,(@TongDien-50)*1866 + 50* 1806)
		else if (@TongDien > 100 and @TongDien <= 200)
		insert into TienDien values (@Maphong,@Thang,@SodienDauThang,@SodienCuoiThang,(@TongDien-100)*2167 + 50* 1806 +50*1866)
		else if (@TongDien > 200 and @TongDien <= 300)
		insert into TienDien values (@Maphong,@Thang,@SodienDauThang,@SodienCuoiThang,(@TongDien-200)*2739 + 50* 1806 +50*1866 +100*2167 )
		else if (@TongDien > 300 and @TongDien <= 400)
		insert into TienDien values (@Maphong,@Thang,@SodienDauThang,@SodienCuoiThang,(@TongDien-300)*3050 + 50* 1806+ 50*1866 +100*2167 + 100*2739)
		else if (@TongDien > 400 )
		insert into TienDien values (@Maphong,@Thang,@SodienDauThang,@SodienCuoiThang,(@TongDien-400)*3151 + 50* 1806 + 50*1866 +100*2167 + 100*2739 +100*3050)
end

create proc UTP_ThemHoaDonNuoc
	@Maphong nvarchar(5),
	@Thang int , 
	@SoNuocDauThang int , 
	@SoNnuocCuoiThang int
as 
begin 
	declare @TongNuoc float = (@SoNnuocCuoiThang - @SoNuocDauThang)
	if (@TongNuoc <= 10)
		insert into TienDien values (@Maphong,@Thang,@SoNuocDauThang,@SoNnuocCuoiThang,@TongNuoc * 5973)
	else if (@TongNuoc >10 and @TongNuoc <= 20)
		insert into TienDien values (@Maphong,@Thang,@SoNuocDauThang,@SoNnuocCuoiThang,(@TongNuoc-10)*7052 + 10* 5973)
	else if (@TongNuoc > 20 and @TongNuoc <= 30)
		insert into TienDien values (@Maphong,@Thang,@SoNuocDauThang,@SoNnuocCuoiThang,(@TongNuoc-20)*8669 + 10*7052 +10* 5973)
	else if (@TongNuoc > 30 )
		insert into TienDien values (@Maphong,@Thang,@SoNuocDauThang,@SoNnuocCuoiThang,(@TongNuoc-3)*15925 +20*8669 + 10*7052 +10* 5973 )
		
end
