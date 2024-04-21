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
    public partial class View_CaLamViec : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        DBConnection db = new DBConnection();
        public View_CaLamViec()
        {
            InitializeComponent();
        }
        private void displayDivision()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM v_dmCaLamViec", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            //current_DataGridView = 2;
            dataGridView1.DataSource = db.dmCaLamViec();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.dmCaLamViec();
        }
    }
}
