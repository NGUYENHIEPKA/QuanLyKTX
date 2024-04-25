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
	MaPhong NVARCHAR(5),
	MaTang NVARCHAR(5),
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
	MaHoaDon NVARCHAR(5) PRIMARY KEY,
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
ALTER TABLE dbo.Tang ADD FOREIGN KEY (MaNguoiQL) REFERENCES dbo.QuanLy(MaQL)
ALTER TABLE dbo.DatPhong ADD FOREIGN KEY (MaNguoiQL) REFERENCES dbo.QuanLy(MaQL)
ALTER TABLE dbo.DatPhong ADD FOREIGN KEY (MaSV) REFERENCES dbo.SinhVien(MaSV)
ALTER TABLE dbo.Phong ADD FOREIGN KEY (MaTang) REFERENCES dbo.Tang(MaTang)
ALTER TABLE dbo.Phong ADD FOREIGN KEY (MaLoaiPhong) REFERENCES dbo.LoaiPhong(MaLoaiPhong)
ALTER TABLE dbo.TienDien ADD FOREIGN KEY (MaPhong) REFERENCES dbo.Phong(MaPhong)
ALTER TABLE dbo.TienNuoc ADD FOREIGN KEY (MaPhong) REFERENCES dbo.Phong(MaPhong)
ALTER TABLE dbo.HoaDon ADD FOREIGN KEY (MaPhong) REFERENCES dbo.Phong(MaPhong)
ALTER TABLE dbo.HoaDon ADD FOREIGN KEY (MaPhong, NgayTaoHoaDon) REFERENCES dbo.TienDien(MaPhong, NgayLapBieu)
ALTER TABLE dbo.HoaDon ADD FOREIGN KEY (MaPhong, NgayTaoHoaDon) REFERENCES dbo.TienNuoc(MaPhong, NgayLapBieu)
GO

-- Trigger
CREATE TRIGGER UTG_AddSinhVienVoPhong ON SinhVien AFTER UPDATE
AS 
BEGIN
	DECLARE @MaSV CHAR(8), @MaPhong NVARCHAR(5)
	SELECT @MaSV = MaSV, @MaPhong = MaPhong FROM INSERTED
	UPDATE Phong SET SoNguoi = SoNguoi + 1 WHERE @MaPhong = MaPhong
END
GO

CREATE TRIGGER UTG_DeleteSinhVienKhoiPhong ON SinhVien AFTER DELETE
AS
BEGIN
	DECLARE @MaSV CHAR(8), @MaPhong NVARCHAR(5)
	SELECT @MaSV = MaSV, @MaPhong = MaPhong FROM DELETED
	UPDATE Phong SET SoNguoi = SoNguoi - 1 WHERE MaPhong = @MaPhong
END
GO

CREATE TRIGGER UTG_UpdateSinhVienKhoiPhong ON SinhVien AFTER UPDATE
AS
BEGIN
	DECLARE @MaSV CHAR(8), @MaPhong NVARCHAR(5)
	SELECT @MaSV = MaSV, @MaPhong = MaPhong FROM DELETED
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
	SELECT @TienDien = TienDien FROM TienDien WHERE MaPhong = @MaPhong AND MONTH(NgayLapBieu) = MONTH(@NgayTaoHoaDon)
	SELECT @TienNuoc = TienNuoc FROM TienNuoc WHERE MaPhong = @MaPhong AND MONTH(NgayLapBieu) = MONTH(@NgayTaoHoaDon)
	DECLARE @TongTien FLOAT = @TienDien + @TienNuoc
	UPDATE HoaDon SET SoTien = @TongTien WHERE MaPhong = @MaPhong and NgayTaoHoaDon = @NgayTaoHoaDon
END
GO

create proc InsertTongHoaDon
@MaHoaDon NVARCHAR(5),
@MaPhong NVARCHAR(5),
@PhuongThucThanhToan NVARCHAR(100),
@LoaiHoaDon NVARCHAR(100),
@NgayTaoHoaDon DATE
AS
BEGIN
	insert into HoaDon (MaHoaDon, MaPhong, SoTien, PhuongThucThanhToan, LoaiHoaDon, TrangThai , NgayTaoHoaDon)
	values
	(@MaHoaDon, @MaPhong, '', @PhuongThucThanhToan, @LoaiHoaDon, 0, @NgayTaoHoaDon)
