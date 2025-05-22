CREATE DATABASE ManageLibrary4;
GO
USE ManageLibrary4;
GO

-- Create a login
CREATE LOGIN [22110178@hcmute.edu.vn.com] WITH PASSWORD = 'leloc123';

USE ManageLibrary4;
GO
-- Create a user for the login
CREATE USER [22110178@hcmute.edu.vn.com] FOR LOGIN [22110178@hcmute.edu.vn.com];

USE ManageLibrary4;
GO

CREATE ROLE ThuThu;
CREATE ROLE DocGia;
CREATE ROLE QuanTriVien;

USE ManageLibrary4;
GO
GRANT SELECT ON VW_Book_List TO DocGia;  
GRANT SELECT ON VW_TacGia_List TO DocGia; 
GRANT SELECT ON VW_NhaXuatBan_List TO DocGia;
GRANT SELECT ON VW_TheLoai_List TO DocGia;
GRANT EXECUTE ON SP_TimKiemSachTheoTenSach TO DocGia;
GRANT EXECUTE ON SP_TimKiemSachTheoTheLoai TO DocGia;
GRANT EXECUTE ON SP_TimKiemSachTheoMaNhaXuatBan1 TO DocGia;
GRANT EXECUTE ON SP_TimKiemSachTheoMaTacGia TO DocGia;
GRANT EXECUTE ON SP_GetLichSuMuonSachByMaTaiKhoan TO DocGia;
GRANT EXECUTE ON SP_Reader_MuonSach TO DocGia;
GRANT EXECUTE ON SP_TimKiemSachTheoMaNhaXuatBan1 TO DocGia;
GRANT EXECUTE ON SP_Get_Account_Profile TO DocGia;
GRANT EXECUTE ON SP_Account_Profile TO DocGia;
GRANT EXECUTE ON SP_Change_Account_Password TO DocGia;

USE ManageLibrary4;
GO

---cap quyen cho thủ thư
GRANT SELECT ON VW_AllPhieuMuonSach TO ThuThu;
GRANT EXECUTE ON SP_Get_Account_Profile TO ThuThu;
GRANT EXECUTE ON SP_Change_Account_Password TO ThuThu;
GRANT EXECUTE ON SP_Find_Account_By_Advanced TO ThuThu;
GRANT EXECUTE ON SP_Account_Profile TO ThuThu;
GRANT EXECUTE ON SP_Add_New_Book TO ThuThu;
GRANT EXECUTE ON SP_Update_Book TO ThuThu;
GRANT EXECUTE ON SP_Find_Book_By_Advanced TO ThuThu;
GRANT EXECUTE ON SP_Delete_Book TO ThuThu;
GRANT EXECUTE ON SP_Add_Tac_Gia TO ThuThu;
GRANT EXECUTE ON SP_Update_Tac_Gia TO ThuThu;
GRANT EXECUTE ON SP_Find_TacGia TO ThuThu;
GRANT EXECUTE ON SP_Delete_TacGia TO ThuThu;
GRANT EXECUTE ON SP_Add_New_TheLoai TO ThuThu;
GRANT EXECUTE ON SP_Delete_TheLoai TO ThuThu;
GRANT EXECUTE ON SP_Update_TheLoai TO ThuThu;
GRANT EXECUTE ON SP_Find_TheLoai TO ThuThu;
GRANT EXECUTE ON SP_Add_New_NXB TO ThuThu;
GRANT EXECUTE ON SP_Update_NXB TO ThuThu;
GRANT EXECUTE ON SP_Find_NXB TO ThuThu;
GRANT EXECUTE ON SP_Delete_NXB TO ThuThu;
GRANT EXECUTE ON SP_GetPhieuMuonSachByMaTaiKhoan TO ThuThu;
GRANT EXECUTE ON SP_GetPhieuMuonSachByTinhTrang TO ThuThu;
GRANT EXECUTE ON SP_UpdateTraSach TO ThuThu;
GRANT SELECT ON FN_Total_Available_Books TO ThuThu;
GRANT SELECT ON FN_Total_Borrowed_Books TO ThuThu;
GRANT SELECT ON FN_Total_Books TO ThuThu;
GRANT SELECT ON FN_Total_Authors TO ThuThu;
GRANT SELECT ON FN_Total_Publishers TO ThuThu;
GRANT SELECT ON FN_Total_Categories TO ThuThu;
GRANT SELECT ON FN_Total_Accounts TO ThuThu;
GRANT SELECT ON FN_Total_High_Quality_Student_Accounts TO ThuThu;
GRANT SELECT ON dbo.FN_Total_Librarian_Accounts TO ThuThu;
GRANT SELECT ON FN_Total_Graduate_Student_Accounts TO ThuThu;
GRANT SELECT ON FN_Total_Lecturer_Accounts TO ThuThu;
GRANT SELECT ON FN_Total_Librarian_Accounts TO ThuThu;
GRANT SELECT ON FN_Total_Administrator_Accounts TO ThuThu;
GRANT SELECT ON VW_Account_List TO ThuThu;
GRANT SELECT ON VW_Book_List TO ThuThu;
GRANT SELECT ON VW_NhaXuatBan_List TO ThuThu;
GRANT SELECT ON VW_TheLoai_List TO ThuThu;
GRANT SELECT ON VW_TacGia_List TO ThuThu;
GRANT SELECT ON VW_GetAllMaTaiKhoan TO ThuThu;
GRANT SELECT ON FN_Total_Damaged_Or_Lost_Books TO ThuThu;
GRANT SELECT ON FN_Total_Mass_Student_Accounts TO Thuthu;
GRANT SELECT ON VW_Schedule_List TO ThuThu;
GRANT SELECT ON VW_Librarian_List TO ThuThu;
GRANT EXECUTE ON SP_Get_Schedule TO ThuThu;

