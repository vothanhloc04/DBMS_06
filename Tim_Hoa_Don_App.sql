CREATE PROCEDURE TimHoaDonApp
(
    @Ngay date
)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT CTDHUD.MaDHUD, CTDHUD.MaSP, CTDHUD.TrangThai, CTDHUD.SoLuong, CTDHUD.DonGia, CTDHUD.TongTien
    FROM ChiTietDonHangUngDung CTDHUD
    INNER JOIN DonHangUngDung DHUD ON DHUD.MaDHUD = CTDHUD.MaDHUD
    WHERE CONVERT(date, DHUD.NgayDatHang) = @Ngay;
END;