END

-- Hàm
CREATE FUNCTION XemDanhSachSinhVien() RETURNS TABLE
AS 
RETURN(
    SELECT MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, SDT, MaPhong, MaTang, HinhAnh FROM SinhVien
)
GO

CREATE FUNCTION XemListHoaDon() RETURNS TABLE
AS
RETURN(
	SELECT * FROM HoaDon
)
GO

CREATE FUNCTION XemListHoaDonNuoc() RETURNS TABLE
AS
RETURN(
	SELECT * FROM TienNuoc
)
GO

CREATE FUNCTION XemListHoaDonDien() RETURNS TABLE
AS
RETURN(
	SELECT * FROM TienDien
)
GO
	
CREATE FUNCTION XemDanhSachPhong() RETURNS TABLE
AS 
RETURN(
	SELECT * FROM Phong
)
GO
-- Thủ tục
create proc DangKyTaiKhoanSinhVien
@MaSV CHAR(8),
@HoTen NVARCHAR(100),
@GioiTinh NVARCHAR(3),
@NgaySinh DATE,
@DiaChi NVARCHAR(100),
@SDT CHAR(10)
AS 
BEGIN
	IF EXISTS (Select 1 from TaiKhoan where TaiKhoan = @MaSV)
		RAISERROR('Đã có tài khoản.', 16, 1)
	ELSE
	BEGIN
		insert into TaiKhoan (TaiKhoan, MatKhau, Loai) values (@MaSV, @MaSV, 1)
		insert into SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, SDT) values (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SDT)
	END
END
	
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
	IF EXISTS (SELECT 1 FROM SinhVien WHERE MaSV = @MaSV)
	BEGIN
		DELETE FROM SinhVien WHERE MaSV = @MaSV
		DELETE FROM TaiKhoan WHERE TaiKhoan = @MaSV
	END
	ELSE
	BEGIN
		RAISERROR('Không có sinh viên để xóa.', 16, 1)
	END
END
GO

CREATE PROC UTP_CapNhatChoOSinhVien
@MaSV CHAR(8),
@MaPhong NVARCHAR(5),
@MaTang NVARCHAR(5)
AS
BEGIN
	DECLARE @Count1 INT, @Count2 INT
	SELECT @Count1 = LoaiPhong.SoNguoiO, @Count2 = Phong.SoNguoi FROM Phong INNER JOIN LoaiPhong ON Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong
	WHERE Phong.MaPhong = @MaPhong
	IF(@Count2 < @Count1)
		UPDATE SinhVien SET MaPhong = @MaPhong, MaTang = @MaTang WHERE MaSV = @MaSV
	ELSE
	BEGIN
		RAISERROR('Số lượng người trong phòng vượt quá số lượng tối đa.', 16, 1)
	END
END
GO

CREATE PROC UTP_CapNhatThongTinSinhVien
@MaSV CHAR(8),
@HoTen NVARCHAR(100),
@NgaySinh DATE,
@GioiTinh NVARCHAR(3),
@DiaChi NVARCHAR(100),
@SDT CHAR(10)
AS
BEGIN
	IF (@HoTen = Null OR @NgaySinh = NULL OR @GioiTinh = NULL OR @DiaChi = NULL OR @SDT = NULL )
		RAISERROR('Vui lòng nhập đủ thông tin.', 16, 1)		
	ELSE
	BEGIN
		UPDATE SinhVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, DiaChi = @DiaChi, SDT = @SDT WHERE MaSV = @MaSV
	END
END
GO

CREATE PROC UTP_DoiMatKhau
@TaiKhoan NVARCHAR(100),
@MatKhauCu NVARCHAR(100),
@MatKhauMoi1 NVARCHAR(100),
@MatKhauMoi2 NVARCHAR(100)
AS
BEGIN
    IF @MatKhauCu = '' OR @MatKhauMoi1 = '' OR @MatKhauMoi2 = ''
    BEGIN
        RAISERROR ('Vui lòng nhập đầy đủ', 16, 1)
        RETURN;
    END
	IF NOT EXISTS (SELECT 1 FROM TaiKhoan WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhauCu)
	BEGIN
		RAISERROR ('Nhập sai mật khẩu cũ', 16, 1)
		RETURN;
	END
    IF @MatKhauMoi1 <> @MatKhauMoi2
    BEGIN
        RAISERROR ('Hai mật khẩu mới không trùng nhau', 16, 1)
        RETURN;
    END
	IF @MatKhauCu = @MatKhauMoi1
	BEGIN
        RAISERROR ('Hai mật khẩu mới và cũ trùng nhau', 16, 1)
		RETURN;
	END

    UPDATE TaiKhoan SET MatKhau = @MatKhauMoi1 WHERE TaiKhoan = @TaiKhoan;
