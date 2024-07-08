USE QLHOSOUNGTUYEN
GO

-- Delete data from the table 'dbo.UNGTUYEN'
--
TRUNCATE TABLE dbo.UNGTUYEN
GO
--
-- Delete data from the table 'dbo.THONGTINCHIENLUOC'
--
TRUNCATE TABLE dbo.THONGTINCHIENLUOC
GO
--
-- Delete data from the table 'dbo.HOADONTHANHTOAN'
--
TRUNCATE TABLE dbo.HOADONTHANHTOAN
GO
--
-- Delete data from the table 'dbo.THONGTINDANGTUYEN'
--
DELETE dbo.THONGTINDANGTUYEN
GO
--
-- Delete data from the table 'dbo.UNGVIEN'
--
DELETE dbo.UNGVIEN
GO
--
-- Delete data from the table 'dbo.THANHVIEN'
--
DELETE dbo.THANHVIEN
GO
--
-- Delete data from the table 'dbo.NHANVIEN'
--
DELETE dbo.NHANVIEN
GO
--
-- Delete data from the table 'dbo.CHIENLUOCUUDAI'
--
DELETE dbo.CHIENLUOCUUDAI
GO

--
-- Inserting data into table dbo.CHIENLUOCUUDAI
--
INSERT dbo.CHIENLUOCUUDAI(MaCL, NgayBatDau, NgayKetThuc, DieuKien, MoTa, GiaTriUuDai) VALUES (N'CL0000', '2024-08-01', '2024-09-28', N'Doanh nghiệp có >= 2 người ứng tuyển', N'Khuyến khích cho các doanh nghiệp có thể tìm được nhiều nhân lực', 40)
INSERT dbo.CHIENLUOCUUDAI(MaCL, NgayBatDau, NgayKetThuc, DieuKien, MoTa, GiaTriUuDai) VALUES (N'CL0001', '2024-07-07', '2024-09-14', N'Doanh nghiệp có >= 4 người ứng tuyển có hồ sơ đạt', N'Khuyến khích cho các doanh nghiệp tìm kiếm được nhiều nhân lực chất lượng', 75)
GO

