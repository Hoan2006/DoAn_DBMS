SELECT 
    t.name AS TriggerName,
    t.is_disabled AS IsDisabled,
    o.name AS TableName,
    t.create_date AS CreateDate,
    t.modify_date AS ModifyDate
FROM 
    sys.triggers t
INNER JOIN 
    sys.objects o ON t.parent_id = o.object_id
WHERE 
    t.is_ms_shipped = 0; -- Exclude system triggers

-- Xem Role + xem Trigger
SELECT 
    m.name AS RoleName,
    u.name AS UserName
FROM sys.database_role_members drm
JOIN sys.database_principals u ON drm.member_principal_id = u.principal_id
JOIN sys.database_principals m ON drm.role_principal_id = m.principal_id
ORDER BY u.name, m.name;



GO
SELECT 
    name AS TriggerName,
    object_id,
    parent_class_desc AS TriggerScope,
    type_desc AS TriggerType,
    create_date,
    modify_date,
    is_disabled
FROM sys.triggers;
GO

-- Trigger xoa Tac gia
CREATE TRIGGER TR_Prevent_Delete_TacGia
ON TacGia
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem có sách nào trong bảng Sach có MaTacGia trùng với MaTacGia bị xóa không
    IF EXISTS (
        SELECT 1
        FROM Sach s
        INNER JOIN deleted d ON s.MaTacGia = d.MaTacGia
        WHERE s.MaTacGia IS NOT NULL
    )
    BEGIN
        RAISERROR('Không thể xóa tác giả vì còn tồn tại sách thuộc tác giả này.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END;
GO


-- Trigger xoa The Loai
CREATE TRIGGER TR_Instead_Delete_TheLoai
ON TheLoai
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM Sach s
        INNER JOIN deleted d ON s.MaTheLoai = d.MaTheLoai
        WHERE s.MaTheLoai IS NOT NULL
    )
    BEGIN
        RAISERROR('Không thể xóa thể loại vì còn tồn tại sách thuộc thể loại này.', 16, 1);
        RETURN;
    END
    ELSE
    BEGIN
        -- Nếu không có sách tham chiếu, tiến hành xóa
        DELETE FROM TheLoai
        WHERE MaTheLoai IN (SELECT MaTheLoai FROM deleted);
    END
END;
GO


-- Trigger xoa NXB
CREATE TRIGGER TR_Prevent_Delete_NXB
ON NhaXuatBan
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Kiểm tra xem có sách nào trong bảng Sach có MaNhaXuatBan trùng với MaNhaXuatBan bị xóa không
    IF EXISTS (
        SELECT 1
        FROM Sach s
        INNER JOIN deleted d ON s.MaNhaXuatBan = d.MaNhaXuatBan
        WHERE s.MaNhaXuatBan IS NOT NULL
    )
    BEGIN
        RAISERROR('Không thể xóa nhà xuất bản vì còn tồn tại sách thuộc nhà xuất bản này.', 16, 1);
        ROLLBACK TRANSACTION;
        RETURN;
    END
END;

GO
/***	Not duplicate phone number (Phat)		***/
CREATE TRIGGER TR_Not_Duplicate_Phone_Number
ON TaiKhoan
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS
	(
		SELECT * FROM inserted i
		WHERE EXISTS(	SELECT * FROM dbo.TaiKhoan TK 
						WHERE	(TK.SoDienThoai = i.SoDienThoai) 
						AND		(TK.MaTaiKhoan <> i.MaTaiKhoan)
					)
	) 
    BEGIN
		RAISERROR ('Duplicate phone number is not allowed', 16, 1);
        ROLLBACK TRANSACTION;
	END
END;

GO

/***	Update book quantity if borrowed (Phat)		***/
CREATE TRIGGER TR_Not_Update_Books_Quantity_After_Borrowed
ON dbo.CuonSach
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @MaPhieuMuon INT;

    SELECT @MaPhieuMuon = MaPhieuMuon FROM inserted;

    UPDATE S
    SET S.SoLuong = S.SoLuong - 1
    FROM dbo.CuonSach CS
    JOIN dbo.Sach S ON CS.MaSach = S.MaSach
    WHERE CS.MaPhieuMuon = @MaPhieuMuon;
END;

