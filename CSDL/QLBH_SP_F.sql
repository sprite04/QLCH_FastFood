USE QLBH_FastFood
GO

CREATE PROCEDURE sp_Login(@MaNV INT)
AS 
SELECT *
FROM NHANVIEN
WHERE MaNV=@MaNV
GO

DROP FUNCTION fn_GiaGoc
CREATE FUNCTION fn_GiaGoc(@MaSP INT)
RETURNS INT AS
BEGIN
	DECLARE @GiaGoc INT
	SELECT @GiaGoc=SUM(NL.GiaNL*CB.SoLuong)
	FROM dbo.NGUYENLIEU NL, dbo.CHEBIEN CB
	WHERE CB.MaSP=@MaSP AND CB.MaNL=NL.MaNL
	IF @GiaGoc IS NULL
	SET @GiaGoc=0
	RETURN @GiaGoc
END
GO

DROP FUNCTION fn_GiaBan
CREATE FUNCTION fn_GiaBan(@MaSP INT)
RETURNS INT AS
BEGIN
	DECLARE @GiaBan INT
	SELECT @GiaBan=dbo.fn_GiaGoc(@MaSP)*(SP.LoiNhuan-SP.GiamGia)
	FROM dbo.SANPHAM SP
	WHERE SP.MaSP=@MaSP
	IF @GiaBan IS NULL
	SET @GiaBan=0
	RETURN @GiaBan
END
GO


CREATE VIEW v_SanPham
AS
SELECT SP.MaSP, SP.TenSP,SP.HinhSP,dbo.fn_GiaGoc(SP.MaSP) AS GiaGoc,dbo.fn_GiaBan(SP.MaSP) AS GiaBan
FROM dbo.SANPHAM SP
WHERE SP.TT_Ban='True'
GO

CREATE PROCEDURE sp_ThemSanPham(@MaSP INT, @HinhSP IMAGE, 
                                @TenSP NVARCHAR(30),@TT_Ban BIT, 
								@TT_Con BIT,@LoiNhuan FLOAT,@GiamGia FLOAT)
AS
INSERT dbo.SANPHAM
VALUES  ( @MaSP , -- MaSP - int
          @HinhSP , -- HinhSP - image
          @TenSP , -- TenSP - nvarchar(30)
          @TT_Ban , -- TT_Ban - bit
          @TT_Con , -- TT_Con - bit
          @LoiNhuan , -- LoiNhuan - float
          @GiamGia  -- GiamGia - float
        )
GO

CREATE PROCEDURE sp_SuaSanPham(@MaSP INT, @HinhSP IMAGE, 
                                @TenSP NVARCHAR(30),@TT_Ban BIT, 
								@TT_Con BIT,@LoiNhuan FLOAT,@GiamGia FLOAT)
AS
UPDATE dbo.SANPHAM SET HinhSP=@HinhSP, TenSP=@TenSP, TT_Ban=@TT_Ban,TT_Con=@TT_Con,LoiNhuan=@LoiNhuan, GiamGia=@GiamGia
WHERE MaSP=@MaSP
GO

CREATE PROCEDURE sp_ThemCheBien(@MaSP INT, @MaNL INT, @SL INT)
AS
INSERT dbo.CHEBIEN
VALUES  ( @MaSP, -- MaSP - int
          @MaNL, -- MaNL - int
          @SL  -- SoLuong - int
          )
GO


CREATE PROCEDURE sp_XoaCheBien(@MaSP INT)
AS
DELETE FROM dbo.CHEBIEN WHERE MaSP=@MaSP
GO

CREATE PROCEDURE sp_NguyenLieuDGV(@MaSP INT)
AS
SELECT NL.MaNL AS MaNL, NL.TenNL AS TenNL,NL.GiaNL AS GiaNL, CB.SoLuong AS SL
FROM dbo.NGUYENLIEU NL, dbo.CHEBIEN CB
WHERE CB.MaSP=@MaSP AND CB.MaNL=NL.MaNL AND NL.TT_Ban='True'
GO

