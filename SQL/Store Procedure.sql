/***	Login Account (Phat)		***/
CREATE PROCEDURE SP_Login
    @Email NVARCHAR(255),
    @MatKhau NVARCHAR(255)
AS 
BEGIN
    SELECT * FROM dbo.TaiKhoan WHERE Email = @Email AND MatKhau = @MatKhau
END;


GO
/***	Get login account profile(Phat)		***/
CREATE PROCEDURE SP_Get_Account_Profile
(@Email nvarchar(255))
AS
BEGIN
    SELECT *
    FROM TaiKhoan
    WHERE Email = @Email
END;

GO
/***	Change password(Phat)		***/
CREATE PROCEDURE SP_Change_Account_Password
(
    @Email NVARCHAR(255),
    @MatKhauMoi NVARCHAR(255),
	@XacNhan NVARCHAR(255),
	@MatKhauCu NVARCHAR(255)
)
AS 
BEGIN
	IF NOT EXISTS (SELECT * FROM dbo.TaiKhoan WHERE Email = @Email AND MatKhau = @MatKhauCu)
    BEGIN
        RAISERROR('Email hoặc mật khẩu cũ không đúng', 16, 1);
		RETURN;
    END

	IF @MatKhauMoi <> @XacNhan
    BEGIN
        RAISERROR('Mật khẩu mới và xác nhận không khớp', 16, 1);
		RETURN;
    END

    BEGIN TRY
            UPDATE dbo.TaiKhoan
			SET MatKhau = @MatKhauMoi
			WHERE Email = @Email;      
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END

GO
/***	Update profile(Phat)		***/
CREATE PROCEDURE SP_Account_Profile
	@MaTaiKhoan int,
    @HoTen nvarchar(255),
    @DiaChi nvarchar(255),
    @NgaySinh date,
	@SoDienThoai nvarchar(10),
    @GioiTinh nvarchar(10)
AS
BEGIN
    BEGIN TRY
            UPDATE dbo.TaiKhoan
				SET HoTen = @HoTen,
					DiaChi = @DiaChi,
					NgaySinh = @NgaySinh,
					GioiTinh = @GioiTinh,
					SoDienThoai = @SoDienThoai
			 WHERE MaTaiKhoan = @MaTaiKhoan;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/***	Add New Account		***/
CREATE PROCEDURE SP_Add_New_Account
	@MaTaiKhoan int,
    @HoTen nvarchar(255),
	@MatKhau nvarchar(255),
    @DiaChi nvarchar(255),
    @NgaySinh date,
	@Email NVARCHAR(255),
	@SoDienThoai NVARCHAR(10),
	@VaiTro nvarchar(50),
    @GioiTinh nvarchar(10)
AS
BEGIN
    BEGIN TRY
        INSERT INTO dbo.TaiKhoan (MaTaiKhoan, HoTen, MatKhau, DiaChi, Email, NgaySinh, SoDienThoai, VaiTro, GioiTinh)
        VALUES (@MaTaiKhoan, @HoTen, @MatKhau, @DiaChi, @Email, @NgaySinh,@SoDienThoai, @VaiTro, @GioiTinh);       
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/***	Delete account		  ***/
CREATE PROCEDURE SP_Delete_Account
    @MaTaiKhoan int
AS
BEGIN
    BEGIN TRY
            DELETE dbo.TaiKhoan WHERE MaTaiKhoan = @MaTaiKhoan;       
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;
GO

/***	Update account		***/
CREATE PROCEDURE SP_Update_Account
	@MaTaiKhoan int,
    @HoTen nvarchar(255),
	@MatKhau nvarchar(255),
    @DiaChi nvarchar(255),
    @NgaySinh date,
	@Email nvarchar(255),
	@SoDienThoai nvarchar(10),
	@VaiTro nvarchar(50),
    @GioiTinh nvarchar(10)
