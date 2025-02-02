﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NHOM8_QLHSUT.LAYER3_DAL
{
    public class DataAccess
    {
        private static string _connString = "";
        private static SqlConnection _conn = new SqlConnection();

        public static bool Connect()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "(local)";
                builder.InitialCatalog = "QLHOSOUNGTUYEN";
                builder.IntegratedSecurity = true;

                _connString = builder.ConnectionString;
                _conn = new SqlConnection(_connString);
                _conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối với cơ sở dữ liệu thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static DataTable LayThongTinDangTuyen()
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT MaDT, ThongTinYeuCau, SLTuyenDung, ViTriTuyenDung, MADN FROM THONGTINDANGTUYEN";
                SqlDataAdapter sda = new SqlDataAdapter(query, _conn);
                sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static bool ThemUngVien(string mauv, string hoten, string ngaysinh, string diachi, string sdt, string email, string manv)
        {
            try
            {
                string query = "INSERT INTO UNGVIEN(MaUV, HoTen, NgaySinh, DiaChi, SoDienThoai, MaNV) " +
                    "VALUES (@MAUV, @HOTEN, @NGAYSINH, @DIACHI, @SDT, @MANV)";
                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@MAUV", mauv);
                cmd.Parameters.AddWithValue("@HOTEN", hoten);
                cmd.Parameters.AddWithValue("@NGAYSINH", ngaysinh);
                cmd.Parameters.AddWithValue("@DIACHI", diachi);
                cmd.Parameters.AddWithValue("@SDT", sdt);
                cmd.Parameters.AddWithValue("@MANV", manv);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.ToString());
                return false;
            } 
        }

        public static DataTable LayThongTinUngVien()
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM UNGVIEN";
                SqlDataAdapter sda = new SqlDataAdapter(query, _conn);
                sda.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public static bool ThemPhieuGhiNhanUngTuyen(string mauv, string madt, string bangcap, string tinhtrang, string chungtu, string hoso)
        {
            try
            {
                string query = "INSERT INTO UNGTUYEN(MaUV, MADT, BANGCAP, TINHTRANG, CHUNGTU, HOSO) " +
                    "VALUES (@MAUV, @MADT, @BANGCAP, @TINHTRANG, @CHUNGTU, @HOSO)";
                SqlCommand cmd = new SqlCommand(query, _conn);
                cmd.Parameters.AddWithValue("@MAUV", mauv);
                cmd.Parameters.AddWithValue("@MADT", madt);
                cmd.Parameters.AddWithValue("@BANGCAP", bangcap);
                cmd.Parameters.AddWithValue("@TINHTRANG", tinhtrang);
                cmd.Parameters.AddWithValue("@CHUNGTU", chungtu);
                cmd.Parameters.AddWithValue("@HOSO", hoso);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
    