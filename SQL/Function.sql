/*** Hàm lấy số lượng sách đang hiện hữu (Phat)***/
CREATE FUNCTION FN_Total_Available_Books()
RETURNS TABLE
AS
RETURN (
	SELECT SUM(SoLuong) AS Total_Available 
	FROM dbo.Sach
);

GO
CREATE FUNCTION FN_Total_Damaged_Or_Lost_Books()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Damaged_Or_Lost 
	FROM dbo.CuonSach
	WHERE TinhTrang = N'Đã trả'
);

GO
/*** Hàm lấy số lượng sách Borrowing (Phat)***/
CREATE FUNCTION FN_Total_Borrowed_Books()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Borrowed 
	FROM dbo.CuonSach
	WHERE TinhTrang = N'Đang mượn'
);

GO

/*** Hàm lấy số lượng tất cả sách (Phat)***/
CREATE FUNCTION FN_Total_Books()
RETURNS TABLE
AS
RETURN (
	SELECT 
    (SELECT SUM(Total_Available) FROM FN_Total_Available_Books())  AS Total_All
);

GO
/*** Hàm lấy số lượng tất cả tác giả (Phat)***/
CREATE FUNCTION FN_Total_Authors()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Authors
	FROM dbo.TacGia
);

GO
/*** Hàm lấy số lượng tất cả nhà xuất bản (Phat)***/
CREATE FUNCTION FN_Total_Publishers()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Publishers
	FROM dbo.NhaXuatBan
);

GO
/*** Hàm lấy số lượng tất cả thể loại (Phat)***/
CREATE FUNCTION FN_Total_Categories()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Categories
	FROM dbo.TheLoai
);

GO
/*** Hàm lấy số lượng tất cả phiếu mượn (Phat)***/
CREATE FUNCTION FN_Total_Loan_Coupons_By_Month
(
    @month int,
    @year int
)
RETURNS TABLE
AS
RETURN (
    SELECT 
        COUNT(*) AS Total_Loan_Coupons
    FROM 
        dbo.PhieuMuonSach
    WHERE 
        MONTH(NgayMuon) = @month AND YEAR(NgayMuon) = @year
);
GO
/*** Hàm lấy số lượng tất cả tài khoản (Phat)***/
CREATE FUNCTION FN_Total_Accounts()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Accounts
	FROM dbo.TaiKhoan
);

GO
/*** Hàm lấy số lượng tất cả tài khoản sinh viên CLC(Phat)***/
CREATE FUNCTION FN_Total_High_Quality_Student_Accounts()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_High_Quality_Student_Accounts
	FROM dbo.TaiKhoan
	WHERE VaiTro = N'Sinh viên CLC'
);

GO


/*** Hàm lấy số lượng tất cả tài khoản sinh viên đại trà(Phat)***/
CREATE FUNCTION FN_Total_Mass_Student_Accounts()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Mass_Student_Accounts
	FROM dbo.TaiKhoan
	WHERE VaiTro = N'DocGia'
);

GO
/*** Hàm lấy số lượng tất cả Học viên cao học (Phat)***/
CREATE FUNCTION FN_Total_Graduate_Student_Accounts()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Graduate_Student_Accounts
	FROM dbo.TaiKhoan
	WHERE VaiTro = N'Học viên cao học'
);

GO
/*** Hàm lấy số lượng tất cả tài khoản Giảng viên (Phat)***/
CREATE FUNCTION FN_Total_Lecturer_Accounts()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Lecturer_Accounts
	FROM dbo.TaiKhoan
	WHERE VaiTro = N'Giảng viên'
);

GO


/*** Hàm lấy số lượng tất cả tài khoản Thủ thư (Phat)***/
CREATE FUNCTION FN_Total_Librarian_Accounts()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Librarian_Accounts
	FROM dbo.TaiKhoan
	WHERE VaiTro = N'ThuThu'
);

GO
/*** Hàm lấy số lượng tất cả tài khoản Quản trị viên (Phat)***/
CREATE FUNCTION FN_Total_Administrator_Accounts()
RETURNS TABLE
AS
RETURN (
	SELECT COUNT(*) AS Total_Administrator_Accounts
	FROM dbo.TaiKhoan
	WHERE VaiTro = N'QuanTriVien'
);

GO

GO
/*** Get reader borrowed coupon list (Phat)***/
CREATE FUNCTION FN_Reader_Borrowed_List
(
    @MaTaiKhoan int,
    @Type int -- 0: All, 1: Not Returned, 2: Returned
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        MaPhieuMuon AS N'Mã phiếu mượn',
        NgayMuon AS N'Ngày mượn',
        NgayTra AS N'Ngày trả sách'
    FROM dbo.PhieuMuonSach
    WHERE 
        MaTaiKhoan = @MaTaiKhoan AND
        ((@Type = 0) OR
         (@Type = 1 AND NgayTra IS NULL) OR
         (@Type = 2 AND NgayTra IS NOT NULL))
);

GO
/*** Get Librarian Total Working hours in week (Phat)***/
CREATE FUNCTION FN_Total_Working_Hours
(
	@MaTaiKhoan INT,
    @NgayLam DATE
)
RETURNS INT
AS
BEGIN
	DECLARE @WeekStart DATE;
    DECLARE @WeekEnd DATE;
    DECLARE @TotalShifts INT;

    SET @WeekStart = DATEADD(DAY, 2 - DATEPART(WEEKDAY, @NgayLam), @NgayLam);
    SET @WeekEnd = DATEADD(DAY, 8 - DATEPART(WEEKDAY, @NgayLam), @NgayLam);

	SELECT @TotalShifts = COUNT(*)
    FROM dbo.LichLamViec
    WHERE NgayLam BETWEEN @WeekStart AND @WeekEnd
      AND MaTaiKhoan = @MaTaiKhoan;

	RETURN @TotalShifts*4
END;

GO


	

		


