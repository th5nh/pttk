using NHOM8_QLHSUT.LAYER2_BLL.DienTTDangTuyen;
using NHOM8_QLHSUT.LAYER2_BLL.ThanhToan;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
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

        public static DataTable LayThongTinDangTuyen()
        {
            try
            {
                DataTable dt = new DataTable();
                string query = "SELECT MaDT, ThongTinYeuCau, SLTuyenDung, ViTriTuyenDung, MaDN FROM THONGTINDANGTUYEN";
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
        public static List<Voucher> LayListVoucher(string query, ThongTinDangTuyen dangTuyen)
        {
            try
            {
                List<Voucher> vouchers = new List<Voucher>();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataAdapter sda = new SqlDataAdapter();

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@maDT", dangTuyen.MaDT);
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
                if (hoaDon.Voucher == null || string.IsNullOrEmpty(hoaDon.Voucher.MaCL))
                {
                    cmd.Parameters.AddWithValue("@maCL", DBNull.Value);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@maCL", hoaDon.Voucher.MaCL);
                }

                if (string.IsNullOrEmpty(hoaDon.MaThe))
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
    