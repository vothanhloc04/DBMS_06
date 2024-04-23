CREATE PROCEDURE TimHoaDon
(
    @Ngay date
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT CTDH.MaDH, CTDH.MaSP, CTDH.TrangThai, CTDH.SoLuong, CTDH.DonGia, CTDH.TongTien
    FROM ChiTietDonHang CTDH
    INNER JOIN DonHang DH ON DH.MaDH = CTDH.MaDH
    WHERE CONVERT(date, DH.NgayPhucVu) = @Ngay;
END;
