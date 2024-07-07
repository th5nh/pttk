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
                string query = "SELECT MaDT, ThongTinYeuCau, SLTuyenDung, ViTriTuyenDung FROM THONGTINDANGTUYEN";
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
        //public static DataTable LayThongTinDangTuyen()
        //{
        //    try
        //    {
        //        DataTable dt = new DataTable();
        //        string query = "SELECT MaDT, ThongTinYeuCau, SLTuyenDung, ViTriTuyenDung FROM THONGTINDANGTUYEN";
        //        SqlDataAdapter sda = new SqlDataAdapter(query, _conn);
        //        sda.Fill(dt);
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.ToString());
        //        return null;
        //    }
        //}

        public static DataTable LayThongBaoDangTuyen()
        {
            try
            {
                DataTable dt = new DataTable();

                string query = "SELECT TT.MaDT, MaDN, ViTriTuyenDung, SLTuyenDung, NgayBatDau, NgayKetThuc, ThongTinYeuCau "
                + "FROM THONGTINDANGTUYEN AS TT "
                + "JOIN HOADONTHANHTOAN AS HD "
                + "ON TT.MaDT = HD.MaDT "
                + "WHERE HD.SoTienConLai = 0";
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
        public static DataTable LayThongTinDangTuyen(string tb_dangtuyen)
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaDT, ThongTinYeuCau, SLTuyenDung, ViTriTuyenDung FROM THONGTINDANGTUYEN WHERE MaDT = '" + tb_dangtuyen+ "'" ;
            SqlDataAdapter sda = new SqlDataAdapter(query, _conn);
            sda.Fill(dt);
            return dt;
        }
        public static DataTable LayThongTinUngVien(string tb_Ungvien)
        {
            DataTable dt = new DataTable();
            string query = "SELECT HoTen, NgaySinh, SoDienThoai, DiaChi FROM UNGVIEN WHERE MaUV = '" + tb_Ungvien + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, _conn);
            sda.Fill(dt);
            return dt;
        }
        public static DataTable LayThongTinUngTuyen(string tb_dangtuyen, string tb_Ungvien)
        {
            DataTable dt = new DataTable();
            string query = "SELECT BangCap, ChungTu, HoSo, TinhTrang FROM UNGTUYEN WHERE MaUV = '" + tb_Ungvien + "' AND MaDT= '" + tb_dangtuyen + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, _conn);
            sda.Fill(dt);
            return dt;
        }
        public static DataTable CapNhat(string tb_dangtuyen, string tb_Ungvien,string cb_tinhtrang)
        {
            DataTable dt = new DataTable();
            string query = "Update UNGTUYEN SET TinhTrang= N'"+cb_tinhtrang+"'"+ " WHERE MaUV = '" + tb_Ungvien + "' AND MaDT= '" + tb_dangtuyen + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, _conn);
            sda.Fill(dt);
            return dt;
        }

        public static SqlConnection Connection
        {
            get { return _conn; }
        }
    }
}
    