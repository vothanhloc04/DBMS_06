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
    public partial class FThemCaLam : Form
    {

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        public FThemCaLam()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("EXEC proc_PhanCa @maca, @manv, @dayOfWeek", conn);
            cmd.Parameters.Add("@maca", SqlDbType.NChar, 10).Value = txtMaCa.Text;
            cmd.Parameters.Add("@manv", SqlDbType.NChar, 10).Value = txtMaNV.Text;
            cmd.Parameters.Add("@dayOfWeek", SqlDbType.Date).Value = dtpDayofWeek.Value.Date;
            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Phân ca thành công!");
            }
            catch (SqlException Ex)
            {
                conn.Close();
                MessageBox.Show("Phân ca thất bại!Lỗi: " + Ex.Message);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            {
                SqlCommand cmd = new SqlCommand("EXEC proc_XoaPhanCa  @manv, @maca, @dayOfWeek", conn);
                cmd.Parameters.Add("@maca", SqlDbType.NChar, 10).Value = txtMaCa.Text;
                cmd.Parameters.Add("@manv", SqlDbType.NChar, 10).Value = txtMaNV.Text;
                cmd.Parameters.Add("@dayOfWeek", SqlDbType.Date).Value = dtpDayofWeek.Value.Date;
                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Xóa thành công!");
                }
                catch (SqlException Ex)
                {
                    conn.Close();
                    MessageBox.Show("Xóa thất bại!Lỗi: " + Ex.Message);
                }

            }
        }
    }
}