GO

-- Admin
GRANT SELECT ON VW_AllPhieuMuonSach TO QuanTriVien;
GRANT EXECUTE ON SP_Get_Account_Profile TO QuanTriVien;
GRANT EXECUTE ON SP_Change_Account_Password TO QuanTriVien;
GRANT EXECUTE ON SP_Account_Profile TO QuanTriVien;
GRANT EXECUTE ON SP_Add_New_Account TO QuanTriVien;
GRANT EXECUTE ON SP_Delete_Account TO QuanTriVien;
GRANT EXECUTE ON SP_Update_Account TO QuanTriVien;
GRANT EXECUTE ON SP_Find_Account_By_Advanced TO QuanTriVien;
GRANT EXECUTE ON SP_Add_New_Book TO QuanTriVien;
GRANT EXECUTE ON SP_Update_Book TO QuanTriVien;
GRANT EXECUTE ON SP_Find_Book_By_Advanced TO QuanTriVien;
GRANT EXECUTE ON SP_Delete_Book TO QuanTriVien;
GRANT EXECUTE ON SP_Add_Tac_Gia TO QuanTriVien;
GRANT EXECUTE ON SP_Update_Tac_Gia TO QuanTriVien;
GRANT EXECUTE ON SP_Find_TacGia TO QuanTriVien;
GRANT EXECUTE ON SP_Delete_TacGia TO QuanTriVien;
GRANT EXECUTE ON SP_Add_New_TheLoai TO QuanTriVien;
GRANT EXECUTE ON SP_Delete_TheLoai TO QuanTriVien;
GRANT EXECUTE ON SP_Update_TheLoai TO QuanTriVien;
GRANT EXECUTE ON SP_Find_TheLoai TO QuanTriVien;
GRANT EXECUTE ON SP_Add_New_NXB TO QuanTriVien;
GRANT EXECUTE ON SP_Update_NXB TO QuanTriVien;
GRANT EXECUTE ON SP_Find_NXB TO QuanTriVien;
GRANT EXECUTE ON SP_Delete_NXB TO QuanTriVien;
GRANT EXECUTE ON SP_GetPhieuMuonSachByMaTaiKhoan TO QuanTriVien;
GRANT EXECUTE ON SP_GetPhieuMuonSachByTinhTrang TO QuanTriVien;
GRANT EXECUTE ON SP_UpdateTraSach TO QuanTriVien;
GRANT SELECT ON FN_Total_Available_Books TO QuanTriVien;
GRANT SELECT ON FN_Total_Borrowed_Books TO QuanTriVien;
GRANT SELECT ON FN_Total_Books TO QuanTriVien;
GRANT SELECT ON FN_Total_Authors TO QuanTriVien;
GRANT SELECT ON FN_Total_Publishers TO QuanTriVien;
GRANT SELECT ON FN_Total_Categories TO QuanTriVien;
GRANT SELECT ON FN_Total_Accounts TO QuanTriVien;
GRANT SELECT ON FN_Total_High_Quality_Student_Accounts TO QuanTriVien;
GRANT SELECT ON dbo.FN_Total_Librarian_Accounts TO QuanTriVien;
GRANT SELECT ON FN_Total_Graduate_Student_Accounts TO QuanTriVien;
GRANT SELECT ON FN_Total_Lecturer_Accounts TO QuanTriVien;
GRANT SELECT ON FN_Total_Librarian_Accounts TO QuanTriVien;
GRANT SELECT ON FN_Total_Administrator_Accounts TO QuanTriVien;
GRANT SELECT ON VW_Account_List TO QuanTriVien;
GRANT SELECT ON VW_Book_List TO QuanTriVien;
GRANT SELECT ON VW_NhaXuatBan_List TO QuanTriVien;
GRANT SELECT ON VW_TheLoai_List TO QuanTriVien;
GRANT SELECT ON VW_TacGia_List TO QuanTriVien;
GRANT SELECT ON VW_GetAllMaTaiKhoan TO QuanTriVien;
GRANT SELECT ON FN_Total_Damaged_Or_Lost_Books TO QuanTriVien;
GRANT SELECT ON FN_Total_Mass_Student_Accounts TO QuanTriVien;
GRANT SELECT ON VW_Schedule_List TO QuanTriVien;
GRANT SELECT ON VW_Librarian_List TO QuanTriVien;
GRANT EXECUTE ON SP_Get_Schedule TO QuanTriVien;
GRANT EXECUTE ON SP_Add_New_Schedule TO QuanTriVien;
GRANT EXECUTE ON SP_Update_Schedule TO QuanTriVien;
GRANT EXECUTE ON SP_Delete_Schedule TO QuanTriVien;

