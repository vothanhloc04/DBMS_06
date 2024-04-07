using System.Data.SqlClient;

namespace DoAnDBMS
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnViewPhanCong_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.dmPhanCong();
        }

        private void btnViewCLV_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.dmCaLamViec();
        }

        private void btnViewSP_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.dmSanPham();
        }

        private void btnViewNSX_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.dmNSX();
        }

        private void btnViewPC_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.dmPhieuChi();
        }

        private void btnViewHoaDon_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.dmHoaDon();
        }

        private void btnHoaDonUD_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.dmHoaDonUD();
        }

        private void btnTimNL_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.timNguyenLieu("");
        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.timSanPham("");
        }

        private void btnViewNV_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.dmNhanVien();
        }
    }
}