GO
/* Trigger không cho tạo, cập nhật thể loại trùng*/
CREATE TRIGGER TR_Prevent_duplicate_category 
ON TheLoai
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM TheLoai t
        JOIN INSERTED i ON t.TenTheLoai = i.TenTheLoai WHERE t.MaTheLoai<>i.MaTheLoai
    )
    BEGIN
        RAISERROR('Không thể thêm hoặc cập nhật vì đã tồn tại thể loại có cùng tên.', 16, 1);
        ROLLBACK TRANSACTION;
    END;
END; 

GO 

GO
/* Trigger không cho tạo, cập nhật sách trùng*/
CREATE TRIGGER TR_Prevent_duplicate_Book
ON dbo.Sach
AFTER INSERT, UPDATE
AS
BEGIN
	IF EXISTS (
	SELECT 1 
	FROM Sach S 
	JOIN inserted i 
	ON S.MaTacGia = i.MaTacGia 
	WHERE	S.TenSach = i.TenSach AND
			S.MaTacGia = i.MaTacGia AND
			S.MaTheLoai = i.MaTheLoai AND
			S.MaNhaXuatBan = i.MaNhaXuatBan AND
			S.LoaiTaiLieu = i.LoaiTaiLieu AND
			S.NamXuatBan = i.NamXuatBan AND
			S.GiaSach = i.GiaSach AND
			S.MaSach<>i.MaSach)
	BEGIN
		RAISERROR('Không tạo trùng tựa sách', 16, 1);
		ROLLBACK TRANSACTION;
	END;
END;

GO
/* Trigger không cho tạo, cập nhật tác giả trùng (Phat)*/
CREATE TRIGGER TR_Prevent_duplicate_Author
ON dbo.TacGia
AFTER INSERT, UPDATE
AS
BEGIN
    IF EXISTS (SELECT 1 FROM TacGia TG JOIN inserted i ON TG.TenTacGia = i.TenTacGia AND TG.MaTacGia <> i.MaTacGia)
    BEGIN
        -- Hủy thao tác INSERT hoặc UPDATE nếu dữ liệu bị trùng
        ROLLBACK TRANSACTION;
        RAISERROR('Không thể thêm tác giả trùng tên!', 16, 1);
    END
END

GO
--Trigger Check Duplicates_NXB(Trung)--
CREATE OR ALTER TRIGGER TR_Prevent_Publisher_Duplicate
ON dbo.NhaXuatBan
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
         SELECT i.TenNhaXuatBan
         FROM inserted i
         WHERE (SELECT COUNT(*) FROM dbo.NhaXuatBan p 
                WHERE p.TenNhaXuatBan = i.TenNhaXuatBan) > 1
    )
    BEGIN
        RAISERROR('Không được trùng tên nhà xuất bản.', 16, 1);
        ROLLBACK TRANSACTION;
    END;
END;

GO
---triger giảm sl sách khi mượn sách thành công
CREATE TRIGGER trg_GiamSoLuongSach
ON CuonSach
AFTER INSERT
AS
BEGIN
    -- Giảm 1 số lượng sách trong bảng Sach sau khi thêm phiếu mượn
    DECLARE @MaSach INT;
    
    -- Lấy mã sách từ bảng CuonSach (vì trigger là sau khi INSERT vào CuonSach)
    SELECT @MaSach = MaSach FROM INSERTED;

    -- Cập nhật số lượng sách trong bảng Sach
    UPDATE Sach
    SET SoLuong = SoLuong - 1
    WHERE MaSach = @MaSach;

    PRINT 'Số lượng sách đã được cập nhật sau khi mượn.';
END;

GO

-- Trigger khong cho trung ngay
CREATE TRIGGER TR_Not_Duplicate_Working_Days
ON dbo.LichLamViec
AFTER INSERT, UPDATE
AS
BEGIN
    DECLARE @MaTaiKhoan INT;
    DECLARE @MaLichLamViec INT;
    DECLARE @NgayLam Date;
    DECLARE @Ca NVARCHAR(255);

    SELECT @MaTaiKhoan = MaTaiKhoan, @NgayLam = NgayLam, @Ca = Ca, @MaLichLamViec = MaLichLamViec FROM inserted;
    
    IF EXISTS (
        SELECT 1 FROM dbo.LichLamViec
        WHERE MaTaiKhoan = @MaTaiKhoan AND NgayLam = @NgayLam AND Ca = @Ca AND @MaLichLamViec <> MaLichLamViec
    )
    BEGIN
        RAISERROR ('A working day can not be duplicate.', 16, 1);
    END
END;
GO