GO

-- Tạo bảng
CREATE TABLE TaiKhoan (
	MaTaiKhoan INT PRIMARY KEY,
	Email NVARCHAR(255) UNIQUE NOT NULL,
	MatKhau NVARCHAR(255) CHECK (LEN(MatKhau) >= 8),
	VaiTro NVARCHAR(50) NOT NULL,
	HoTen NVARCHAR(255) NOT NULL,
	SoDienThoai NVARCHAR(10) CHECK (LEN(SoDienThoai) = 10),
	NgaySinh DATE CHECK (DATEDIFF(YEAR, NgaySinh, GETDATE()) >= 18),
	DiaChi NVARCHAR(255) NOT NULL,
	GioiTinh NVARCHAR(10) NOT NULL
);
GO

CREATE TABLE NhaXuatBan (
	MaNhaXuatBan INT IDENTITY(1,1) PRIMARY KEY,
	TenNhaXuatBan NVARCHAR(255) NOT NULL
);

GO
CREATE TABLE TacGia (
	MaTacGia INT IDENTITY(1,1) PRIMARY KEY,
	TenTacGia NVARCHAR(255) NOT NULL
);

GO
CREATE TABLE TheLoai(
	MaTheLoai INT IDENTITY(1,1) PRIMARY KEY,
	TenTheLoai NVARCHAR(255) NOT NULL
);

GO
CREATE TABLE Sach (
	MaSach INT IDENTITY(1,1) PRIMARY KEY,
	MaTacGia INT,
	MaTheLoai INT,
	MaNhaXuatBan INT,
	TenSach NVARCHAR(255) NOT NULL,
	LoaiTaiLieu NVARCHAR(50) NOT NULL,
	NamXuatBan INT CHECK (NamXuatBan >= 0 AND NamXuatBan <= YEAR(GETDATE())),
	GiaSach DECIMAL(18,0) CHECK (GiaSach >= 0),
	SoLuong INT CHECK (SoLuong >= 0),
	FOREIGN KEY (MaTacGia) REFERENCES TacGia(MaTacGia) ON DELETE SET NULL,
	FOREIGN KEY (MaTheLoai) REFERENCES TheLoai(MaTheLoai) ON DELETE SET NULL,
	FOREIGN KEY (MaNhaXuatBan) REFERENCES NhaXuatBan(MaNhaXuatBan) ON DELETE SET NULL
);

GO
CREATE TABLE PhieuMuonSach (
	MaPhieuMuon INT IDENTITY(1,1) PRIMARY KEY,
	MaTaiKhoan INT,
	NgayMuon DATE DEFAULT GETDATE(),
	CHECK (CONVERT(DATE, NgayMuon) = CONVERT(DATE, GETDATE())),
	NgayTra DATE NULL,
	FOREIGN KEY (MaTaiKhoan) REFERENCES TaiKhoan(MaTaiKhoan) ON DELETE CASCADE
);