AS
BEGIN
    BEGIN TRY
            UPDATE dbo.TaiKhoan
				SET HoTen = @HoTen,
					MatKhau = @MatKhau,
					DiaChi = @DiaChi,
					NgaySinh = @NgaySinh,
					GioiTinh = @GioiTinh,
					Email = @Email,
					SoDienThoai = @SoDienThoai,
					VaiTro = @VaiTro
			 WHERE MaTaiKhoan = @MaTaiKhoan;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/***	Add new schedule (Phat)		***/
CREATE PROCEDURE SP_Add_New_Schedule
(
	@NgayLam date,
	@Ca nvarchar(255),
	@MaTaiKhoan int
)
AS
BEGIN
    BEGIN TRY
        INSERT INTO dbo.LichLamViec(NgayLam, Ca, MaTaiKhoan)
        VALUES (@NgayLam , @Ca , @MaTaiKhoan );       
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/***	Update schedule (Phat)		***/
CREATE PROCEDURE SP_Update_Schedule
(
	@MaLichLamViec int,
	@NgayLam date,
	@Ca nvarchar(255),
	@MaTaiKhoan int
)
AS
BEGIN
    BEGIN TRY
        Update dbo.LichLamViec
        SET NgayLam = @NgayLam,
			Ca = @Ca , 
			MaTaiKhoan = @MaTaiKhoan 
		WHERE MaLichLamViec = @MaLichLamViec
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/***	Delete schedule (Phat)		***/
CREATE PROCEDURE SP_Delete_Schedule
(
	@MaLichLamViec int
)
AS
BEGIN
    BEGIN TRY
        DELETE dbo.LichLamViec WHERE MaLichLamViec = @MaLichLamViec
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/***	Add Books To Coupon (Phat)		***/
CREATE PROCEDURE SP_Add_Books_To_Coupon
(
	@MaSach int,
	@MaPhieuMuon int
)
AS
BEGIN
    BEGIN TRY
        INSERT INTO dbo.CuonSach(MaSach, MaPhieuMuon, TinhTrang)
		VALUES (@MaSach, @MaPhieuMuon, N'Đang mượn')
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/***	Update Book In Coupon (Phat)		***/
CREATE PROCEDURE SP_Update_Book_In_Coupon
(
	@MaPhieuMuon int,
	@MaSach int,
	@TinhTrang nvarchar(255)
)
AS
BEGIN
    BEGIN TRY
        UPDATE dbo.CuonSach
		SET TinhTrang = @TinhTrang
		WHERE MaSach = @MaSach AND MaPhieuMuon = @MaPhieuMuon
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO

/***	Get schedule (Phat)		***/
CREATE PROCEDURE SP_Get_Schedule
(
	@NgayDauTuan date = NULL,
	@NgayCuoiTuan date = NULL,
	@MaTaiKhoan int = NULL
)
AS
BEGIN
	SELECT * FROM VW_Schedule_List
	WHERE
		(@NgayDauTuan IS NULL OR NgayLam >= @NgayDauTuan) AND
		(@NgayCuoiTuan IS NULL OR NgayLam <= @NgayCuoiTuan)	AND
		(@MaTaiKhoan IS NULL OR MaTaiKhoan = @MaTaiKhoan)
END;

GO
/***	Add New Book(Van)		***/
CREATE PROCEDURE SP_Add_New_Book
    @MaTacGia INT,
	@MaTheLoai INT,
    @MaNhaXuatBan INT,
    @TenSach NVARCHAR(255),
	@LoaiTaiLieu NVARCHAR(255),
	@NamXuatBan INT,
	@GiaSach DECIMAL,
    @SoLuong INT
AS
BEGIN
    BEGIN TRY
        INSERT INTO dbo.Sach (MaTacGia, MaTheLoai, MaNhaXuatBan, TenSach, LoaiTaiLieu, NamXuatBan, GiaSach, SoLuong)
        VALUES (@MaTacGia, @MaTheLoai, @MaNhaXuatBan, @TenSach, @LoaiTaiLieu, @NamXuatBan, @GiaSach, @SoLuong);
    END TRY
    BEGIN CATCH
		DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/***	Update Book(Van)		***/