--can tao trigger khi nao nguyen lieu bi xoa thi phai chuyen trang thai tt_con

CREATE PROCEDURE sp_ThemNguyenLieu(@MaNL INT,@TenNL NVARCHAR(30),@GiaNL INT,@DonVi NVARCHAR(15),@SL INT, @TT_Ban BIT)
AS
	INSERT dbo.NGUYENLIEU
	VALUES  ( @MaNL , -- MaNL - int
	          @TenNL , -- TenNL - nvarchar(30)
	          @GiaNL , -- GiaNL - int
	          @DonVi , -- DonVi - nvarchar(15)
	          @SL , -- SLTonKho - int
	          @TT_Ban  -- TT_Ban - bit
	        )
GO

CREATE PROCEDURE sp_SuaNguyenLieu(@MaNL INT,@TenNL NVARCHAR(30),@GiaNL INT,@DonVi NVARCHAR(15),@SL INT, @TT_Ban BIT)
AS
	UPDATE dbo.NGUYENLIEU SET TenNL=@TenNL, GiaNL=@GiaNL, DonVi=@DonVi, SLTonKho=@SL, TT_Ban=@TT_Ban
	WHERE MaNL=@MaNL
GO

CREATE VIEW v_NguyenLieu
AS
SELECT *
FROM dbo.NGUYENLIEU NL
WHERE NL.TT_Ban='True'
GO

CREATE VIEW v_NhanVien
AS
SELECT NV.MaNV AS MaNV, NV.HoTen AS HoTen, NV.GT AS GT, NV.CMND AS CMND, NV.SDT AS SDT,CV.TenCV AS TenCV,CV.MaCV AS MaCV
FROM dbo.NHANVIEN NV,dbo.CHUCVU CV
WHERE NV.TT_Lam='True' AND NV.MaCV=CV.MaCV
GO

CREATE PROCEDURE sp_ThemNhanVien(@MaNV INT, @HoTen NVARCHAR(30),@GT BIT,
                                 @CMND VARCHAR(15), @SDT VARCHAR(12),@DiaChi NVARCHAR(50),
								 @TT_Lam BIT,@MatKhau VARCHAR(50),@MaCV INT)
AS
INSERT dbo.NHANVIEN
VALUES  ( @MaNV , -- MaNV - int
          @HoTen , -- HoTen - nvarchar(30)
          @GT , -- GT - bit
          @CMND , -- CMND - varchar(15)
          @SDT , -- SDT - varchar(12)
          @DiaChi, -- DiaChi - nvarchar(50)
          @TT_Lam , -- TT_Lam - bit
          @MatKhau , -- MatKhau - varchar(50)
          @MaCV  -- MaCV - int
        )
GO

CREATE PROCEDURE sp_SuaNhanVien(@MaNV INT, @HoTen NVARCHAR(30),@GT BIT,
                                @CMND VARCHAR(15), @SDT VARCHAR(12),@DiaChi NVARCHAR(50),
								@TT_Lam BIT,@MatKhau VARCHAR(50),@MaCV INT)
AS
UPDATE dbo.NHANVIEN SET HoTen=@HoTen, GT=@GT,CMND=@CMND,SDT=@SDT,DiaChi=@DiaChi,TT_Lam=@TT_Lam,MatKhau=@MatKhau,MaCV=@MaCV
WHERE MaNV=@MaNV
GO

CREATE VIEW v_HoaDon
AS
SELECT *
FROM dbo.HOADON HD
WHERE HD.TT_HD='true'
GO


CREATE PROCEDURE sp_ChiTietDGV(@MaHD INT)
AS
SELECT CT.MaHD AS MaHD,CT.MaSP AS MaSP, CT.SL AS SL, SP.TenSP AS TenSP
FROM dbo.CHITIET_HD CT,dbo.SANPHAM SP
WHERE CT.MaHD=@MaHD AND SP.MaSP=CT.MaSP
GO