END
	
create trigger UTP_ThemHoaDonDien on TienDien AFTER INSERT
AS
BEGIN
	DECLARE	@Maphong nvarchar(5), @NgayTaoHoaDon DATE , @SoDienDauThang int , @SoDienCuoiThang int, @TongDien float
	SELECT @Maphong = MaPhong, @NgayTaoHoaDon = NgayLapBieu, @SoDienDauThang = SoDienCu, @SoDienCuoiThang = SoDienMoi FROM INSERTED
	SET @TongDien = (@SoDienCuoiThang - @SoDienDauThang)
	if (@TongDien <= 50)
		UPDATE TienDien SET TienDien = @TongDien * 1806 WHERE @Maphong = MaPhong AND @NgayTaoHoaDon = NgayLapBieu
	else if (@TongDien > 50 and @TongDien <= 100)
		UPDATE TienDien SET TienDien = (@TongDien-50)*1866 + 50* 1806 WHERE @Maphong = MaPhong AND @NgayTaoHoaDon = NgayLapBieu
	else if (@TongDien > 100 and @TongDien <= 200)
		UPDATE TienDien SET TienDien = (@TongDien-100)*2167 + 50* 1806 +50*1866 WHERE @Maphong = MaPhong AND @NgayTaoHoaDon = NgayLapBieu
	else if (@TongDien > 200 and @TongDien <= 300)
		UPDATE TienDien SET TienDien = (@TongDien-200)*2739 + 50* 1806 +50*1866 +100*2167 WHERE @Maphong = MaPhong AND @NgayTaoHoaDon = NgayLapBieu
	else if (@TongDien > 300 and @TongDien <= 400)
		UPDATE TienDien SET TienDien = (@TongDien-300)*3050 + 50* 1806+ 50*1866 +100*2167 + 100*2739 WHERE @Maphong = MaPhong AND @NgayTaoHoaDon = NgayLapBieu
	else if (@TongDien > 400 )
		UPDATE TienDien SET TienDien = (@TongDien-400)*3151 + 50* 1806 + 50*1866 +100*2167 + 100*2739 +100*3050 WHERE @Maphong = MaPhong AND @NgayTaoHoaDon = NgayLapBieu
end
GO

create trigger UTP_ThemHoaDonNuoc on TienNuoc AFTER INSERT
AS
BEGIN
	DECLARE @Maphong nvarchar(5), @NgayTaoHoaDon DATE , @SoNuocDauThang int , @SoNuocCuoiThang int, @TongNuoc float
	SELECT @Maphong = MaPhong, @NgayTaoHoaDon = NgayLapBieu, @SoNuocDauThang = SoNuocCu, @SoNuocCuoiThang = SoNuocMoi FROM INSERTED
	SET @TongNuoc = (@SoNuocCuoiThang - @SoNuocDauThang)
	if (@TongNuoc <= 10)
		UPDATE TienNuoc SET TienNuoc = @TongNuoc * 5973 WHERE @Maphong = MaPhong AND @NgayTaoHoaDon = NgayLapBieu
	else if (@TongNuoc >10 and @TongNuoc <= 20)
		UPDATE TienNuoc SET TienNuoc = (@TongNuoc-10)*7052 + 10* 5973 WHERE @Maphong = MaPhong AND @NgayTaoHoaDon = NgayLapBieu
	else if (@TongNuoc > 20 and @TongNuoc <= 30)
		UPDATE TienNuoc SET TienNuoc = (@TongNuoc-20)*8669 + 10*7052 +10* 5973 WHERE @Maphong = MaPhong AND @NgayTaoHoaDon = NgayLapBieu
	else if (@TongNuoc > 30 )
		UPDATE TienNuoc SET TienNuoc = (@TongNuoc-3)*15925 +20*8669 + 10*7052 +10* 5973 WHERE @Maphong = MaPhong AND @NgayTaoHoaDon = NgayLapBieu