--
-- Inserting data into table dbo.NHANVIEN
--
INSERT dbo.NHANVIEN(MaNV, HoTen, ChucVu, NgaySinh, DiaChi, SoDienThoai, MatKhau) VALUES (N'NV0000', N'Lê Thanh Dương', N'Giám đốc', '1974-08-25', N'Huế', '0170500864', '1')
INSERT dbo.NHANVIEN(MaNV, HoTen, ChucVu, NgaySinh, DiaChi, SoDienThoai, MatKhau) VALUES (N'NV0001', N'Hồ Đình Hiển', N'Phó giám đốc', '1985-10-15', N'Cà Mau', '0674833067', '1')
INSERT dbo.NHANVIEN(MaNV, HoTen, ChucVu, NgaySinh, DiaChi, SoDienThoai, MatKhau) VALUES (N'NV0002', N'Lê Đức Huy', N'Nhân viên', '1998-11-05', N'Cà Mau', '0152697354', '1')
INSERT dbo.NHANVIEN(MaNV, HoTen, ChucVu, NgaySinh, DiaChi, SoDienThoai, MatKhau) VALUES (N'NV0003', N'Bùi Đức Thành', N'Nhân viên', '1989-03-28', N'Hà Nội', '0278846885', '1')
INSERT dbo.NHANVIEN(MaNV, HoTen, ChucVu, NgaySinh, DiaChi, SoDienThoai, MatKhau) VALUES (N'NV0004', N'Lê Duy Minh', N'Nhân viên', '1980-10-01', N'Hồ Chí Minh', '0012688340', '1')
INSERT dbo.NHANVIEN(MaNV, HoTen, ChucVu, NgaySinh, DiaChi, SoDienThoai, MatKhau) VALUES (N'NV0005', N'Võ Thanh Quang', N'Nhân viên', '1992-04-15', N'Hà Nội', '0489616097', '1')
INSERT dbo.NHANVIEN(MaNV, HoTen, ChucVu, NgaySinh, DiaChi, SoDienThoai, MatKhau) VALUES (N'NV0006', N'Trương Thanh Nghĩa', N'Nhân viên', '1982-09-28', N'Cà Mau', '0637303852', '1')
INSERT dbo.NHANVIEN(MaNV, HoTen, ChucVu, NgaySinh, DiaChi, SoDienThoai, MatKhau) VALUES (N'NV0007', N'Mai Chí Quân', N'Nhân viên', '1989-03-29', N'Hồ Chí Minh', '0518126641', '1')
INSERT dbo.NHANVIEN(MaNV, HoTen, ChucVu, NgaySinh, DiaChi, SoDienThoai, MatKhau) VALUES (N'NV0008', N'Lê Đình Minh', N'Nhân viên', '1985-10-16', N'Bình Dương', '0892341830', '1')
INSERT dbo.NHANVIEN(MaNV, HoTen, ChucVu, NgaySinh, DiaChi, SoDienThoai, MatKhau) VALUES (N'NV0009', N'Võ Duy Hiển', N'Nhân viên', '1992-04-16', N'Huế', '0513537774', '1')
INSERT dbo.NHANVIEN(MaNV, HoTen, ChucVu, NgaySinh, DiaChi, SoDienThoai, MatKhau) VALUES (N'NV0010', N'Hồ Văn Đoan', N'Nhân viên', '1971-08-08', N'Bình Phước', '0687428935', '1')
INSERT dbo.NHANVIEN(MaNV, HoTen, ChucVu, NgaySinh, DiaChi, SoDienThoai, MatKhau) VALUES (N'NV0011', N'Lê Thị Minh', N'Nhân viên', '1995-10-22', N'Bình Dương', '0921171287', '1')
INSERT dbo.NHANVIEN(MaNV, HoTen, ChucVu, NgaySinh, DiaChi, SoDienThoai, MatKhau) VALUES (N'NV0012', N'Trương Chí Quân', N'Nhân viên', '1977-09-14', N'Hà Nội', '0960949412', '1')
INSERT dbo.NHANVIEN(MaNV, HoTen, ChucVu, NgaySinh, DiaChi, SoDienThoai, MatKhau) VALUES (N'NV0013', N'Võ Đình Dương', N'Nhân viên', '1989-03-30', N'Cà Mau', '0457172248', '1')
INSERT dbo.NHANVIEN(MaNV, HoTen, ChucVu, NgaySinh, DiaChi, SoDienThoai, MatKhau) VALUES (N'NV0014', N'Hồ Thanh Đoan', N'Nhân viên', '1980-10-02', N'Bình Dương', '0064226778', '1')
GO