CREATE PROCEDURE SP_Update_Book
	@MaTacGia INT,
	@MaTheLoai INT,
    @MaNhaXuatBan INT,
    @TenSach NVARCHAR(255),
	@LoaiTaiLieu NVARCHAR(255),
	@NamXuatBan INT,
	@GiaSach DECIMAL,
    @SoLuong INT
AS
BEGIN
    BEGIN TRY
            UPDATE dbo.Sach
				SET MaTacGia = @MaTacGia,
					MaTheLoai = @MaTheLoai,
					MaNhaXuatBan = @MaNhaXuatBan,
					TenSach = @TenSach,
					LoaiTaiLieu = @LoaiTaiLieu,
					NamXuatBan = @NamXuatBan,
					GiaSach = @GiaSach,
					SoLuong = @SoLuong
			 WHERE TenSach = @TenSach;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/***	Find book by advanced (Van)		***/
CREATE PROCEDURE SP_Find_Book_By_Advanced
(
	@TenTacGia NVARCHAR(255) = NULL,
	@TenTheLoai NVARCHAR(255) = NULL,
    @TenNhaXuatBan NVARCHAR(255) = NULL,
    @TenSach NVARCHAR(255) = NULL,
	@LoaiTaiLieu NVARCHAR(255) = NULL,
	@NamXuatBan INT = NULL
)
AS
BEGIN
	SELECT 
		*
	FROM VW_Book_List 
	WHERE 
		(@TenTacGia IS NULL OR @TenTacGia = TenTacGia) AND
		(@TenTheLoai IS NULL OR @TenTheLoai = TenTheLoai) AND
		(@TenNhaXuatBan IS NULL OR @TenNhaXuatBan = TenNhaXuatBan) AND
		(@TenSach IS NULL OR TenSach LIKE '%' + @TenSach + '%') AND
		(@LoaiTaiLieu IS NULL OR @LoaiTaiLieu = LoaiTaiLieu) AND
		(@NamXuatBan IS NULL OR @NamXuatBan = NamXuatBan)
END;

GO
/***	Delete book(Van)		***/
CREATE PROCEDURE SP_Delete_Book
    @MaSach int
AS
BEGIN
    BEGIN TRY
            DELETE dbo.Sach WHERE MaSach = @MaSach;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/***	Add Tác Giả(Van)		***/
CREATE PROCEDURE SP_Add_Tac_Gia
    @TenTacGia NVARCHAR(255)
AS
BEGIN
    BEGIN TRY
        INSERT INTO dbo.TacGia (TenTacGia)
        VALUES (@TenTacGia);
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/***	Update Tác Giả(Van)		***/
CREATE PROCEDURE SP_Update_Tac_Gia
    @MaTacGia INT,
    @TenTacGia NVARCHAR(255)
AS
BEGIN
    BEGIN TRY
		UPDATE dbo.TacGia SET TenTacGia = @TenTacGia WHERE MaTacGia = @MaTacGia;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/***	Find TacGia by advanced (Van)		***/
CREATE PROCEDURE SP_Find_TacGia
(
	@TenTacGia NVARCHAR(255) = NULL
)
AS
BEGIN
	SELECT * FROM VW_TacGia_List WHERE TenTacGia LIKE '%' + @TenTacGia + '%'
END;

GO
/***	Delete tac gia(Van)		***/
CREATE PROCEDURE SP_Delete_TacGia
    @MaTacGia int
AS
BEGIN
    BEGIN TRY
            DELETE dbo.TacGia WHERE MaTacGia = @MaTacGia;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/* Thêm thể loại (Hoàn) */
CREATE PROCEDURE SP_Add_New_TheLoai
    @TenTheLoai nvarchar(50)
AS
BEGIN
    BEGIN TRY
        INSERT INTO dbo.TheLoai (TenTheLoai)
        VALUES (@TenTheLoai);
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/* Xoá thể loại (Hoàn) */
CREATE PROCEDURE SP_Delete_TheLoai
    @MaTheLoai int
