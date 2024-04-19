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
    public partial class UCHomeNV : UserControl
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        List<Product> menuPro = new List<Product>();
        string typeProduct = "";
        byte[] imageData;

        public UCHomeNV()
        {
            InitializeComponent();
        }

        private void UCHomeNV_Load(object sender, EventArgs e)
        {
            flpProduct.Controls.Clear();
            getProduct();
            foreach (Product p in menuPro)
            {
                flpProduct.Controls.Add(p);
            }
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
                        if (rdr.GetString(4) == "Còn")
                        {
                            p.Price = rdr.GetDouble(3).ToString() + " VNĐ";
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

        private void setColorBTN()
        {
            btnAll.BackColor = Color.White;
            btnType1.BackColor = Color.White;
            btnType2.BackColor = Color.White;
            btnType3.BackColor = Color.White;
            btnType4.BackColor = Color.White;
            btnType5.BackColor = Color.White;
            btnAll.BorderColor = Color.White;
            btnType1.BorderColor = Color.White;
            btnType2.BorderColor = Color.White;
            btnType3.BorderColor = Color.White;
            btnType4.BorderColor = Color.White;
            btnType5.BorderColor = Color.White;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            setColorBTN();
            btnAll.BorderColor = Color.DarkOrange;
            btnAll.BackColor = Color.FloralWhite;
            typeProduct = "";
            UCHomeNV_Load(sender, e);
        }

        private void btnType1_Click(object sender, EventArgs e)
        {
            setColorBTN();
            btnType1.BorderColor = Color.DarkOrange;
            btnType1.BackColor = Color.FloralWhite;
            typeProduct = "LAU";
            UCHomeNV_Load(sender, e);
        }

        private void btnType2_Click(object sender, EventArgs e)
        {
            setColorBTN();
            btnType2.BorderColor = Color.DarkOrange;
            btnType2.BackColor = Color.FloralWhite;
            typeProduct = "MI";
            UCHomeNV_Load(sender, e);
        }

        private void btnType3_Click(object sender, EventArgs e)
        {
            setColorBTN();
            btnType3.BorderColor = Color.DarkOrange;
            btnType3.BackColor = Color.FloralWhite;
            typeProduct = "LAU";
            UCHomeNV_Load(sender, e);
        }

        private void btnType4_Click(object sender, EventArgs e)
        {
            setColorBTN();
            btnType4.BorderColor = Color.DarkOrange;
            btnType4.BackColor = Color.FloralWhite;
            typeProduct = "NUOC";
            UCHomeNV_Load(sender, e);
        }

        private void btnType5_Click(object sender, EventArgs e)
        {
            setColorBTN();
            btnType5.BorderColor = Color.DarkOrange;
            btnType5.BackColor = Color.FloralWhite;
            typeProduct = "";
            UCHomeNV_Load(sender, e);
        }
    }
}