--
-- Inserting data into table dbo.THANHVIEN
--
INSERT dbo.THANHVIEN(MaDN, TenCongTy, Email, NguoiDaiDien, MaSoThue, MaNV) VALUES (N'DN0000', N'Future S-Mobile Corp.', 'FutureS-MobileCorp@gmail.com', N'Neolie Heine', '5794487850', 'NV0000')
INSERT dbo.THANHVIEN(MaDN, TenCongTy, Email, NguoiDaiDien, MaSoThue, MaNV) VALUES (N'DN0001', N'Western High-Technologies Corporation', 'WesternHighTechnologiesCorporation@gmail.com', N'Adelisa  Anger', '5231854009', 'NV0001')
INSERT dbo.THANHVIEN(MaDN, TenCongTy, Email, NguoiDaiDien, MaSoThue, MaNV) VALUES (N'DN0002', N'South Business Corporation', 'SouthBusinessCorporation@gmail.com', N'Kaira Wentzel', '9988634798', 'NV0002')
INSERT dbo.THANHVIEN(MaDN, TenCongTy, Email, NguoiDaiDien, MaSoThue, MaNV) VALUES (N'DN0003', N'First 2G Wireless Corp.', 'First2GWirelessCorp@gmail.com', N'Clarinda Fetting', '1948160643', 'NV0003')
INSERT dbo.THANHVIEN(MaDN, TenCongTy, Email, NguoiDaiDien, MaSoThue, MaNV) VALUES (N'DN0004', N'First Computers Corporation', 'FirstComputersCorporation@gmail.com', N'Piana Drews', '5322083151', 'NV0004')
INSERT dbo.THANHVIEN(MaDN, TenCongTy, Email, NguoiDaiDien, MaSoThue, MaNV) VALUES (N'DN0005', N'National Wave Energy Co.', 'NationalWaveEnergyCo@gmail.com', N'Pamira Lichtenstein', '9559198490', 'NV0005')
INSERT dbo.THANHVIEN(MaDN, TenCongTy, Email, NguoiDaiDien, MaSoThue, MaNV) VALUES (N'DN0006', N'South Development Co.', 'SouthDevelopmentCo@gmail.com', N'Clementia Ittenbach', '3791447718', 'NV0006')
INSERT dbo.THANHVIEN(MaDN, TenCongTy, Email, NguoiDaiDien, MaSoThue, MaNV) VALUES (N'DN0007', N'Future Nuclear Energy Co.', 'FutureNuclearEnergyCo@gmail.com', N'Serafine Albrecht', '7606516847', 'NV0007')
INSERT dbo.THANHVIEN(MaDN, TenCongTy, Email, NguoiDaiDien, MaSoThue, MaNV) VALUES (N'DN0008', N'Global High-Technologies Group', 'GlobalHigh-TechnologiesGroup@gmail.com', N'Emiliea Felder', '0687912964', 'NV0008')
INSERT dbo.THANHVIEN(MaDN, TenCongTy, Email, NguoiDaiDien, MaSoThue, MaNV) VALUES (N'DN0009', N'Canadian Computers Inc.', 'CanadianComputersInc@gmail.com', N'Azalee Feuerbach', '3058046926', 'NV0009')
INSERT dbo.THANHVIEN(MaDN, TenCongTy, Email, NguoiDaiDien, MaSoThue, MaNV) VALUES (N'DN0010', N'Australian Fossil Fuel Resources Corporation', 'AustralianFossilFuelResourcesCorporation@gmail.com', N'Christel Neuner', '0443622144', 'NV0010')
INSERT dbo.THANHVIEN(MaDN, TenCongTy, Email, NguoiDaiDien, MaSoThue, MaNV) VALUES (N'DN0011', N'Flexible Space Research Co.', 'FlexibleSpaceResearchCo@gmail.com', N'Bernharde Blücher', '7338912660', 'NV0011')
INSERT dbo.THANHVIEN(MaDN, TenCongTy, Email, NguoiDaiDien, MaSoThue, MaNV) VALUES (N'DN0012', N'National W-Mobile Group', 'NationalWMobileGroup@gmail.com', N'Romi Liebknecht', '1466106422', 'NV0012')
INSERT dbo.THANHVIEN(MaDN, TenCongTy, Email, NguoiDaiDien, MaSoThue, MaNV) VALUES (N'DN0013', N'Special Space Explore Corporation', 'SpecialSpaceExploreCorporation@gmail.com', N'Jakobine Kade', '2646202926', 'NV0013')
INSERT dbo.THANHVIEN(MaDN, TenCongTy, Email, NguoiDaiDien, MaSoThue, MaNV) VALUES (N'DN0014', N'American 4G Wireless Inc.', 'American4GWirelessInc@gmail.com', N'Philine Abert', '3427532504', 'NV0014')
GO