AS
BEGIN
    BEGIN TRY
            DELETE dbo.TheLoai WHERE MaTheLoai = @MaTheLoai;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/* Sửa thể loại (Hoàn)*/
CREATE PROCEDURE SP_Update_TheLoai
	@MaTheLoai int,
    @TenTheLoai nvarchar(50)
AS
BEGIN
    BEGIN TRY
            UPDATE dbo.TheLoai
				SET TenTheLoai = @TenTheLoai
			 WHERE MaTheLoai = @MaTheLoai;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/* Tìm kiếm thể loại (Hoàn)*/
CREATE PROCEDURE SP_Find_TheLoai
(
    @TenTheLoai nvarchar(255) = NULL
)
AS
BEGIN
	SELECT * FROM VW_TheLoai_List WHERE TenTheLoai LIKE '%' + @TenTheLoai + '%' 
END;

go
/***	Find Book Loan Coupon by status (Phat)		***/
CREATE PROCEDURE SP_Find_Book_Loan_Coupon_By_Status
(
	@type int
)
AS
BEGIN
	SELECT 
		*
	FROM VW_Book_Loan_Coupon_List
	WHERE 
		(@type = 0 AND NgayTra IS NULL) OR
		(@type = 1 AND NgayTra IS NOT NULL)
END;

GO
/***	Add New Book Loan Coupon(Phat)		***/
CREATE PROCEDURE SP_Add_New_Book_Loan_Coupon
    @MaTaiKhoan int = NULL,
    @NgayMuon date = NULL,
    @NgayTra date = NULL
AS
BEGIN
    BEGIN TRY
		DECLARE @InsertedID INT;

        INSERT INTO dbo.PhieuMuonSach (MaTaiKhoan, NgayMuon, NgayTra)
        VALUES (@MaTaiKhoan, @NgayMuon, @NgayTra);

        SET @InsertedID = SCOPE_IDENTITY();
		SELECT @InsertedID AS InsertedID;
 
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO
/***	Delete coupon(Phat)		***/
CREATE PROCEDURE SP_Delete_Coupon
    @MaPhieuMuon int
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
		UPDATE S
		SET S.SoLuong = S.SoLuong + 1
		FROM dbo.CuonSach CS
		JOIN dbo.PhieuMuonSach PMS ON PMS.MaPhieuMuon = CS.MaPhieuMuon
		JOIN dbo.Sach S ON CS.MaSach = S.MaSach
		WHERE CS.MaPhieuMuon = @MaPhieuMuon AND NgayTra IS NULL;

        DELETE FROM dbo.PhieuMuonSach
        WHERE MaPhieuMuon = @MaPhieuMuon
        
        COMMIT;
    END TRY
    BEGIN CATCH
		DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
        ROLLBACK;
    END CATCH;
END;

GO
/***	Update coupon(Phat)		***/
CREATE PROCEDURE SP_Update_Coupon
	@MaPhieuMuon int,
	@MaTaiKhoan int,
    @MaSach int,
	@NgayMuon date,
	@NgayTra date
AS
BEGIN
    BEGIN TRANSACTION;

    BEGIN TRY
			UPDATE dbo.CuonSach
				Set	MaSach = @MaSach
				Where MaPhieuMuon = @MaPhieuMuon;

            UPDATE dbo.PhieuMuonSach
				SET MaTaiKhoan = @MaTaiKhoan,
					NgayMuon = @NgayMuon,
					NgayTra = @NgayTra
				WHERE MaPhieuMuon = @MaPhieuMuon;
        COMMIT;
    END TRY
    BEGIN CATCH
		DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
        ROLLBACK;
    END CATCH;
END;

