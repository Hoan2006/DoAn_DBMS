-- Chỉ mục trên bảng sách
CREATE INDEX idx_ten_sach ON Sach(TenSach);
CREATE INDEX idx_ma_tacgia ON Sach(MaTacGia);
CREATE INDEX idx_ma_theloai ON Sach(MaTheLoai);
CREATE INDEX idx_ma_nxb ON Sach(MaNhaXuatBan);

-- Chỉ mục trên bảng tài khoản
CREATE UNIQUE INDEX idx_email ON TaiKhoan(Email);
CREATE INDEX idx_sdt ON TaiKhoan(SoDienThoai);

-- Chỉ mục trên bảng nhà xuất bản, tác giả, thể loại
CREATE INDEX idx_ten_nxb ON NhaXuatBan(TenNhaXuatBan);
CREATE INDEX idx_ten_tacgia ON TacGia(TenTacGia);
CREATE INDEX idx_ten_theloai ON TheLoai(TenTheLoai);