--
-- Inserting data into table dbo.UNGVIEN
--
INSERT dbo.UNGVIEN(MaUV, HoTen, NgaySinh, DiaChi, SoDienThoai, MaNV) VALUES (N'UV0000', N'Võ Đình Đoan', '1978-12-18', N'Hồ Chí Minh', '0318355736', 'NV0000')
INSERT dbo.UNGVIEN(MaUV, HoTen, NgaySinh, DiaChi, SoDienThoai, MaNV) VALUES (N'UV0001', N'Trương Đình Nghĩa', '1984-10-25', N'Cà Mau', '0559021422', 'NV0001')
INSERT dbo.UNGVIEN(MaUV, HoTen, NgaySinh, DiaChi, SoDienThoai, MaNV) VALUES (N'UV0002', N'Nguyễn Duy Châu', '1973-09-20', N'Huế', '0635039504', 'NV0002')
INSERT dbo.UNGVIEN(MaUV, HoTen, NgaySinh, DiaChi, SoDienThoai, MaNV) VALUES (N'UV0003', N'Võ Trọng Anh', '1971-09-03', N'Đồng Nai', '0479625028', 'NV0003')
INSERT dbo.UNGVIEN(MaUV, HoTen, NgaySinh, DiaChi, SoDienThoai, MaNV) VALUES (N'UV0004', N'Đặng Đình Nghĩa', '1981-01-05', N'Cà Mau', '0594863311', 'NV0004')
INSERT dbo.UNGVIEN(MaUV, HoTen, NgaySinh, DiaChi, SoDienThoai, MaNV) VALUES (N'UV0005', N'Võ Duy Dương', '1990-06-20', N'Cà Mau', '0401536908', 'NV0005')
INSERT dbo.UNGVIEN(MaUV, HoTen, NgaySinh, DiaChi, SoDienThoai, MaNV) VALUES (N'UV0006', N'Nguyễn Văn Nghĩa', '1978-12-19', N'Hồ Chí Minh', '0288290942', 'NV0006')
INSERT dbo.UNGVIEN(MaUV, HoTen, NgaySinh, DiaChi, SoDienThoai, MaNV) VALUES (N'UV0007', N'Đặng Thị Quân', '1981-01-06', N'Hồ Chí Minh', '0119134405', 'NV0007')
INSERT dbo.UNGVIEN(MaUV, HoTen, NgaySinh, DiaChi, SoDienThoai, MaNV) VALUES (N'UV0008', N'Võ Trọng Thi', '1978-12-20', N'Bình Phước', '0902686643', 'NV0008')
INSERT dbo.UNGVIEN(MaUV, HoTen, NgaySinh, DiaChi, SoDienThoai, MaNV) VALUES (N'UV0009', N'Lê Thị Minh', '1973-09-21', N'Hồ Chí Minh', '0716834947', 'NV0009')
INSERT dbo.UNGVIEN(MaUV, HoTen, NgaySinh, DiaChi, SoDienThoai, MaNV) VALUES (N'UV0010', N'Lê Đình Hiển', '1982-10-08', N'Hà Nội', '0506971938', 'NV0010')
INSERT dbo.UNGVIEN(MaUV, HoTen, NgaySinh, DiaChi, SoDienThoai, MaNV) VALUES (N'UV0011', N'Hồ Thanh Châu', '1971-09-04', N'Hồ Chí Minh', '0304844104', 'NV0011')
INSERT dbo.UNGVIEN(MaUV, HoTen, NgaySinh, DiaChi, SoDienThoai, MaNV) VALUES (N'UV0012', N'Mai Thị Hiển', '1984-10-26', N'Huế', '0383363500', 'NV0012')
INSERT dbo.UNGVIEN(MaUV, HoTen, NgaySinh, DiaChi, SoDienThoai, MaNV) VALUES (N'UV0013', N'Đặng Thị Tài', '1981-01-07', N'Huế', '0817028691', 'NV0013')
INSERT dbo.UNGVIEN(MaUV, HoTen, NgaySinh, DiaChi, SoDienThoai, MaNV) VALUES (N'UV0014', N'Võ Thị Đại', '1986-10-21', N'Đồng Nai', '0441526006', 'NV0014')
GO

