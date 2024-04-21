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
    public partial class FDoanhThu : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        public FDoanhThu()
        {
            InitializeComponent();
        }

        private void btnConfirmDate_Click(object sender, EventArgs e)
        {
            if (cbbSelectionOption.Text == "Theo ngay")
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT dbo.func_tinhDoanhThuNgay(@ngay, @thang,@nam)", conn);
                    cmd.Parameters.AddWithValue("@ngay", int.Parse(DateTime.Today.ToString("dd")));
                    cmd.Parameters.AddWithValue("@thang", int.Parse(DateTime.Today.ToString("MM")));
                    cmd.Parameters.AddWithValue("@nam", int.Parse(DateTime.Today.ToString("yyyy")));
                    object result = cmd.ExecuteScalar();
                    double doanhthutheongay = (double)result;
                    string doanhthuString = doanhthutheongay.ToString();
                    lblProfit.Text = doanhthuString + " VND";
                }
                catch
                {
                    MessageBox.Show("Loi");
                }
                finally
                {
                    conn.Close();
                }
            }
            if (cbbSelectionOption.Text == "Theo thang")
             {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT dbo.func_tinhDoanhThuThang(@ngay, @thang,@nam)", conn);
                    cmd.Parameters.AddWithValue("@ngay", int.Parse(DateTime.Today.ToString("dd")));
                    cmd.Parameters.AddWithValue("@thang", int.Parse(DateTime.Today.ToString("MM")));
                    cmd.Parameters.AddWithValue("@nam", int.Parse(DateTime.Today.ToString("yyyy")));
                    object result = cmd.ExecuteScalar();
                    double doanhthutheothang = (double)result;
                    string doanhthuString = doanhthutheothang.ToString();
                    lblProfit.Text = doanhthuString + " VND";
                }
                catch
                {
                    MessageBox.Show("Loi");
                }
                finally
                {
                    conn.Close();
                }
            }
            if (cbbSelectionOption.Text == "Theo nam")
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT dbo.func_tinhDoanhThuThang(@ngay, @thang,@nam)", conn);
                    cmd.Parameters.AddWithValue("@ngay", int.Parse(DateTime.Today.ToString("dd")));
                    cmd.Parameters.AddWithValue("@thang", int.Parse(DateTime.Today.ToString("MM")));
                    cmd.Parameters.AddWithValue("@nam", int.Parse(DateTime.Today.ToString("yyyy")));
                    object result = cmd.ExecuteScalar();
                    double doanhthutheonam = (double)result;
                    string doanhthuString = doanhthutheonam.ToString();
                    lblProfit.Text = doanhthuString + " VND";
                }
                catch
                {
                    MessageBox.Show("Loi");
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
 }