using System.Data.SqlClient;

namespace DoAnDBMS
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();

        int count = 1;

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

        private void btnSearchInvoice_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.TimHoaDon(dateTimePicker1.Value);
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            count += 1;
            lblQuantity.Text = count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (count > 1)
            {
                count -= 1;
            }
            else
            {
                MessageBox.Show("Không thể giảm nữa");
            }
            lblQuantity.Text = count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(count.ToString());
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            db.ThemMonVaoBan(txtTableID.Text, txtProdID.Text, count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ProdDetails();
        }

        private void btnExportInvoice_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.XuatHoaDon(txtTableID.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.ProdAppDetails();
        }

        private void btnExptAppInvoice_Click(object sensder, EventArgs e)
        {
            dataGridView1.DataSource = db.XuatHoaDonApp(txtProdID.Text);
        }
    }
}
