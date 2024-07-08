using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHOM8_QLHSUT.LAYER2_BLL.DienTTDangTuyen;

namespace NHOM8_QLHSUT.LAYER3_DAL
{
    public class DBThongTinDangTuyen
    {
        //Lấy mã thông tin đăng tuyển tiếp theo
        public string GetMaThongTinDangTuyen()
        {
            string result = string.Empty;
            try
            {
                bool isConnected = DataAccess.Connect();

                if(isConnected)
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT dbo.f_AutoMaTTDT()", DataAccess.Connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        var res = cmd.ExecuteScalar();

                        if(res != null)
                        {
                            result = res.ToString();
                        }
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            return result;
        }

        // Thêm thông tin đăng tuyển 
        public void ThemThongTinDangTuyen(ThongTinDangTuyen data)
        {
            try
            {
                // Kết nối đến cơ sở dữ liệu
                bool isConnected = DataAccess.Connect();         
                if (isConnected)
                {
                    using (SqlCommand cmd = new SqlCommand("SP_THEM_TTDANGTUYEN", DataAccess.Connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@TTYeuCau", data.ThongTinYeuCau);
                        cmd.Parameters.AddWithValue("@NgayBatDau", data.NgayBD);
                        cmd.Parameters.AddWithValue("@NgayKetThuc", data.NgayKT);
                        cmd.Parameters.AddWithValue("@SoLuongTuyenDung", data.SoLuongTuyenDung);
                        cmd.Parameters.AddWithValue("@ViTriTuyenDung", data.ViTriTuyenDung);
                        cmd.Parameters.AddWithValue("@HinhThucDangTuyen", data.HinhThucDangTuyen);
                        cmd.Parameters.AddWithValue("@MaDN", data.MaDN);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm thông tin đăng tuyển thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thông tin đăng tuyển thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
            }
        }


        public static ThongTinDangTuyen GetTTDTByID(string MaDT)
        {
            DataRow employeeInfo = null;
            try
            {
                // Kết nối đến cơ sở dữ liệu
                bool isConnected = DataAccess.Connect();

                if (isConnected)
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM THONGTINDANGTUYEN WHERE MaDT = @MaDangTuyen", DataAccess.Connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@MaDangTuyen", MaDT);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                ThongTinDangTuyen dangTuyen = new ThongTinDangTuyen();
                                employeeInfo = dt.Rows[0];
                                dangTuyen.ThongTinYeuCau = employeeInfo["ThongTinYeuCau"].ToString();
                                dangTuyen.NgayBD = DateTime.Parse(employeeInfo["NgayBatDau"].ToString());
                                dangTuyen.NgayKT = DateTime.Parse(employeeInfo["NgayKetThuc"].ToString());
                                dangTuyen.SoLuongTuyenDung = Int32.Parse(employeeInfo["SLTuyenDung"].ToString());
                                dangTuyen.ViTriTuyenDung = employeeInfo["ViTriTuyenDung"].ToString();
                                dangTuyen.HinhThucDangTuyen = employeeInfo["HinhThucDangTuyen"].ToString();
                                dangTuyen.MaDN = employeeInfo["MaDN"].ToString();
                                return dangTuyen;
                            }
                            else
                            {
                                MessageBox.Show("Không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().ToString(), "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        //Lấy tất cả  thông tin đăng tuyển chưa thanh toán het
        public DataTable GetTTDTChuaHoanTatTT()
        {
            DataTable data = new DataTable();
            try
            {
                // Kết nối đến cơ sở dữ liệu
                bool isConnected = DataAccess.Connect();

                if (isConnected)
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT TTDT.MADT, TTDT.NgayBatDau, TTDT.NgayKetThuc, TTDT.MaDN, HDTT.SoTienCanThanhToan, HDTT.SoTienDaThanhToan, HDTT.SoTienConLai, HDTT.DotThanhToan\r\nFROM THONGTINDANGTUYEN TTDT JOIN HOADONTHANHTOAN HDTT ON TTDT.MADT = HDTT.MADT\r\nWHERE HDTT.MADT NOT IN (SELECT HDTT.MADT \r\n\t\t\t\t\t\tFROM HOADONTHANHTOAN JOIN THONGTINDANGTUYEN TTDT ON TTDT.MADT = HDTT.MADT\r\n\t\t\t\t\t\tWHERE HDTT.SoTienConLai = 0)", DataAccess.Connection))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(data);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return data;
        }

        //Lấy thông tin một thông tin đăng tuyển theo MaDT 
        public DataRow GetTTDTByID_DataRow(string MaDT)
        {
            DataRow employeeInfo = null;
            try
            {
                // Kết nối đến cơ sở dữ liệu
                bool isConnected = DataAccess.Connect();

                if (isConnected)
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM THONGTINDANGTUYEN WHERE MaDT = @MaDangTuyen", DataAccess.Connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@MaDangTuyen", MaDT);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                employeeInfo = dt.Rows[0];
                            }
                            else
                            {
                                MessageBox.Show("Không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return employeeInfo;
        }

        public static ThongTinDangTuyen LayThongTinDangTuyen(string tb_dangtuyen)
        {
            string madt = null;
            string ThongTinYeuCau = null;
            int SLTuyenDung = 0;
            string ViTriTuyenDung = null;
            if (DataAccess.Connect())
            {
                string query = "SELECT MaDT, ThongTinYeuCau, SLTuyenDung, ViTriTuyenDung FROM THONGTINDANGTUYEN WHERE MaDT = '" + tb_dangtuyen + "'";
                SqlCommand command = new SqlCommand(query, DataAccess.Connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        madt = reader.GetString(0);
                        ThongTinYeuCau = reader.GetString(1);
                        SLTuyenDung = reader.GetInt32(2);
                        ViTriTuyenDung = reader.GetString(3);

                    }
                }
            }


            ThongTinDangTuyen ttdt = new ThongTinDangTuyen(madt, ThongTinYeuCau, SLTuyenDung, ViTriTuyenDung);
            return ttdt;
        }

        //Update trạng thái thông tin đăng tuyển
        public void UpdateTrangThai(string[] maDTArray)
        {
            try
            {
                bool isConnected = DataAccess.Connect();

                if (isConnected)
                {
                    string maDTList = string.Join(",", maDTArray.Select(maDT => $"'{maDT}'"));
                    string query = $"UPDATE THONGTINDANGTUYEN SET TinhTrang = N'Đã được đăng' WHERE MaDT IN ({maDTList})";

                    using (SqlCommand cmd = new SqlCommand(query, DataAccess.Connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Cập nhật trạng thái thành công!");
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Lấy các thông tin đăng tuyển chưa được đăng 
        //Lấy tất cả  thông tin đăng tuyển chưa thanh toán het
        public DataTable GetTTDTChuaDuocDang()
        {
            DataTable data = new DataTable();
            try
            {
                // Kết nối đến cơ sở dữ liệu
                bool isConnected = DataAccess.Connect();

                if (isConnected)
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM THONGTINDANGTUYEN WHERE TinhTrang != N'Đã được đăng'", DataAccess.Connection))
                    {
                        cmd.CommandType = CommandType.Text;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(data);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return data;
        }
    }
}
