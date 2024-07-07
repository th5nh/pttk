﻿using NHOM8_QLHSUT.LAYER2_BLL.ThanhToan;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NHOM8_QLHSUT.LAYER3_DAL
{
    public class DataAccess
    {
        private static string _connString = "";
        private static SqlConnection _conn = new SqlConnection();

        public static SqlConnection Connection
        {
            get { return _conn; }
        }
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

        public static DataTable GetThongTinDangTuyen()
        {
            DataTable dt = new DataTable();
            string query = "SELECT MaDT, ThongTinYeuCau, SLTuyenDung, ViTriTuyenDung FROM THONGTINDANGTUYEN";
            SqlDataAdapter sda = new SqlDataAdapter(query, _conn);
            sda.Fill(dt);
            return dt;
        }

        public static DataTable LayDangTuyenSQL(string query, string maDT)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(query, _conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@maDT", maDT);
                sda.SelectCommand = cmd;
                int rowsReturn = sda.Fill(dt);
                MessageBox.Show("" + rowsReturn);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.GetBaseException().ToString(), "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        public static int LayDot(string query, string maDT)
        {
            SqlCommand cmd = new SqlCommand(query, _conn);
            SqlDataAdapter sda = new SqlDataAdapter();
            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@maDT", maDT);
                sda.SelectCommand = cmd;
                int count = (int)cmd.ExecuteScalar();
                return count;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.GetBaseException().ToString(), "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }
        public static List<Voucher> LayListVoucher(string query, string maDT)
        {
            try
            {
                List<Voucher> vouchers = new List<Voucher>();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataAdapter sda = new SqlDataAdapter();

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@maDT", maDT);
                sda.SelectCommand = cmd;
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Voucher vc = new Voucher();
                    vc.MaCL = dr["MaCL"].ToString();
                    vc.NgayBatDau = DateTime.Parse(dr["NgayBatDau"].ToString());
                    vc.NgayKetThuc = DateTime.Parse(dr["NgayKetThuc"].ToString());
                    vc.DieuKien = dr["DieuKien"].ToString();
                    vc.MoTa = dr["MoTa"].ToString();
                    vc.GiaTriUuDai = Int32.Parse(dr["GiaTriUuDai"].ToString());
                    vouchers.Add(vc);
                }

                return vouchers;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.GetBaseException().ToString(), "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public static Voucher LayVoucher(string query, string maCL)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataAdapter sda = new SqlDataAdapter();

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@maCL", maCL);
                sda.SelectCommand = cmd;
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    Voucher vc = new Voucher();
                    vc.MaCL = dr["MaCL"].ToString();
                    vc.NgayBatDau = DateTime.Parse(dr["NgayBatDau"].ToString());
                    vc.NgayKetThuc = DateTime.Parse(dr["NgayKetThuc"].ToString());
                    vc.DieuKien = dr["DieuKien"].ToString();
                    vc.MoTa = dr["MoTa"].ToString();
                    vc.GiaTriUuDai = Int32.Parse(dr["GiaTriUuDai"].ToString());
                    return vc;
                }

                return null;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.GetBaseException().ToString(), "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        public static HoaDon LayHoaDon(string query, string maDT, int dot)
        {
            try
            {
                HoaDon hoaDon = new HoaDon();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataAdapter sda = new SqlDataAdapter();

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@maDT", maDT);
                cmd.Parameters.AddWithValue("@dot", dot);
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                Voucher voucher = new Voucher();
                foreach (DataRow dr in dt.Rows)
                {
                    hoaDon.DangTuyen = DBThongTinDangTuyen.GetTTDTByID(dr["MaDT"].ToString());
                    hoaDon.Dot = Int32.Parse(dr["DotThanhToan"].ToString());
                    hoaDon.NgayLap = DateTime.Parse(dr["NgayLap"].ToString());
                    hoaDon.TienCanThanhToan = Int32.Parse(dr["SoTienCanThanhToan"].ToString());
                    hoaDon.TienDaThanhToan = Int32.Parse(dr["SoTienDaThanhToan"].ToString());
                    hoaDon.TienConLai = Int32.Parse(dr["SoTienConLai"].ToString());
                    hoaDon.Voucher = Voucher.LayVoucher(dr["SoTienConLai"].ToString());
                    hoaDon.MaThe = dr["MaThe"].ToString();
                    return hoaDon;
                }

                return null;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.GetBaseException().ToString(), "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public static HoaDon ThemHoaDon(string query, HoaDon hoaDon)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataAdapter sda = new SqlDataAdapter();

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@maDT", hoaDon.DangTuyen.MaDT);
                cmd.Parameters.AddWithValue("@dot", hoaDon.Dot);
                cmd.Parameters.AddWithValue("@ngayLap", hoaDon.NgayLap);
                cmd.Parameters.AddWithValue("@tienCanThanhToan", hoaDon.TienCanThanhToan);
                cmd.Parameters.AddWithValue("@tienDahanhToan", hoaDon.TienDaThanhToan);
                cmd.Parameters.AddWithValue("@tienConLai", hoaDon.TienConLai);
                if (hoaDon.Voucher == null)
                {
                    cmd.Parameters.AddWithValue("@maCL", DBNull.Value);
                }
                else 
                {
                    cmd.Parameters.AddWithValue("@maCL", hoaDon.Voucher.MaCL);
                }
                if (hoaDon.MaThe == "") 
                {
                    cmd.Parameters.AddWithValue("@maThe", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@maThe", hoaDon.MaThe);
                }
                cmd.Parameters.AddWithValue("@hinhThucThanhToan", hoaDon.HinhThucTT);
                int count = cmd.ExecuteNonQuery();
                MessageBox.Show("Rows affected: " + count);
                return hoaDon;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.GetBaseException().ToString(), "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}
    