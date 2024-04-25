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
                string sqlStr = "Select TenNhomSP as 'Nhóm món', MaSP as 'Mã món', TenSP as 'Tên món', DonGia as 'Giá', TinhTrang as 'Tình trạng' From v_dmSanPham";
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

        //3.1
        public string TimKiemKhachHang(string SDT)
        {
            string? TenKH = null;

            try
            {
                conn.Open();
                string sqlStr = "SELECT TenKH FROM KhachHang WHERE SDT = @SDT";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@SDT", SDT);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        TenKH = reader.GetString(0);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }

            return TenKH;
        }

        //3.2
        public void ThemMoiKhachHang(string MaKH, string TenKH, string SDT)
        {
            try
            {
                conn.Open();

                // Check if SDT already exists in KhachHang table
                string checkSDTExistsSql = "SELECT COUNT(*) FROM KhachHang WHERE SDT = @SDT";
                SqlCommand checkSDTExistsCmd = new SqlCommand(checkSDTExistsSql, conn);
                checkSDTExistsCmd.Parameters.AddWithValue("@SDT", SDT);

                int sdtCount = (int)checkSDTExistsCmd.ExecuteScalar();

                if (sdtCount > 0)
                {
                    MessageBox.Show("So dien thoai da ton tai");
                    return;
                }

                // Insert new customer if SDT doesn't exist
                string insertCustomerSql = "INSERT INTO KhachHang (MaKH, TenKH, SDT, DiemTV) VALUES (@MaKH, @TenKH, @SDT, 0)";
                SqlCommand insertCustomerCmd = new SqlCommand(insertCustomerSql, conn);
                insertCustomerCmd.Parameters.AddWithValue("@MaKH", MaKH);
                insertCustomerCmd.Parameters.AddWithValue("@TenKH", TenKH);
                insertCustomerCmd.Parameters.AddWithValue("@SDT", SDT);

                if (insertCustomerCmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Them khach hang thanh cong");
                }
                else
                {
                    MessageBox.Show("Them khach hang that bai");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
        }

        //4.1
        //Tim theo MaNV
        public DataTable TimNhanVienTheoMa(string MaNV)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = "EXEC dbo.pro_SearchByMaNV @MaNV";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //Tim theo SDT
        public DataTable TimNhanVienTheoSDT(string SDT)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = "EXEC dbo.pro_SearchBySDT @SDT";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@SDT", SDT);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //Tim theo Ten
        public DataTable TimNhanVienTheoTen(string TenNV)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = "EXEC dbo.pro_SearchByTenNV @TenNV";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@TenNV", TenNV);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //Tim theo TenCV
        public DataTable TimNhanVienTheoCongViec(string TenCV)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = "SELECT nv.HoTen, nv.TenCV, cv.MoTa FROM NhanVien nv INNER JOIN CongViec cv ON nv.MaCV = cv.MaCV WHERE cv.TenCV = @TenCV";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@TenCV", TenCV);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception)
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //4.2
        public void ThemNhanVien(string MaNV, string HoTen, DateTime NgaySinh, string GioiTinh, string DiaChi, string SDT, string MaCV, int Thuong, DateTime NgayBatDauLam, byte[] HinhAnh)
        {
            try
            {
                conn.Open();

                string sqlStr = "EXEC ThemNhanVien @MaNV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @MaCV, @Thuong, @NgayBatDauLam, @HinhAnh";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);

                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                cmd.Parameters.AddWithValue("@HoTen", HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                cmd.Parameters.AddWithValue("@SDT", SDT);
                cmd.Parameters.AddWithValue("@MaCV", MaCV);
                cmd.Parameters.AddWithValue("@Thuong", Thuong);
                cmd.Parameters.AddWithValue("@NgayBatDauLam", NgayBatDauLam);
                cmd.Parameters.AddWithValue("@HinhAnh", HinhAnh);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm nhân viên thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //4.3
        public bool XoaNhanVien(int MaNV)
        {
            bool result = false;
            try
            {
                conn.Open();

                string sqlStr = "EXEC XoaNhanVien @MaNV";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                cmd.Parameters.AddWithValue("@MaNV", MaNV);

                int rowsAffected = cmd.ExecuteNonQuery();
                result = rowsAffected > 0; // Check if any rows were affected

                if (result)
                {
                    MessageBox.Show("Xoa nhan vien thanh cong");
                }
                else
                {
                    MessageBox.Show("Xoa nhan vien that bai");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }

            return result;
        }

        //4.4
        public bool SuaThongTinNhanVien(string MaNV, string HoTen, DateTime NgaySinh, string GioiTinh, string DiaChi, string SDT, string MaCV, int Thuong, DateTime NgayBatDauLam, byte[] HinhAnh)
        {
            bool result = false;
            try
            {
                conn.Open();

                string sqlStr = "EXEC SuaThongTinNhanVien @MaNV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SDT, @MaCV, @Thuong, @NgayBatDauLam, @HinhAnh";
                SqlCommand cmd = new SqlCommand(sqlStr, conn);

                cmd.Parameters.AddWithValue("@MaNV", MaNV);
                cmd.Parameters.AddWithValue("@HoTen", HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                cmd.Parameters.AddWithValue("@DiaChi", DiaChi);
                cmd.Parameters.AddWithValue("@SDT", SDT);
                cmd.Parameters.AddWithValue("@MaCV", MaCV);
                cmd.Parameters.AddWithValue("@Thuong", Thuong);
                cmd.Parameters.AddWithValue("@NgayBatDauLam", NgayBatDauLam);
                cmd.Parameters.AddWithValue("@HinhAnh", HinhAnh);

                int rowsAffected = cmd.ExecuteNonQuery();
                result = rowsAffected > 0; // Check if any rows were affected

                if (result)
                {
                    MessageBox.Show("Sua thong tin nhan vien thanh cong");
                }
                else
                {
                    MessageBox.Show("Sua thong tin nhan vien that bai");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Loi");
            }
            finally
            {
                conn.Close();
            }

            return result;
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

        // Tim hoa don
        public DataTable TimHoaDon(DateTime ngay)
        {
            DataTable dt = new DataTable();

            try
            { 
                conn.Open();

                SqlCommand cmd = new SqlCommand("TimHoaDon", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ngay", ngay);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            return dt;
        }

        // Thêm món ăn
        public void ThemMonVaoBan(string maBan, string maSP, int soLuong)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("ThemMonVaoBan", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaBan", maBan);
                cmd.Parameters.AddWithValue("@MaSP", maSP);
                cmd.Parameters.AddWithValue("@SoLuong", soLuong);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm món vào bàn thành công");
                }
                else
                {
                    MessageBox.Show("Thêm món vào bàn thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable ProdDetails()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select * From ChiTietDonHang");
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

        public DataTable ProdAppDetails()
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string sqlStr = string.Format("Select * From ChiTietDonHangUngDung");
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

        // Xuat Hoa don

        public DataTable XuatHoaDon(string maBan)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("XuatHoaDon", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaBan", maBan);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable XuatHoaDonApp(string maDH)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("XuatHoaDonUngDung", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaDHUD", maDH);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
