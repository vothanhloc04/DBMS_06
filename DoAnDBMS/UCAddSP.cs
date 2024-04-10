using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDBMS
{
    public partial class UCAddSP : UserControl
    {
        DBConnection db = new DBConnection();
        string fileImage;
        public UCAddSP()
        {
            InitializeComponent();
        }

        private void ccbTenNhomSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ccbTenNhomSP.Text == "Lẩu")
            {
                tbMaNhomSP.Text = "LAU";
            }
            if (ccbTenNhomSP.Text == "Mì")
            {
                tbMaNhomSP.Text = "MI";
            }
            if (ccbTenNhomSP.Text == "Nước uống")
            {
                tbMaNhomSP.Text = "NUOC";
            }
        }

        private void pbImagePro_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = op.Filter = "JPG files (*.jpg)|*.jpg|All files (*.*)|*.*";
            op.FilterIndex = 1;
            op.RestoreDirectory = true;
            if (op.ShowDialog() == DialogResult.OK)
            {
                pbImagePro.ImageLocation = op.FileName;
                fileImage = op.FileName;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db.themSanPham(tbMaSP.Text, tbMaNhomSP.Text, tbTenSP.Text, ccbTenNhomSP.Text, (float)Convert.ToDouble(tbDonGia.Text), cbbTinhTrang.Text, convertImageToBytes());
        }

        private byte[] convertImageToBytes()
        {
            FileStream fs;
            fs = new FileStream(fileImage, FileMode.Open, FileAccess.Read);
            byte[] picByte = new byte[fs.Length];
            fs.Read(picByte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picByte;

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            db.xoaSanPham(tbMaSP.Text);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            db.suaSanPham(tbMaSP.Text, tbTenSP.Text, (float)Convert.ToDouble(tbDonGia.Text), cbbTinhTrang.Text, convertImageToBytes());
        }
    }
}