CREATE PROCEDURE sp_ThemHoaDon(@MaHD INT)
AS
INSERT dbo.HOADON
VALUES  ( @MaHD , -- MaHD - int
          0 , -- TongTien - int
          0 , -- TongGiaSP - int
          GETDATE() , -- Ngay - date
          'true'  -- TT_HD - bit
        )
GO

CREATE PROCEDURE sp_XoaHoaDon(@MaHD INT)
AS
UPDATE dbo.HOADON SET TT_HD='false'
WHERE MaHD=@MaHD
GO

CREATE PROCEDURE sp_ThemCa(@MaCa DATETIME)
AS
INSERT dbo.CA
VALUES  ( @MaCa, -- MaCa - datetime
          5  -- SoGio - int
          )
GO

CREATE PROCEDURE sp_Ca(@Ngay DATETIME)
AS
SELECT *
FROM dbo.CA C
WHERE DAY(C.MaCa)=DAY(@Ngay) AND MONTH(C.MaCa)=MONTH(@Ngay) AND YEAR(C.MaCa)=YEAR(@Ngay)
GO

CREATE PROCEDURE sp_DiemDanh(@Ngay DATETIME)
AS
SELECT *
FROM dbo.DIEMDANH
WHERE DAY(MaCa)=DAY(@Ngay) AND MONTH(MaCa)=MONTH(@Ngay) AND YEAR(MaCa)=YEAR(@Ngay)
GO

CREATE PROCEDURE sp_ThemDiemDanh(@Ngay DATETIME,@MaNV INT)
AS
INSERT dbo.DIEMDANH
VALUES  ( @MaNV, -- MaNV - int
          @Ngay  -- MaCa - datetime
          )
GO

CREATE PROCEDURE sp_XoaDiemDanh(@Ngay DATETIME)
AS
DELETE dbo.DIEMDANH
WHERE MaCa=@Ngay
GO

CREATE PROCEDURE sp_ThemChiTietHD(@MaHD INT, @MaSP INT, @SL INT)
AS
INSERT dbo.CHITIET_HD
VALUES  ( @MaHD, -- MaHD - int
          @MaSP, -- MaSP - int
          @SL  -- SL - int
          )
GO

--Thieu Quan
--View ShiftAndEmployee:
CREATE VIEW v_ShiftAndEmployee
AS
SELECT dbo.NHANVIEN.MaNV AS MaNV, dbo.NHANVIEN.HoTen AS HoTen, dbo.DIEMDANH.MaCa AS MaCa,
		dbo.CHUCVU.TenCV AS TenCV, dbo.NHANVIEN.GT AS GT, dbo.NHANVIEN.CMND AS CMND, dbo.NHANVIEN.SDT AS SDT
FROM dbo.NHANVIEN, dbo.DIEMDANH, dbo.CHUCVU
WHERE dbo.NHANVIEN.MaNV = dbo.DIEMDANH.MaNV AND dbo.NHANVIEN.MaCV = dbo.CHUCVU.MaCV
GO
--
SELECT *
FROM dbo.v_ShiftAndEmployee


------------------------------------------------------------------------------------------------------------------
----------------------------------------------Truong An-----------------------------------------------------------
------------------------------------------------------------------------------------------------------------------
GO



ALTER PROCEDURE sp_ThemLuong(@MaNV INT, @Thang INT, @nam INT)
AS	
BEGIN
IF NOT EXISTS 
		(SELECT *  
		 FROM dbo.LUONG
		 WHERE MaNV = @MaNV AND Thang = @Thang AND Nam = @nam)
		 BEGIN

				INSERT dbo.LUONG
				( MaNV ,
				  Thang ,
				  Nam ,
				  NgayTL ,
				  LuongCB ,
				  LuongTong
				)
				VALUES  
				( @MaNV , -- MaNV - int
				  @Thang , -- Thang - int
				  @nam , -- Nam - int
				  NULL , -- NgayTL - date
				  20000 , -- LuongCB - int
				  0  -- LuongTong - int
				)
		 END

