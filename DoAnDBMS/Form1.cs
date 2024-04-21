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
            View_CaLamViec f1 = new View_CaLamViec();
            f1.Show();
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FTestMenu fTestMenu = new FTestMenu();
            fTestMenu.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FTest fTest = new FTest();
            fTest.ShowDialog();
        }

        private void btnProfit_Click(object sender, EventArgs e)
        {
            FDoanhThu f = new FDoanhThu();
            f.ShowDialog();
        }

        private void btnChiPhi_Click(object sender, EventArgs e)
        {
            FChiPhi f = new FChiPhi();
            f.ShowDialog();
        }

        private void btnThemPhieuChi_Click(object sender, EventArgs e)
        {
            FThemPhieuChi f = new FThemPhieuChi();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FThemCaLam f = new FThemCaLam();
            f.Show();
        }

        private void btnCaLam_Click(object sender, EventArgs e)
        {
            FThemCaLam f = new FThemCaLam();
            f.Show();
        }
    }
}
