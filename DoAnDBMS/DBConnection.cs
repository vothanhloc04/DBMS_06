using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAnDBMS
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        
        //2.1
        public DataTable dmNhanVien()
        {
            DataTable dt = new DataTable();
            try 
            { 
                conn.Open();
                string sqlStr = "Select * From v_dmNhanVien";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            } 
            catch 
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        //2.2
        public DataTable dmPhanCong()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = "Select * From v_dmPhanCong";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        //2.3
        public DataTable dmCaLamViec()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = "Select * From v_dmCaLamViec";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        //2.4
        public DataTable dmSanPham()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = "Select * From v_dmSanPham";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        //2.5
        public DataTable dmNSX()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = "Select * From v_dmNSX";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        //2.6
        public DataTable dmPhieuChi()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = "Select * From v_dmPhieuChi";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        //2.7
        public DataTable dmHoaDon()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = "Select * From v_dmHoaDon";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        //2.8
        public DataTable dmHoaDonUD()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = "Select * From v_dmHoaDonUD";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        //6.1
        public DataTable timNguyenLieu(string str)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select * From func_TimNguyenLieu('{0}')", str);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //6.2
        public void themNguyenLieu(string MaNL, string TenNL, string MaNSX, int SoLuong)
        {
            try
            {
                conn.Open();
                string sqlStr = "proc_ThemNguyenLieu";
                SqlCommand cmd = new SqlCommand( sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaNL", SqlDbType.NChar).Value = MaNL;
                cmd.Parameters.Add("@TenNL", SqlDbType.NVarChar).Value = TenNL;
                cmd.Parameters.Add("@MaNSX", SqlDbType.NChar).Value = MaNSX;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = SoLuong;
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

        //7.1
        public void themSanPham(string MaSP, string MaNhomSP, string TenSP, string TenNhomSP, float DonGia, string TinhTrang, byte[] HinhAnh)
        {
            try
            {
                conn.Open();
                string sqlStr = "proc_themSanPhamMoi";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaSP", SqlDbType.NChar).Value = MaSP;
                cmd.Parameters.Add("@MaNhomSP", SqlDbType.NChar).Value = MaNhomSP;
                cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar).Value = TenSP;
                cmd.Parameters.Add("@TenNhomSP", SqlDbType.NVarChar).Value = TenNhomSP;
                cmd.Parameters.Add("@DonGia", SqlDbType.Float).Value = DonGia;
                cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = TinhTrang;
                cmd.Parameters.Add("@HinhAnh", SqlDbType.Binary).Value = HinhAnh;
                if(cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Luu thanh cong");
                }
                else
                {
                    MessageBox.Show("That bai");
                }
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

        //7.2
        public void suaSanPham(string MaSP, string TenSP, float DonGia, string TinhTrang, byte[] HinhAnh)
        {
            try
            {
                conn.Open();
                string sqlStr = "proc_SuaSanPham";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaSP", SqlDbType.NChar).Value = MaSP;
                cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar).Value = TenSP;
                cmd.Parameters.Add("@DonGia", SqlDbType.Float).Value = DonGia;
                cmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = TinhTrang;
                cmd.Parameters.Add("@HinhAnh", SqlDbType.Binary).Value = HinhAnh;
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Luu thanh cong");
                }
                else
                {
                    MessageBox.Show("That bai");
                }
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

        //7.3 
        public void xoaSanPham(string MaSP)
        {
            try
            {
                conn.Open();
                string sqlStr = "proc_XoaSanPham";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaSP", SqlDbType.NChar).Value = MaSP;

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Xoa thanh cong");
                }
                else
                {
                    MessageBox.Show("That bai");
                }
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

        //7.4
        public DataTable timSanPham(string str)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select * From func_TimSP('{0}')", str);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
