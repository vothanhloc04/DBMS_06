using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDBMS
{
    public partial class FThemPhieuChi : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        public FThemPhieuChi()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            /* Đang thắc mắc về tên hàng hóa, số lượng, đơn giá khi nhập về
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("proc_InsertDonNhapHangAndPhieuChiAndChiTietNhapHang", conn);

                //Them vao Don Nhap Hang
                cmd.Parameters.AddWithValue("@MaDonNH", txtMadonNH.Text);
                cmd.Parameters.AddWithValue("@NgayNH", dateNgayNH.Value);
                //cmd.Parameters.AddWithValue("@MaNL", txtMaNL.Text);
                cmd.Parameters.AddWithValue("@TriGiaDonNH", float.Parse(txtTongTien.Text));


                //Them vao Phieu Chi
                cmd.Parameters.AddWithValue("@MaPhieuChi", txtMaPhieuChi.Text);
                cmd.Parameters.AddWithValue("@NgayXuatPhieu", dateNgayxuatPhieu.Value);
                cmd.Parameters.AddWithValue("@SoTienChi", float.Parse(txtTienchi.Text));

                //Them vao Chi tiet Don Hang
                cmd.Parameters.AddWithValue("@MaSP", txtMaSP.Text);
                cmd.Parameters.AddWithValue("@TinhTrang", "Dang giao");
                cmd.Parameters.AddWithValue("@SoLuong", int.Parse(txtSoLuong.Text));
                cmd.Parameters.AddWithValue("@DonGia", float.Parse(txtDonGia.Text));
                cmd.Parameters.AddWithValue("@TongTien", float.Parse(txtTongTien.Text));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex);
            }
            finally
            {
                conn.Close();
            }
            */
        }
    }
}
