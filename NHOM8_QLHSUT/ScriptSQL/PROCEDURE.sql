﻿


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
	@MaDN VARCHAR(6)
AS
BEGIN
		DECLARE @MaDT VARCHAR(6);
		SET @MaDT = dbo.f_AutoMaTTDT();
		INSERT INTO THONGTINDANGTUYEN(MaDT, ThongTinYeuCau, NgayBatDau, NgayKetThuc, SLTuyenDung, ViTriTuyenDung, HinhThucDangTuyen, MaDN)
		VALUES(@MaDT, @TTYeuCau, @NgayBatDau, @NgayKetThuc, @SoLuongTuyenDung, @ViTriTuyenDung, @HinhThucDangTuyen, @MaDN);
END 
GO

SELECT * FROM THANHVIEN

EXEC SP_THEM_TTDANGTUYEN 
    @TTYeuCau = N'Trình độ chuyên môn cao, kỹ năng lập trình tốt', 
    @NgayBatDau = '2024-07-01', 
    @NgayKetThuc = '2024-07-31', 
    @SoLuongTuyenDung = 5, 
    @ViTriTuyenDung = N'Lập trình viên', 
    @HinhThucDangTuyen = N'Toàn thời gian', 
    @MaDN = 'DN0001';

SELECT * FROM THONGTINDANGTUYEN

DELETE FROM THONGTINDANGTUYEN WHERE MADT = 'DT0018'


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

ALTER TABLE NHANVIEN
ADD MATKHAU VARCHAR(40)

SELECT * FROM NHANVIEN

SELECT * FROM THONGTINDANGTUYEN