GO
CREATE TABLE CuonSach (
	MaSach INT,
	MaPhieuMuon INT,
	TinhTrang NVARCHAR(255) NOT NULL,
	PRIMARY KEY (MaSach, MaPhieuMuon),
	FOREIGN KEY (MaSach) REFERENCES Sach(MaSach) ON DELETE CASCADE,
	FOREIGN KEY (MaPhieuMuon) REFERENCES PhieuMuonSach(MaPhieuMuon) ON DELETE CASCADE
);

GO
CREATE TABLE LichLamViec (
	MaLichLamViec INT IDENTITY(1,1) PRIMARY KEY,
	NgayLam DATE CHECK (NgayLam >= '2025-05-01'),
	Ca NVARCHAR(255) NOT NULL,
	MaTaiKhoan INT,
	FOREIGN KEY (MaTaiKhoan) REFERENCES TaiKhoan(MaTaiKhoan) ON DELETE CASCADE
);

GO
-- Thêm tác giả
INSERT INTO TacGia (TenTacGia)
VALUES (N'Lê Chí Cương'),
       (N'Viên Thị Giang'),
       (N'Nguyễn Công Khanh'),
       (N'Nguyễn Việt Trung');

INSERT INTO TacGia (TenTacGia)
VALUES (N'Viktor Mayer'),
       (N'Jeff Atwood'),
       (N'Nam Cao'),
       (N'Nguyễn Du'),
       (N'Ngô Tất Tố'),
       (N'Vũ Trọng Phụng'),
       (N'Nguyễn Hồng'),
       (N'Kim Lân'),
       (N'Thạch Lam'),
       (N'Nguyễn Tuân'),
       (N'Tô Hoài'),
       (N'Lưu Trọng Lư'),
       (N'Nguyễn Bính'),
       (N'Nguyễn Đình Lập'),
       (N'Thế Lữ'),
       (N'Vũ Bằng'),
       (N'Bích Khê'),
       (N'Hồ Chí Minh');

-- Thêm thể loại
INSERT INTO TheLoai (TenTheLoai)
VALUES (N'Khoa học'),
       (N'Pháp luật'),
       (N'Sức khỏe'),
       (N'Công nghệ thông tin');

INSERT INTO TheLoai (TenTheLoai)
VALUES (N'Văn học');

-- Thêm nhà xuất bản
INSERT INTO NhaXuatBan (TenNhaXuatBan)
VALUES (N'Đại học quốc gia TP.Hồ Chí Minh'),
       (N'Đại học quốc gia Hà Nội'),
       (N'Xây Dựng');

INSERT INTO NhaXuatBan (TenNhaXuatBan)
VALUES (N'Giáo dục'),
       (N'Kim Đồng'),
       (N'Trẻ'),
       (N'Hội Nhà Văn');

-- Thêm sách
INSERT INTO Sach (MaTacGia, MaTheLoai, MaNhaXuatBan, TenSach, LoaiTaiLieu, NamXuatBan, GiaSach, SoLuong)
VALUES 
		(1, 1, 1, N'Luyện kim - Cơ khí', N'Giáo Trình', 2013, 75000, 7),
		(2, 2, 1, N'Luật chứng khoán', N'Giáo Trình', 2023, 48000, 8),
		(3, 3, 2, N'Trị liệu tâm lý', N'Sách tham khảo', 2023, 92000, 9),
		(4, 4, 3, N'Tính toán cầu đúc hẫng trên phần mềm Midas', N'Sách tham khảo', 2018, 68000, 8);