GO
/***	Update coupon _ Returned(Phat)		***/
CREATE PROCEDURE SP_Update_Coupon_Returned
    @MaPhieuMuon INT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM dbo.CuonSach CS
		JOIN dbo.PhieuMuonSach PMS ON PMS.MaPhieuMuon = CS.MaPhieuMuon
        JOIN dbo.Sach S ON CS.MaSach = S.MaSach
        JOIN dbo.TaiKhoan TK ON TK.MaTaiKhoan = PMS.MaTaiKhoan
        WHERE CS.MaPhieuMuon = @MaPhieuMuon 
            AND (CS.TinhTrang = N'Đang mượn')
            AND (
                (TK.VaiTro = N'Sinh viên CLC' AND (
                    (S.LoaiTaiLieu = N'Sách tham khảo' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 21) 
                    OR (S.LoaiTaiLieu = N'Giáo trình' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 105)
                ))
                OR 
                (TK.VaiTro = N'Sinh viên đại trà' AND (
                    (S.LoaiTaiLieu = N'Sách tham khảo' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 21) 
                    OR (S.LoaiTaiLieu = N'Giáo trình' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 105)
                ))
                OR 
                (TK.VaiTro = N'Học viên cao học' AND (
                    (S.LoaiTaiLieu = N'Sách tham khảo' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 32) 
                    OR (S.LoaiTaiLieu = N'Giáo trình' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 56)
                ))
                OR 
                (TK.VaiTro = N'Giảng viên' AND (
                    (S.LoaiTaiLieu = N'Sách tham khảo' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 365) 
                    OR (S.LoaiTaiLieu = N'Giáo trình' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 365)
                ))
            )
    )
    BEGIN
		UPDATE CS
        SET TinhTrang = N'Trả trễ'
        FROM dbo.CuonSach CS
        JOIN dbo.PhieuMuonSach PMS ON PMS.MaPhieuMuon = CS.MaPhieuMuon
        JOIN dbo.Sach S ON CS.MaSach = S.MaSach
        JOIN dbo.TaiKhoan TK ON TK.MaTaiKhoan = PMS.MaTaiKhoan
        WHERE CS.MaPhieuMuon = @MaPhieuMuon 
            AND CS.TinhTrang = N'Đang mượn'
            AND (
                (TK.VaiTro = N'Sinh viên CLC' AND (
                    (S.LoaiTaiLieu = N'Sách tham khảo' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 21) 
                    OR (S.LoaiTaiLieu = N'Giáo trình' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 105)
                ))
                OR 
                (TK.VaiTro = N'Sinh viên đại trà' AND (
                    (S.LoaiTaiLieu = N'Sách tham khảo' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 21) 
                    OR (S.LoaiTaiLieu = N'Giáo trình' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 105)
                ))
                OR 
                (TK.VaiTro = N'Học viên cao học' AND (
                    (S.LoaiTaiLieu = N'Sách tham khảo' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 32) 
                    OR (S.LoaiTaiLieu = N'Giáo trình' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 56)
                ))
                OR 
                (TK.VaiTro = N'Giảng viên' AND (
                    (S.LoaiTaiLieu = N'Sách tham khảo' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 365) 
                    OR (S.LoaiTaiLieu = N'Giáo trình' AND DATEDIFF(DAY, PMS.NgayMuon, GETDATE()) > 365)
                ))
            )
		RAISERROR(N'Người này đang giữ sách quá hạn trả.', 16, 1)
        RETURN;
    END

    BEGIN TRANSACTION;

    BEGIN TRY
        UPDATE S
        SET S.SoLuong = S.SoLuong + 1
        FROM dbo.CuonSach CS
        JOIN dbo.Sach S ON CS.MaSach = S.MaSach
        WHERE CS.MaPhieuMuon = @MaPhieuMuon AND (CS.TinhTrang = N'Đã trả' OR CS.TinhTrang = N'Trả trễ');

        UPDATE dbo.PhieuMuonSach
        SET NgayTra = GETDATE()
        WHERE MaPhieuMuon = @MaPhieuMuon;

        COMMIT;
    END TRY
    BEGIN CATCH
		DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
        ROLLBACK;
    END CATCH;
END;


