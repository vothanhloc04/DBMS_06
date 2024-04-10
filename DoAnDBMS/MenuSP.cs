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
    public partial class MenuSP : UserControl
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        List<Product> menuPro = new List<Product>();
        string typeProduct = "";
        byte[] imageData;

        public MenuSP()
        {
            InitializeComponent();
        }

        private void getProduct()
        {
            menuPro.Clear();
            string sqlStr;

            if (typeProduct == "")
            {
                sqlStr = string.Format("Select * from SanPham");
            }
            else
            {
                sqlStr = string.Format("Select * from SanPham Where MaNhomSP = '{0}'", typeProduct);
            }

            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        Product p = new Product();
                        p.namePro = rdr.GetString(2);
                        imageData = (byte[])(rdr["HinhAnh"]);
                        p.imagePro = convertByteToImage(imageData);
                        if(rdr.GetString(4) == "Còn")
                        {
                            p.Price = rdr.GetDouble(3).ToString()+" VNĐ";
                        }
                        else
                        {
                            p.Price = rdr.GetString(4);
                        }
                        menuPro.Add(p);
                    }
                    rdr.Close();
                }
            }
            catch
            { }
            finally
            {
                conn.Close();
            }
        }

        private void MenuSP_Load(object sender, EventArgs e)
        {
            flpMenu.Controls.Clear();
            getProduct();
            foreach (Product p in menuPro)
            {
                flpMenu.Controls.Add(p);
            }
        }

        private void btnAllPro_Click(object sender, EventArgs e)
        {
            typeProduct = "";
            btnAllPro.BackColor = Color.Maroon;
            btnDinks.BackColor = Color.Firebrick;
            btnNoodles.BackColor = Color.Firebrick;
            btnHotpot.BackColor = Color.Firebrick;
            MenuSP_Load(sender, e);
        }

        private void btnNoodles_Click(object sender, EventArgs e)
        {
            typeProduct = "MI";
            btnAllPro.BackColor = Color.Firebrick;
            btnDinks.BackColor = Color.Firebrick;
            btnNoodles.BackColor = Color.Maroon;
            btnHotpot.BackColor = Color.Firebrick;
            MenuSP_Load(sender, e);
        }

        private void btnHotpot_Click(object sender, EventArgs e)
        {
            typeProduct = "LAU";
            btnAllPro.BackColor = Color.Firebrick;
            btnDinks.BackColor = Color.Firebrick;
            btnNoodles.BackColor = Color.Firebrick;
            btnHotpot.BackColor = Color.Maroon;
            MenuSP_Load(sender, e);
        }

        private void btnDinks_Click(object sender, EventArgs e)
        {
            typeProduct = "NUOC";
            btnAllPro.BackColor = Color.Firebrick;
            btnDinks.BackColor = Color.Maroon;
            btnNoodles.BackColor = Color.Firebrick;
            btnHotpot.BackColor = Color.Firebrick;
            MenuSP_Load(sender, e);
        }

        private Image convertByteToImage(byte[] byteArray)
        {
            if (byteArray != null)
            {
                MemoryStream ms = new MemoryStream(byteArray);
                Image returnIMG = Image.FromStream(ms);
                return returnIMG;
            }
            else
            {
                return null;
            }
        }
    }
}