--
-- Inserting data into table dbo.THONGTINDANGTUYEN
--
INSERT dbo.THONGTINDANGTUYEN(MaDT, ThongTinYeuCau, NgayBatDau, NgayKetThuc, SLTuyenDung, ViTriTuyenDung, HinhThucDangTuyen, MaDN, TinhTrang, GiaTien) VALUES (N'DT0000', N'Yêu cầu:Có kinh nghiệm 3-4 năm.Bằng Ngoại Ngữ Tiếng Nhật, Tiếng Anh, Đại Học. Hồ sơ: Đơn xin việc, C', '2024-05-01', '2024-06-01', 10, N'Executive', N'Đăng banner quảng cáo', 'DN0000', N'Chưa được đăng', 500000)
INSERT dbo.THONGTINDANGTUYEN(MaDT, ThongTinYeuCau, NgayBatDau, NgayKetThuc, SLTuyenDung, ViTriTuyenDung, HinhThucDangTuyen, MaDN, TinhTrang, GiaTien) VALUES (N'DT0001', N'Yêu cầu:Có kinh nghiệm 1-2 năm.Bằng Ngoại Ngữ Tiếng Anh, Đại Học. Hồ sơ: Đơn xin việc, CV, Bản sao c', '2024-05-02', '2024-06-02', 11, N'Finance', N'Đăng tuyển trên báo giấy', 'DN0001', N'Chưa được đăng', 100000)
INSERT dbo.THONGTINDANGTUYEN(MaDT, ThongTinYeuCau, NgayBatDau, NgayKetThuc, SLTuyenDung, ViTriTuyenDung, HinhThucDangTuyen, MaDN, TinhTrang, GiaTien) VALUES (N'DT0002', N'Yêu cầu:Đủ tuổi lao động. Bằng Ngoại Ngữ Tiếng Anh. Hồ sơ: Đơn xin việc, CV, Bản sao các Bằng cấp, B', '2024-05-03', '2024-06-03', 12, N'Manufacturing', N'Đăng banner quảng cáo', 'DN0002', N'Chưa được đăng', 150000)
INSERT dbo.THONGTINDANGTUYEN(MaDT, ThongTinYeuCau, NgayBatDau, NgayKetThuc, SLTuyenDung, ViTriTuyenDung, HinhThucDangTuyen, MaDN, TinhTrang, GiaTien) VALUES (N'DT0003', N'Yêu cầu:Có kinh nghiệm 3-4 năm.Bằng Ngoại Ngữ Tiếng Nhật, Tiếng Anh, Đại Học. Hồ sơ: Đơn xin việc, C', '2024-05-04', '2024-06-04', 13, N'Sales', N'Đăng tuyển trên báo giấy', 'DN0003', N'Chưa được đăng', 200000)
INSERT dbo.THONGTINDANGTUYEN(MaDT, ThongTinYeuCau, NgayBatDau, NgayKetThuc, SLTuyenDung, ViTriTuyenDung, HinhThucDangTuyen, MaDN, TinhTrang, GiaTien) VALUES (N'DT0004', N'Yêu cầu:Có kinh nghiệm 1-2 năm.Bằng Ngoại Ngữ Tiếng Anh, Đại Học. Hồ sơ: Đơn xin việc, CV, Bản sao c', '2024-05-05', '2024-06-05', 14, N'Human Resources', N'Đăng trên các trang mạng', 'DN0004', N'Chưa được đăng', 300000)
INSERT dbo.THONGTINDANGTUYEN(MaDT, ThongTinYeuCau, NgayBatDau, NgayKetThuc, SLTuyenDung, ViTriTuyenDung, HinhThucDangTuyen, MaDN, TinhTrang, GiaTien) VALUES (N'DT0005', N'Yêu cầu:Đủ tuổi lao động. Bằng Ngoại Ngữ Tiếng Anh. Hồ sơ: Đơn xin việc, CV, Bản sao các Bằng cấp, B', '2024-05-06', '2024-06-06', 15, N'Customer Support', N'Đăng tuyển trên báo giấy', 'DN0005', N'Chưa được đăng', 100000)
INSERT dbo.THONGTINDANGTUYEN(MaDT, ThongTinYeuCau, NgayBatDau, NgayKetThuc, SLTuyenDung, ViTriTuyenDung, HinhThucDangTuyen, MaDN, TinhTrang, GiaTien) VALUES (N'DT0006', N'Yêu cầu:Có kinh nghiệm 3-4 năm.Bằng Ngoại Ngữ Tiếng Nhật, Tiếng Anh, Đại Học. Hồ sơ: Đơn xin việc, C', '2024-05-07', '2024-06-07', 16, N'Consulting', N'Đăng trên các trang mạng', 'DN0006', N'Chưa được đăng', 50000)
INSERT dbo.THONGTINDANGTUYEN(MaDT, ThongTinYeuCau, NgayBatDau, NgayKetThuc, SLTuyenDung, ViTriTuyenDung, HinhThucDangTuyen, MaDN, TinhTrang, GiaTien) VALUES (N'DT0007', N'Yêu cầu:Có kinh nghiệm 3-4 năm.Bằng Ngoại Ngữ Tiếng Nhật, Tiếng Anh, Đại Học. Hồ sơ: Đơn xin việc, C', '2024-05-08', '2024-06-08', 17, N'Research and Development', N'Đăng trên các trang mạng', 'DN0007', N'Chưa được đăng', 40000)
INSERT dbo.THONGTINDANGTUYEN(MaDT, ThongTinYeuCau, NgayBatDau, NgayKetThuc, SLTuyenDung, ViTriTuyenDung, HinhThucDangTuyen, MaDN, TinhTrang, GiaTien) VALUES (N'DT0008', N'Yêu cầu:Có kinh nghiệm 1-2 năm.Bằng Ngoại Ngữ Tiếng Anh, Đại Học. Hồ sơ: Đơn xin việc, CV, Bản sao c', '2024-05-09', '2024-06-09', 18, N'Operations', N'Đăng trên các trang mạng', 'DN0008', N'Chưa được đăng', 100000)
INSERT dbo.THONGTINDANGTUYEN(MaDT, ThongTinYeuCau, NgayBatDau, NgayKetThuc, SLTuyenDung, ViTriTuyenDung, HinhThucDangTuyen, MaDN, TinhTrang, GiaTien) VALUES (N'DT0009', N'Yêu cầu:Có kinh nghiệm 1-2 năm.Bằng Đại Học. Hồ sơ: Đơn xin việc, CV, Bản sao các Bằng cấp, Bản sao ', '2024-05-10', '2024-06-10', 19, N'Information Technology', N'Đăng trên các trang mạng', 'DN0009', N'Chưa được đăng', 230000)
INSERT dbo.THONGTINDANGTUYEN(MaDT, ThongTinYeuCau, NgayBatDau, NgayKetThuc, SLTuyenDung, ViTriTuyenDung, HinhThucDangTuyen, MaDN, TinhTrang, GiaTien) VALUES (N'DT0010', N'Yêu cầu:Có kinh nghiệm 3-4 năm.Bằng Ngoại Ngữ Tiếng Nhật, Tiếng Anh, Đại Học. Hồ sơ: Đơn xin việc, C', '2024-05-11', '2024-06-11', 20, N'Facilities', N'Đăng trên các trang mạng', 'DN0010', N'Chưa được đăng', 200000)
GO