GO
/***	Find Book Loan Coupon (Phat)		***/
CREATE PROCEDURE SP_Find_Account_Book_Loan_Coupon
(
	@MaTaiKhoan int
)
AS
BEGIN
	SELECT 
		*
	FROM dbo.PhieuMuonSach 
	WHERE MaTaiKhoan = @MaTaiKhoan
END;

GO
/***	Add NXB (Trung)		***/

CREATE PROCEDURE SP_Add_New_NXB
	@TenNhaXuatBan NVARCHAR(255)
AS
BEGIN
    BEGIN TRY
        INSERT INTO dbo.NhaXuatBan(TenNhaXuatBan)
        VALUES (@TenNhaXuatBan);
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;
go
/***	Update NXB (Trung)		***/
CREATE PROCEDURE SP_Update_NXB
	@MaNhaXuatBan INT,
	@TenNhaXuatBan NVARCHAR(255)
AS
BEGIN
    BEGIN TRY
		UPDATE dbo.NhaXuatBan
			Set	TenNhaXuatBan = @TenNhaXuatBan
			Where MaNhaXuatBan = @MaNhaXuatBan;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;
GO
/***	Find NXB (Trung)		***/
CREATE PROCEDURE SP_Find_NXB
(
	@TenNhaXuatBan NVARCHAR(255) = NULL
)
AS
BEGIN
	SELECT 
		*
	FROM VW_NhaXuatBan_List
	WHERE TenNhaXuatBan LIKE '%' + @TenNhaXuatBan + '%'
END;

GO
/***	Delete NXB (Trung)		***/
CREATE PROCEDURE SP_Delete_NXB
	@MaNhaXuatBan INT,
	@TenNhaXuatBan NVARCHAR(255)
AS
BEGIN
    BEGIN TRY
			Delete From dbo.NhaXuatBan
			Where MaNhaXuatBan = @MaNhaXuatBan And TenNhaXuatBan = @TenNhaXuatBan;
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO



CREATE PROCEDURE SP_TimKiemSachTheoTenSach
    @TenSach NVARCHAR(100)
AS
BEGIN
    SELECT 
        s.MaSach,
        s.TenSach,
        s.NamXuatBan,
        s.GiaSach,
        s.SoLuong,
        ns.TenNhaXuatBan,
        tg.TenTacGia,
        tl.TenTheLoai
    FROM 
        Sach s
    JOIN 
        NhaXuatBan ns ON s.MaNhaXuatBan = ns.MaNhaXuatBan
    JOIN 
        TacGia tg ON s.MaTacGia = tg.MaTacGia
    JOIN 
        TheLoai tl ON s.MaTheLoai = tl.MaTheLoai
    WHERE 
        s.SoLuong > 0
        AND s.TenSach LIKE '%' + @TenSach + '%';  -- Đi?u ki?n t?m ki?m theo tên sách
END;

GO

CREATE PROCEDURE [dbo].[SP_TimKiemSachTheoTheLoai]
    @TenTheLoai NVARCHAR(100)
AS
BEGIN
    SELECT 
        s.MaSach,
        s.TenSach,
        s.NamXuatBan,
        s.GiaSach,
        s.SoLuong,
        ns.TenNhaXuatBan,
        tg.TenTacGia,
        tl.TenTheLoai
    FROM 
        Sach s
    JOIN 
        NhaXuatBan ns ON s.MaNhaXuatBan = ns.MaNhaXuatBan
    JOIN 
        TacGia tg ON s.MaTacGia = tg.MaTacGia
    JOIN 
        TheLoai tl ON s.MaTheLoai = tl.MaTheLoai
    WHERE 
        s.SoLuong > 0
        AND tl.TenTheLoai = @TenTheLoai;  -- T?m sách theo tên th? lo?i
END;

GO

---tim kiem sach theo nha xuat ban
CREATE PROCEDURE [dbo].[SP_TimKiemSachTheoMaNhaXuatBan1]
    @MaNhaXuatBan INT
