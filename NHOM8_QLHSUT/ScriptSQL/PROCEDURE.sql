﻿use QLHOSOUNGTUYEN
go

DROP FUNCTION IF EXISTS f_AutoMaTTDT
GO
CREATE FUNCTION dbo.f_AutoMaTTDT()
RETURNS CHAR(6)
AS
BEGIN
    DECLARE @numrows INT;
    DECLARE @result CHAR(6);
    SELECT @numrows = COUNT(*) FROM THONGTINDANGTUYEN;
    SET @result = 'DT' + RIGHT('0000' + CAST(@numrows AS VARCHAR(6)), 4);
    RETURN @result;
END;
GO

SELECT dbo.f_AutoMaTTDT()


SELECT dbo.f_AutoMaTTDT() AS AutoGeneratedCode;


DROP PROCEDURE IF EXISTS SP_THEM_TTDANGTUYEN
GO
CREATE PROCEDURE SP_THEM_TTDANGTUYEN
	@TTYeuCau NVARCHAR(100),
	@NgayBatDau DATE,
	@NgayKetThuc DATE,
	@SoLuongTuyenDung INT,
	@ViTriTuyenDung NVARCHAR(50),
	@HinhThucDangTuyen NVARCHAR(50),
	@MaDN VARCHAR(6),
	@GiaTien VARCHAR(6)
AS
BEGIN
		DECLARE @MaDT VARCHAR(6);
		SET @MaDT = dbo.f_AutoMaTTDT();
		INSERT INTO THONGTINDANGTUYEN(MaDT, ThongTinYeuCau, NgayBatDau, NgayKetThuc, SLTuyenDung, ViTriTuyenDung, HinhThucDangTuyen, MaDN, GiaTien)
		VALUES(@MaDT, @TTYeuCau, @NgayBatDau, @NgayKetThuc, @SoLuongTuyenDung, @ViTriTuyenDung, @HinhThucDangTuyen, @MaDN, @GiaTien);
END 
GO


DROP PROCEDURE IF EXISTS GET_MATKHAU_NHANVIEN
GO
CREATE PROCEDURE GET_MATKHAU_NHANVIEN
	@USERNAME VARCHAR(6)
AS
BEGIN
	SELECT MatKhau FROM NHANVIEN
	WHERE MaNV = @USERNAME
END
GO


EXEC GET_MATKHAU_NHANVIEN @USERNAME = 'NV0001'
GO
