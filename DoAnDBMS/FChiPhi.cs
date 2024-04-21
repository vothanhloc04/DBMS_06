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
    public partial class FChiPhi : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        public FChiPhi()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            double chiphitheothang;
            double chiphitheonam;

            if (cbbSelectionOption.Text == "Theo thang")
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT dbo.func_tinhTongChiPhiThang(@thang,@nam)", conn);
                    cmd.Parameters.AddWithValue("@thang", int.Parse(DateTime.Today.ToString("MM")));
                    cmd.Parameters.AddWithValue("@nam", int.Parse(DateTime.Today.ToString("yyyy")));
                    object result = cmd.ExecuteScalar();
                    if (result == DBNull.Value)
                    {
                         chiphitheothang = 0;
                    }
                    else
                    {
                         chiphitheothang = (double)result;
                    }
                    string chiphiString = chiphitheothang.ToString();
                    lblChiPhi.Text = chiphiString + " VND";
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Loi" +ex);
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
                    SqlCommand cmd = new SqlCommand("SELECT dbo.func_tinhTongChiPhiNam(@nam)", conn);
                    cmd.Parameters.AddWithValue("@nam", int.Parse(DateTime.Today.ToString("yyyy")));
                    object result = cmd.ExecuteScalar();
                    
                    if (result == DBNull.Value)
                    {
                        chiphitheonam = 0;
                    }
                    else
                    {
                        chiphitheonam = (double)result;
                    }
                    string chiphiString = chiphitheonam.ToString();
                    lblChiPhi.Text = chiphiString + " VND";
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