AS
BEGIN
    SELECT 
        s.MaSach,
        s.TenSach,
        s.NamXuatBan,
        s.GiaSach,
        s.SoLuong,
        ns.TenNhaXuatBan,
        tg.TenTacGia,
        tl.TenTheLoai
    FROM 
        Sach s
    JOIN 
        NhaXuatBan ns ON s.MaNhaXuatBan = ns.MaNhaXuatBan
    JOIN 
        TacGia tg ON s.MaTacGia = tg.MaTacGia
    JOIN 
        TheLoai tl ON s.MaTheLoai = tl.MaTheLoai
    WHERE 
        s.SoLuong > 0
        AND s.MaNhaXuatBan = @MaNhaXuatBan;  
END;

GO


---tim kiem sach theo tac gia
CREATE PROCEDURE [dbo].[SP_TimKiemSachTheoMaTacGia]
    @MaTacGia INT
AS
BEGIN
    SELECT 
        s.MaSach,
        s.TenSach,
        s.NamXuatBan,
        s.GiaSach,
        s.SoLuong,
        ns.TenNhaXuatBan,
        tg.TenTacGia,
        tl.TenTheLoai
    FROM 
        Sach s
    JOIN 
        NhaXuatBan ns ON s.MaNhaXuatBan = ns.MaNhaXuatBan
    JOIN 
        TacGia tg ON s.MaTacGia = tg.MaTacGia
    JOIN 
        TheLoai tl ON s.MaTheLoai = tl.MaTheLoai
    WHERE 
        s.SoLuong > 0
        AND s.MaTacGia = @MaTacGia;  
END;

GO

----lay lich su muon sach cua tai khoan
CREATE PROCEDURE SP_GetLichSuMuonSachByMaTaiKhoan
    @MaTaiKhoan INT
AS
BEGIN
    SELECT 
        pms.MaPhieuMuon, 
        pms.NgayMuon, 
        pms.NgayTra, 
        s.TenSach, 
        ts.TenTacGia, 
        s.NamXuatBan, 
        s.GiaSach, 
        cs.TinhTrang
    FROM 
        PhieuMuonSach pms
    JOIN 
        CuonSach cs ON pms.MaPhieuMuon = cs.MaPhieuMuon
    JOIN 
        Sach s ON cs.MaSach = s.MaSach
    JOIN 
        TacGia ts ON s.MaTacGia = ts.MaTacGia
    WHERE 
        pms.MaTaiKhoan = @MaTaiKhoan
    ORDER BY 
        pms.NgayMuon DESC;
END;

GO


------Store mượn sách
CREATE PROCEDURE SP_Reader_MuonSach
    @MaTaiKhoan INT,
    @MaSach INT,
    @NgayMuon DATE,
    @NgayTra DATE
AS
BEGIN
   -- Kiểm tra xem sách có sẵn hay không
   IF EXISTS (SELECT 1 FROM Sach WHERE MaSach = @MaSach AND SoLuong > 0)
   BEGIN
        -- Thêm phiếu mượn sách
        INSERT INTO PhieuMuonSach (MaTaiKhoan, NgayMuon, NgayTra)
        VALUES (@MaTaiKhoan, @NgayMuon, @NgayTra);

        DECLARE @MaPhieuMuon INT;
        SET @MaPhieuMuon = SCOPE_IDENTITY();

        -- Thêm vào bảng CuonSach
        INSERT INTO CuonSach (MaSach, MaPhieuMuon, TinhTrang)
        VALUES (@MaSach, @MaPhieuMuon, N'Đang mượn');

        PRINT 'Mượn sách thành công.';
   END
   ELSE
   BEGIN
        PRINT 'Sách không có sẵn để mượn';
   END
END;

GO


---view get phieu muon sach by ma tai khoan
CREATE PROCEDURE SP_GetPhieuMuonSachByMaTaiKhoan
    @MaTaiKhoan INT
AS
BEGIN
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
        TacGia tg ON s.MaTacGia = tg.MaTacGia
    WHERE 
        pm.MaTaiKhoan = @MaTaiKhoan;  -- Lọc theo mã tài khoản
END;
GO