END 

GO
alter PROCEDURE sp_TraLuong(@MaNV INT, @Thang INT, @nam INT, @date date)
AS 
	UPDATE dbo.LUONG SET NgayTL = @date WHERE MaNV = @MaNV AND Thang = @Thang AND Nam = @nam
go




ALTER VIEW v_LUONG
AS
SELECT NV.MaNV AS MaNV, NV.HoTen AS HoTen, NV.GT AS GT, NV.CMND AS CMND,CV.TenCV AS TenCV, dbo.fn_TongSoGio(NV.MaNV,DATETIMEFROMPARTS(L.Nam,L.Thang,1,5,0,0,0)) AS SoGioLamViec, L.LuongTong AS Luong, L.Thang AS Thang, L.Nam AS Nam
FROM dbo.NHANVIEN NV,dbo.CHUCVU CV,dbo.LUONG L
WHERE NV.TT_Lam='True' AND NV.MaCV=CV.MaCV AND NV.MaNV = L.MaNV
GO


--loc luong theo thang
ALTER PROCEDURE st_LUONG (@nam INT, @thang int)
AS
SELECT *
FROM dbo.v_LUONG
WHERE dbo.v_LUONG.Thang = @thang AND dbo.v_LUONG.Nam = @nam


go
--function kiemtra tra luong thang nay chua
ALTER FUNCTION fn_TraLuongCheck(@nam INT, @thang INT)
RETURNS int
AS
BEGIN
	DECLARE @da DATE
	DECLARE @manv INT 
	DECLARE @bool int
    SELECT @da = NgayTL
	FROM dbo.LUONG
	WHERE nam = @nam AND Thang = @thang
	SELECT @manv =  MaNV
	FROM dbo.LUONG
	WHERE nam = @nam AND Thang = @thang
	IF @da IS NULL AND @manv IS NOT NULL
		SET @bool = 1
	ELSE 
		SET @bool = 0
	RETURN @bool
END
go
SELECT dbo.fn_TraLuongCheck(2020,12)
go
--store procedure tra luong
ALTER PROCEDURE sp_TraLuong(@nam INT, @thang int, @ngayTL date)
AS
	IF dbo.fn_TraLuongCheck(@nam,@thang) = 1
		UPDATE dbo.LUONG SET NgayTL=@ngayTL WHERE Thang = @thang AND Nam = @nam


GO

--
CREATE PROCEDURE sp_TaoTK(@nam INT, @Thang INT )
AS 
IF NOT EXISTS 
		(SELECT Thang  
		 FROM dbo.THONGKE_T
		 WHERE Thang = @Thang AND Nam = @nam)
		 INSERT INTO dbo.THONGKE_T
		         ( Thang ,
		           Nam ,
		           TongLuong ,
		           TongGiaNL ,
		           TongDoanhThu
		         )
		 VALUES  ( @Thang , -- Thang - int
		           @nam , -- Nam - int
		           0 , -- TongLuong - int
		           0 , -- TongGiaNL - int
		           0  -- TongDoanhThu - int
		         )




				



GO
ALTER PROCEDURE GetRevenueByDate(@thang INT, @nam int) 
AS
SELECT TK.TongLuong,TK.TongGiaNL,TK.TongDoanhThu, (TK.TongDoanhThu-TK.TongGiaNL-TK.TongLuong) AS LoiNhuan
FROM dbo.THONGKE_T TK
WHERE TK.Thang = @thang AND TK.Nam = @nam

EXEC dbo.GetRevenueByDate @thang = 12, -- int
    @nam = 2020 -- int


GO

ALTER PROCEDURE GetRevenueByYear(@nam int) 
AS
SELECT TK.Nam, TK.Thang, TK.TongLuong,TK.TongGiaNL,TK.TongDoanhThu, (TK.TongDoanhThu-TK.TongGiaNL-TK.TongLuong) AS LoiNhuan
FROM dbo.THONGKE_T TK
WHERE TK.Nam = @nam
