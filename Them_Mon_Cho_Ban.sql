USE DoAnDBMS
GO

DROP PROCEDURE IF EXISTS ThemMonVaoBan;
GO

CREATE PROCEDURE ThemMonVaoBan
    @MaBan nchar(10),
    @MaSP nchar(10),
    @SoLuong int
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT 0 FROM Ban WHERE MaBan = @MaBan)
    BEGIN
        RETURN;
    END;

    DECLARE @MaDH nchar(10);
    SELECT @MaDH = MaDH FROM DonHang WHERE MaBan = @MaBan;

    IF @MaDH IS NULL
    BEGIN
        INSERT INTO DonHang (MaBan) VALUES (@MaBan);
        SELECT @MaDH = SCOPE_IDENTITY();
    END;

    DECLARE @SoLuongHienTai int;
    SELECT @SoLuongHienTai = ISNULL(SoLuong, 0) FROM ChiTietDonHang WHERE MaDH = @MaDH AND MaSP = @MaSP;

    IF @SoLuongHienTai > 0
    BEGIN
        UPDATE ChiTietDonHang SET SoLuong = @SoLuongHienTai + @SoLuong WHERE MaDH = @MaDH AND MaSP = @MaSP;
    END
    ELSE
    BEGIN
        -- Nếu chưa tồn tại, thêm mới
        INSERT INTO ChiTietDonHang (MaDH, MaSP, SoLuong) VALUES (@MaDH, @MaSP, @SoLuong);
    END;

    -- Cập nhật trạng thái của bàn
    UPDATE Ban SET TinhTrang = 'Có khách' WHERE MaBan = @MaBan;

    -- Cập nhật tổng tiền
    UPDATE ChiTietDonHang
    SET TongTien = SoLuong * DonGia
    WHERE MaDH = @MaDH AND MaSP = @MaSP;
END;