---get phieu muon sach by tinh trang

CREATE PROCEDURE SP_GetPhieuMuonSachByTinhTrang
    @TinhTrang NVARCHAR(50)  -- Tham số lọc theo tình trạng sách
AS
BEGIN
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
        TacGia tg ON s.MaTacGia = tg.MaTacGia
    WHERE 
        cs.TinhTrang = @TinhTrang;    -- Lọc theo tình trạng sách
END;

GO


---store update tra sach
CREATE PROCEDURE SP_UpdateTraSach
    @MaPhieuMuon INT
AS
BEGIN
UPDATE CuonSach
SET TinhTrang = N'Đã trả'
WHERE MaPhieuMuon = @MaPhieuMuon
END;
GO
-- Tim kiem tai khoan
CREATE PROCEDURE SP_Find_Account_By_Advanced
(
    @MaTaiKhoan int = NULL,
    @HoTen nvarchar(255) = NULL,
    @DiaChi nvarchar(255) = NULL,
    @Email NVARCHAR(255) = NULL,
    @SoDienThoai NVARCHAR(10) = NULL,
    @VaiTro nvarchar(50) = NULL,
    @GioiTinh nvarchar(10) = NULL
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM VW_Account_List
    WHERE 
        (@MaTaiKhoan IS NULL OR MaTaiKhoan = @MaTaiKhoan)
        AND (@HoTen IS NULL OR HoTen LIKE @HoTen + '%')
        AND (@DiaChi IS NULL OR DiaChi LIKE @DiaChi + '%')
        AND (@Email IS NULL OR Email LIKE @Email + '%')
        AND (@SoDienThoai IS NULL OR SoDienThoai LIKE @SoDienThoai + '%')
        AND (@VaiTro IS NULL OR VaiTro = @VaiTro)
        AND (@GioiTinh IS NULL OR GioiTinh = @GioiTinh);
END;
GO

-- Thêm lịch làm việc
CREATE PROCEDURE SP_Add_New_Schedule
(
	@NgayLam date,
	@Ca nvarchar(255),
	@MaTaiKhoan int
)
AS
BEGIN
    BEGIN TRY
        INSERT INTO dbo.LichLamViec(NgayLam, Ca, MaTaiKhoan)
        VALUES (@NgayLam , @Ca , @MaTaiKhoan );       
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO

-- Cập nhật lịch làm việc
CREATE PROCEDURE SP_Update_Schedule
(
	@MaLichLamViec int,
	@NgayLam date,
	@Ca nvarchar(255),
	@MaTaiKhoan int
)
AS
BEGIN
    BEGIN TRY
        Update dbo.LichLamViec
        SET NgayLam = @NgayLam,
			Ca = @Ca , 
			MaTaiKhoan = @MaTaiKhoan 
		WHERE MaLichLamViec = @MaLichLamViec
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO

-- Xóa lịch làm việc
CREATE PROCEDURE SP_Delete_Schedule
(
	@MaLichLamViec int
)
AS
BEGIN
    BEGIN TRY
        DELETE dbo.LichLamViec WHERE MaLichLamViec = @MaLichLamViec
    END TRY
    BEGIN CATCH
        DECLARE @err NVARCHAR(MAX)
		SELECT @err = N'Lỗi' + ERROR_MESSAGE()
		RAISERROR(@err, 16, 1)
    END CATCH;
END;

GO

-- Get lịch làm việc
CREATE PROCEDURE SP_Get_Schedule
(
	@NgayDauTuan date = NULL,
	@NgayCuoiTuan date = NULL,
	@MaTaiKhoan int = NULL
)
AS
BEGIN
	SELECT * FROM VW_Schedule_List
	WHERE
		(@NgayDauTuan IS NULL OR NgayLam >= @NgayDauTuan) AND
		(@NgayCuoiTuan IS NULL OR NgayLam <= @NgayCuoiTuan)	AND
		(@MaTaiKhoan IS NULL OR MaTaiKhoan = @MaTaiKhoan)
END;

GO