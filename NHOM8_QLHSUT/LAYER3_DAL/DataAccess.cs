using NHOM8_QLHSUT.LAYER2_BLL.ThanhToan;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
        public static List<Voucher> LayVoucher(string query, string maDT)
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
    }
}
    