INSERT INTO Sach (MaTacGia, MaTheLoai, MaNhaXuatBan, TenSach, LoaiTaiLieu, NamXuatBan, GiaSach, SoLuong)
VALUES 
		(6, 4, 1, N'Lập Trình và Cuộc Sống', N'Sách tham khảo', 2023, 100000, 10),
		(5, 4, 1, N'Trí Tuệ Nhân Tạo', N'Sách tham khảo', 2023, 90000, 10),
		(5, 4, 1, N'LIFE', N'Sách tham khảo', 2023, 70000, 10),
		(7, 4, 4, N'Chí Phèo', N'Sách tham khảo', 2015, 50000, 12),
		(8, 4, 5, N'Truyền Kiều', N'Sách tham khảo', 2003, 20000, 9),
		(9, 4, 5, N'Tắt Đèn', N'Sách tham khảo', 2000, 10000, 7),
		(10, 4, 7, N'Số Đỏ', N'Sách tham khảo', 2001, 15000, 4),
		(11, 4, 7, N'Bá Vương', N'Sách tham khảo', 2000, 12000, 8),
		(12, 4, 7, N'Vũ Nhất', N'Sách tham khảo', 1999, 11000, 6),
		(13, 4, 4, N'Hà Nội 36 Phố Phường', N'Sách tham khảo', 2002, 20000, 9),
		(14, 4, 5, N'Chùa Đàn', N'Sách tham khảo', 2001, 22000, 10),
		(15, 4, 7, N'Trúng Số Độc Đắc', N'Sách tham khảo', 1989, 9000, 4),
		(16, 4, 7, N'Những Ngày Thơ Ấu', N'Sách tham khảo', 2005, 20000, 5),
		(17, 4, 4, N'Thiêng Thu', N'Sách tham khảo', 1988, 10000, 3),
		(18, 4, 5, N'Mười Hai Bản Nước', N'Sách tham khảo', 1880, 9000, 3),
		(19, 4, 5, N'Ngoài Ô', N'Sách tham khảo', 1989, 10000, 9),
		(20, 4, 7, N'Lê Phong', N'Sách tham khảo', 2000, 10000, 5),
		(21, 4, 4, N'Phù Dung Ơi, Vĩnh Biệt!', N'Sách tham khảo', 2003, 20000, 10),
		(22, 4, 4, N'Nhật Ký Trong Tù', N'Sách tham khảo', 2005, 20000, 10);

GO
INSERT INTO TaiKhoan (MaTaiKhoan, Email, MatKhau, VaiTro, HoTen, SoDienThoai, NgaySinh, DiaChi, GioiTinh)
VALUES	
		(22110178,'22110178@hcmute.edu.vn.com', 'leloc123', N'DocGia', N'Lê Văn Lộc', '0183476789', '2002-01-01', N'Hồ Chí Minh', N'Nam'),
		(2110827,'2110827@gmail.com', 'leloc123', N'QuanTriVien', N'Trần Khải Hoàn', '0124567893', '2000-05-21', N'Hồ Chí Minh', N'Nam'),
		(1234567,'1234567@gmail.com', 'leloc123', N'ThuThu', N'Lê Văn Lộc', '0123567894', '2002-01-01', N'Hồ Chí Minh', N'Nam'),
		(2110678,'2110678@gmail.com', 'leloc123', N'DocGia', N'Nguyễn Thanh Nhựt Huy', '0124567892', '2001-06-21', N'Hà Nội', N'Nam'),
		(2345678,'2345678@gmail.com', 'leloc123', N'ThuThu', N'Mai Gia Linh', '0124567845', '2003-11-23', N'Cà Mau', N'Nữ'),
		(2110478,'2110478@gmail.com', 'leloc123', N'ThuThu', N'Nguyễn Lan Anh', '0124567152', '2002-06-21', N'Vũng Tàu', N'Nữ');

GO
-- Thêm lịch làm việc
INSERT INTO LichLamViec (NgayLam, Ca, MaTaiKhoan)
VALUES ('2025-05-26', N'Sáng', 1234567),
		('2025-05-26', N'Sáng', 1234567),
		('2025-05-27', N'Sáng', 2345678),
		('2025-05-27', N'Sáng', 2345678),
		('2025-05-28', N'Sáng', 2110478),
	   ('2025-05-28', N'Chiều', 2110478),
	   ('2025-05-29', N'Chiều', 2110478),
	   ('2025-05-29', N'Chiều', 1234567),
	   ('2025-05-30', N'Chiều', 1234567),
	   ('2025-05-30', N'Chiều', 1234567);



DISABLE TRIGGER ALL ON PhieuMuonSach;
SET IDENTITY_INSERT PhieuMuonSach ON;
ALTER TABLE PhieuMuonSach NOCHECK CONSTRAINT ALL;


INSERT INTO PhieuMuonSach (MaPhieuMuon, MaTaiKhoan, NgayMuon, NgayTra)
VALUES  (1, 20113536 , '2024-04-03', NULL);

ENABLE TRIGGER ALL ON PhieuMuonSach;
SET IDENTITY_INSERT PhieuMuonSach OFF;
ALTER TABLE PhieuMuonSach CHECK CONSTRAINT ALL;

INSERT INTO CuonSach (MaSach, MaPhieuMuon, TinhTrang)
VALUES	(1, 1, N'Đang mượn');