end

create proc InsertTienNuoc
@MaPhong nvarchar(5),
@NgayTaoHoaDon DATE,
@SoNuocDauThang int,
@SoNuocCuoiThang int
AS
BEGIN
	IF (@SoNuocDauThang > @SoNuocCuoiThang)
	BEGIN
        RAISERROR ('Số cũ không được lớn hơn số mới', 16, 1)
	END
	ELSE
	BEGIN
		insert into TienNuoc (MaPhong, NgayLapBieu, SoNuocCu, SoNuocMoi, TienNuoc) VALUES (@MaPhong, @NgayTaoHoaDon, @SoNuocDauThang, @SoNuocCuoiThang, '')
	END
END

create proc InsertTienDien
@MaPhong nvarchar(5),
@NgayTaoHoaDon DATE,
@SoDienDauThang int,
@SoDienCuoiThang int
AS
BEGIN
	IF (@SoDienDauThang > @SoDienCuoiThang)
	BEGIN
        RAISERROR ('Số cũ không được lớn hơn số mới', 16, 1)
	END
	BEGIN
		insert into TienDien (MaPhong, NgayLapBieu, SoDienCu, SoDienMoi, TienDien) VALUES (@MaPhong, @NgayTaoHoaDon, @SoDienDauThang, @SoDienCuoiThang, '')
	END
END


create proc UpdateHoaDon
@MaHoaDon nvarchar(5),
@TrangThai bit
AS
BEGIN
	update HoaDon set TrangThai = @TrangThai where @MaHoaDon = @MaHoaDon
END

create proc DeleteHoaDon
@MaHoaDon nvarchar(5),
@NgayTaoHoaDon DATE
as
begin
	IF EXISTS (SELECT 1 FROM HoaDon WHERE MaHoaDon = @MaHoaDon)
	BEGIN
		delete from TienDien where MONTH(NgayLapBieu) = MONTH(@NgayTaoHoaDon) AND YEAR(NgayLapBieu) = YEAR (NgayLapBieu)
		delete from TienNuoc where MONTH(NgayLapBieu) = MONTH(@NgayTaoHoaDon) AND YEAR(NgayLapBieu) = YEAR (NgayLapBieu)
		delete from HoaDon where MaHoaDon = @MaHoaDon
	END
	ELSE
	BEGIN 
        RAISERROR('Không có hóa đơn để xóa.', 16, 1)
	END
end
	
CREATE PROCEDURE UTP_ThemPhong (
    @MaPhong NVARCHAR(5),
    @MaTang NVARCHAR(5),
    @MaLoaiPhong NVARCHAR(5),
    @LoaiPhong NVARCHAR(2),
    @SoNguoi INT
)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Phong WHERE MaPhong = @MaPhong)
    BEGIN
        RAISERROR('Phòng đã tồn tại.', 16, 1)
        RETURN;
    END

    INSERT INTO Phong (MaPhong, MaTang, MaLoaiPhong, LoaiPhong, SoNguoi)
    VALUES (@MaPhong, @MaTang, @MaLoaiPhong, @LoaiPhong, @SoNguoi);

    PRINT 'Thêm phòng thành công.';
END

CREATE PROCEDURE UTP_SuaPhong (
    @MaPhong NVARCHAR(5),
    @MaTang NVARCHAR(5),
    @MaLoaiPhong NVARCHAR(5),
    @LoaiPhong NVARCHAR(2),
    @SoNguoi INT
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Phong WHERE MaPhong = @MaPhong)
    BEGIN
        RAISERROR('Phòng không tồn tại.', 16, 1)
        RETURN;
    END

    UPDATE Phong
    SET MaTang = @MaTang, MaLoaiPhong = @MaLoaiPhong, LoaiPhong = @LoaiPhong, SoNguoi = @SoNguoi
    WHERE MaPhong = @MaPhong;

    PRINT 'Sửa phòng thành công.';
END


CREATE PROCEDURE UTP_XoaPhong (
    @MaPhong NVARCHAR(5)
)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM Phong WHERE MaPhong = @MaPhong)
    BEGIN
        RAISERROR('Phòng không tồn tại.', 16, 1)
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM SinhVien WHERE MaPhong = @MaPhong)
    BEGIN
        RAISERROR('Phòng có sinh viên đang ở, không thể xóa.', 16, 1)
        RETURN;
    END

    DELETE FROM Phong WHERE MaPhong = @MaPhong;

    PRINT 'Xóa phòng thành công.';