--
-- Inserting data into table dbo.HOADONTHANHTOAN
--
INSERT dbo.HOADONTHANHTOAN(NgayLap, SoTienCanThanhToan, SoTienDaThanhToan, SoTienConLai, DotThanhToan, MaDT, HinhThucThanhToan) VALUES ('2024-04-25', 100000, 100000, 0, 1, 'DT0000', N'Thanh toán 1 đợt')
INSERT dbo.HOADONTHANHTOAN(NgayLap, SoTienCanThanhToan, SoTienDaThanhToan, SoTienConLai, DotThanhToan, MaDT, HinhThucThanhToan) VALUES ('2024-04-26', 100000, 100000, 0, 1, 'DT0001', N'Thanh toán 1 đợt')
INSERT dbo.HOADONTHANHTOAN(NgayLap, SoTienCanThanhToan, SoTienDaThanhToan, SoTienConLai, DotThanhToan, MaDT, HinhThucThanhToan) VALUES ('2024-04-27', 300000, 90000, 210000, 1, 'DT0002', N'Thanh toán nhiều đợt')
INSERT dbo.HOADONTHANHTOAN(NgayLap, SoTienCanThanhToan, SoTienDaThanhToan, SoTienConLai, DotThanhToan, MaDT, HinhThucThanhToan) VALUES ('2024-04-28', 600000, 180000, 420000, 1, 'DT0003', N'Thanh toán nhiều đợt')
INSERT dbo.HOADONTHANHTOAN(NgayLap, SoTienCanThanhToan, SoTienDaThanhToan, SoTienConLai, DotThanhToan, MaDT, HinhThucThanhToan) VALUES ('2024-04-29', 100000, 30000, 70000, 1, 'DT0004', N'Thanh toán nhiều đợt')
INSERT dbo.HOADONTHANHTOAN(NgayLap, SoTienCanThanhToan, SoTienDaThanhToan, SoTienConLai, DotThanhToan, MaDT, HinhThucThanhToan) VALUES ('2024-04-30', 100000, 100000, 0, 1, 'DT0005', N'Thanh toán 1 đợt')
INSERT dbo.HOADONTHANHTOAN(NgayLap, SoTienCanThanhToan, SoTienDaThanhToan, SoTienConLai, DotThanhToan, MaDT, HinhThucThanhToan) VALUES ('2024-05-01', 300000, 90000, 210000, 1, 'DT0006', N'Thanh toán nhiều đợt')
INSERT dbo.HOADONTHANHTOAN(NgayLap, SoTienCanThanhToan, SoTienDaThanhToan, SoTienConLai, DotThanhToan, MaDT, HinhThucThanhToan) VALUES ('2024-04-25', 300000, 90000, 210000, 1, 'DT0007', N'Thanh toán nhiều đợt')
INSERT dbo.HOADONTHANHTOAN(NgayLap, SoTienCanThanhToan, SoTienDaThanhToan, SoTienConLai, DotThanhToan, MaDT, HinhThucThanhToan) VALUES ('2024-04-26', 100000, 100000, 0, 1, 'DT0008', N'Thanh toán 1 đợt')
INSERT dbo.HOADONTHANHTOAN(NgayLap, SoTienCanThanhToan, SoTienDaThanhToan, SoTienConLai, DotThanhToan, MaDT, HinhThucThanhToan) VALUES ('2024-04-27', 100000, 100000, 0, 1, 'DT0009', N'Thanh toán 1 đợt')
INSERT dbo.HOADONTHANHTOAN(NgayLap, SoTienCanThanhToan, SoTienDaThanhToan, SoTienConLai, DotThanhToan, MaDT, HinhThucThanhToan) VALUES ('2024-04-28', 300000, 90000, 210000, 1, 'DT0010', N'Thanh toán nhiều đợt')
GO

