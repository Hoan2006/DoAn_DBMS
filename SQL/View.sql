-- Get account list
CREATE VIEW VW_Account_List AS
SELECT 	
	*
FROM dbo.TaiKhoan 

GO
-- Get Phiếu mượn list

CREATE VIEW VW_AllPhieuMuonSach AS
SELECT 
    pm.MaPhieuMuon,               -- Mã phiếu mượn
    pm.MaTaiKhoan,                -- Mã tài khoản
    pm.NgayMuon,                  -- Ngày mượn
    pm.NgayTra,                   -- Ngày trả
    cs.TinhTrang,                 -- Tình trạng sách
    s.TenSach,                    -- Tên sách
    tl.TenTheLoai,                -- Tên thể loại
    tg.TenTacGia                  -- Tên tác giả
FROM 
    PhieuMuonSach pm
JOIN 
    CuonSach cs ON pm.MaPhieuMuon = cs.MaPhieuMuon
JOIN 
    Sach s ON cs.MaSach = s.MaSach
JOIN 
    TheLoai tl ON s.MaTheLoai = tl.MaTheLoai
JOIN 
    TacGia tg ON s.MaTacGia = tg.MaTacGia;
GO

-- Get Sách list
CREATE VIEW VW_Book_List AS
SELECT 
    S.MaSach, 
    TG.TenTacGia, 
    TL.TenTheLoai, 
    NXB.TenNhaXuatBan, 
    S.TenSach, 
    S.LoaiTaiLieu, 
    S.NamXuatBan, 
    S.GiaSach, 
    S.SoLuong
FROM 
    Sach S
INNER JOIN 
    TacGia TG ON S.MaTacGia = TG.MaTacGia
INNER JOIN 
    TheLoai TL ON S.MaTheLoai = TL.MaTheLoai
INNER JOIN 
    NhaXuatBan NXB ON S.MaNhaXuatBan = NXB.MaNhaXuatBan;

GO
-- Get Nhà Xuất Bản list
CREATE VIEW VW_NhaXuatBan_List AS
SELECT *
FROM dbo.NhaXuatBan

GO
-- Get Thể Loại list
CREATE VIEW VW_TheLoai_List AS
SELECT *
FROM dbo.TheLoai

GO
-- Get Tác Giả list 
CREATE VIEW VW_TacGia_List AS
SELECT *
FROM dbo.TacGia

GO

-- Get Book Loan Coupon list
Create VIEW VW_Book_Loan_Coupon_List AS
SELECT 
	*
FROM dbo.PhieuMuonSach 

GO
-- Get 
CREATE VIEW [dbo].[VW_GetAllMaTaiKhoan]
AS
SELECT MaTaiKhoan FROM TaiKhoan;
GO

-- Get lịch làm việc list

CREATE VIEW VW_Schedule_List AS
SELECT 
	MaLichLamViec, NgayLam, Ca, Tk.MaTaiKhoan, TK.HoTen, TK.SoDienThoai, TK.GioiTinh
FROM dbo.LichLamViec LLV
JOIN dbo.TaiKhoan TK ON TK.MaTaiKhoan = LLV.MaTaiKhoan

GO

-- Get Thuthu list
CREATE VIEW VW_Librarian_List AS
SELECT 
	MaTaiKhoan, 
	HoTen 
FROM dbo.TaiKhoan
WHERE VaiTro = N'ThuThu'