END


-- Insert dữ liệu
INSERT INTO Tang (MaTang, MaNguoiQL) VALUES ('T01', 'QL001');
INSERT INTO Tang (MaTang, MaNguoiQL) VALUES ('T02', 'QL002');
INSERT INTO Tang (MaTang, MaNguoiQL) VALUES ('T03', 'QL003');
INSERT INTO Tang (MaTang, MaNguoiQL) VALUES ('T04', 'QL004');
INSERT INTO Tang (MaTang, MaNguoiQL) VALUES ('T05', 'QL005');
GO

INSERT INTO QuanLy (MaQL, HoTen, MaTangQL) VALUES ('QL001', 'Nguyen Van A', 'T01');
INSERT INTO QuanLy (MaQL, HoTen, MaTangQL) VALUES ('QL002', 'Tran Thi B', 'T02');
INSERT INTO QuanLy (MaQL, HoTen, MaTangQL) VALUES ('QL003', 'Le Van C', 'T03');
INSERT INTO QuanLy (MaQL, HoTen, MaTangQL) VALUES ('QL004', 'Hoang Thi D', 'T04');
INSERT INTO QuanLy (MaQL, HoTen, MaTangQL) VALUES ('QL005', 'Pham Van E', 'T05');
GO

INSERT INTO Phong (MaPhong, MaTang, MaLoaiPhong, LoaiPhong, SoNguoi) 
VALUES ('A04', 'T01', 'L04', '4', 4),
       ('E08', 'T02', 'L08', '8', 1)
GO



INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, DiaChi, SDT, MaPhong, MaTang, HinhAnh) 
VALUES ('SV001', 'Nguyen Van A', '2000-01-01', 'Nam', '123 ABC Street', '0123456789', 'A04', 'T01', NULL),
       ('SV002', 'Tran Thi B', '2001-02-02', 'Nu', '456 XYZ Street', '0987654321', 'A04', 'T01', NULL),
       ('SV003', 'Le Van C', '1999-03-03', 'Nam', '789 QWE Street', '0369852471', 'A04', 'T01', NULL),
       ('SV004', 'Pham Thi D', '1998-04-04', 'Nu', '147 RTY Street', '0957348612', 'A04', 'T01', NULL),
       ('SV005', 'Hoang Van E', '2002-05-05', 'Nam', '258 UIO Street', '0738192546', 'E08', 'T05', NULL);
GO

update SinhVien
set HinhAnh = (Select BulkColumn from openrowset (bulk N'D:\ktx\Project DBMS\Resources\AnhSinhVienSV001.jpg', single_blob) as HinhAnh) where MaSV = 'SV001'

update SinhVien
set HinhAnh = (Select BulkColumn from openrowset (bulk N'D:\ktx\Project DBMS\Resources\AnhSinhVienSV002.jpg', single_blob) as HinhAnh) where MaSV = 'SV002'

update SinhVien
set HinhAnh = (Select BulkColumn from openrowset (bulk N'D:\ktx\Project DBMS\Resources\AnhSinhVienSV003.jpg', single_blob) as HinhAnh) where MaSV = 'SV003'

update SinhVien
set HinhAnh = (Select BulkColumn from openrowset (bulk N'D:\ktx\Project DBMS\Resources\AnhSinhVienSV004.jpg', single_blob) as HinhAnh) where MaSV = 'SV004'

update SinhVien
set HinhAnh = (Select BulkColumn from openrowset (bulk N'D:\ktx\Project DBMS\Resources\AnhSinhVienSV005.jpg', single_blob) as HinhAnh) where MaSV = 'SV005'

INSERT INTO LoaiPhong (MaLoaiPhong, SoNguoiO, GiaTien) VALUES 
('L04', 4, 360000),
('L08', 8, 280000)
INSERT INTO TaiKhoan(TaiKhoan, MatKhau, loai) VALUES
('QL001','QL001',0),
('QL002','QL002',0),
('QL003','QL003',0),
('QL004','QL004',0),
('QL005','QL005',0),
('SV002','SV002',1),
('SV003','SV003',1),
('SV004','SV004',1),
('SV005','SV005',1)