--
-- Inserting data into table dbo.THONGTINCHIENLUOC
--
INSERT dbo.THONGTINCHIENLUOC(MaDN, MaCL) VALUES (N'DN0002', N'CL0001')
INSERT dbo.THONGTINCHIENLUOC(MaDN, MaCL) VALUES (N'DN0002', N'CL0000')
INSERT dbo.THONGTINCHIENLUOC(MaDN, MaCL) VALUES (N'DN0001', N'CL0000')
GO

--
-- Inserting data into table dbo.UNGTUYEN
--
INSERT dbo.UNGTUYEN(MaUV, MaDT, BangCap, TinhTrang, ChungTu, HoSo) VALUES (N'UV0009', N'DT0009', N'Bằng tốt nghiệp Đại Học HCMUS, TOEIC 500', N'Đã xử lý', N'Không', N'Đơn xin việc, CV, Bản sao các Bằng cấp, Bản sao CMND/CCCD.')
INSERT dbo.UNGTUYEN(MaUV, MaDT, BangCap, TinhTrang, ChungTu, HoSo) VALUES (N'UV0001', N'DT0001', N'Bằng tốt nghiệp Đại Học HCMUS, IELT 6.0', N'Không đủ điều kiện', N'Không', N'Đơn xin việc, CV, Bản sao các Bằng cấp, Bản sao CMND/CCCD.')
INSERT dbo.UNGTUYEN(MaUV, MaDT, BangCap, TinhTrang, ChungTu, HoSo) VALUES (N'UV0004', N'DT0004', N'Bằng tốt nghiệp Đại Học HCMUS, TOEIC 500', N'Không Đạt', N'Không', N'Đơn xin việc, CV, Bản sao các Bằng cấp, Bản sao CMND/CCCD.')
INSERT dbo.UNGTUYEN(MaUV, MaDT, BangCap, TinhTrang, ChungTu, HoSo) VALUES (N'UV0000', N'DT0000', N'Bằng tốt nghiệp Đại Học FPT, TOEIC 500', N'Đủ điều kiện', N'Không', N'Đơn xin việc, CV, Bản sao các Bằng cấp, Bản sao CMND/CCCD.')
INSERT dbo.UNGTUYEN(MaUV, MaDT, BangCap, TinhTrang, ChungTu, HoSo) VALUES (N'UV0003', N'DT0003', N'Bằng tốt nghiệp Đại Học HCMUT, IELT 6.0, BJT J4', N'Đã xử lý', N'Không', N'Đơn xin việc, CV, Bản sao các Bằng cấp, Bản sao CMND/CCCD.')
INSERT dbo.UNGTUYEN(MaUV, MaDT, BangCap, TinhTrang, ChungTu, HoSo) VALUES (N'UV0002', N'DT0001', N'Bằng tốt nghiệp Đại Học FPT, TOEIC 500', N'Đủ điều kiện', N'Không', N'Đơn xin việc, CV, Bản sao các Bằng cấp, Bản sao CMND/CCCD.')
INSERT dbo.UNGTUYEN(MaUV, MaDT, BangCap, TinhTrang, ChungTu, HoSo) VALUES (N'UV0001', N'DT0002', N'Bằng tốt nghiệp Đại Học HCMUT, IELT 6.0, BJT J4', N'Đã xử lý', N'Không', N'Đơn xin việc, CV, Bản sao các Bằng cấp, Bản sao CMND/CCCD.')
INSERT dbo.UNGTUYEN(MaUV, MaDT, BangCap, TinhTrang, ChungTu, HoSo) VALUES (N'UV0010', N'DT0010', N'Bằng tốt nghiệp Đại Học HCMUS, TOEIC 500', N'Đủ điều kiện', N'Không', N'Đơn xin việc, CV, Bản sao các Bằng cấp, Bản sao CMND/CCCD.')
INSERT dbo.UNGTUYEN(MaUV, MaDT, BangCap, TinhTrang, ChungTu, HoSo) VALUES (N'UV0005', N'DT0002', N'Bằng tốt nghiệp Đại Học FPT, TOEIC 500', N'Đạt', N'Không', N'Đơn xin việc, CV, Bản sao các Bằng cấp, Bản sao CMND/CCCD.')
INSERT dbo.UNGTUYEN(MaUV, MaDT, BangCap, TinhTrang, ChungTu, HoSo) VALUES (N'UV0004', N'DT0002', N'Bằng tốt nghiệp Đại Học FPT, TOEIC 500', N'Đạt', N'Không', N'Đơn xin việc, CV, Bản sao các Bằng cấp, Bản sao CMND/CCCD.')
INSERT dbo.UNGTUYEN(MaUV, MaDT, BangCap, TinhTrang, ChungTu, HoSo) VALUES (N'UV0002', N'DT0002', N'Bằng tốt nghiệp Đại Học FPT, TOEIC 500', N'Đạt', N'Không', N'Đơn xin việc, CV, Bản sao các Bằng cấp, Bản sao CMND/CCCD.')
INSERT dbo.UNGTUYEN(MaUV, MaDT, BangCap, TinhTrang, ChungTu, HoSo) VALUES (N'UV0003', N'DT0002', N'Bằng tốt nghiệp Đại Học HCMUS, IELT 6.0', N'Đạt', N'Không', N'Đơn xin việc, CV, Bản sao các Bằng cấp, Bản sao CMND/CCCD.')
INSERT dbo.UNGTUYEN(MaUV, MaDT, BangCap, TinhTrang, ChungTu, HoSo) VALUES (N'UV0006', N'DT0006', N'Bằng tốt nghiệp Đại Học HCMUS, IELT 6.0', N'Không Đạt', N'Không', N'Đơn xin việc, CV, Bản sao các Bằng cấp, Bản sao CMND/CCCD.')
INSERT dbo.UNGTUYEN(MaUV, MaDT, BangCap, TinhTrang, ChungTu, HoSo) VALUES (N'UV0008', N'DT0008', N'Bằng tốt nghiệp Đại Học FPT, IELT 6.5, BJT J4', N'Không Đạt', N'Không', N'Đơn xin việc, CV, Bản sao các Bằng cấp, Bản sao CMND/CCCD.')
INSERT dbo.UNGTUYEN(MaUV, MaDT, BangCap, TinhTrang, ChungTu, HoSo) VALUES (N'UV0007', N'DT0007', N'Bằng tốt nghiệp Đại Học FPT, TOEIC 500', N'Không Đạt', N'Không', N'Đơn xin việc, CV, Bản sao các Bằng cấp, Bản sao CMND/CCCD.')
