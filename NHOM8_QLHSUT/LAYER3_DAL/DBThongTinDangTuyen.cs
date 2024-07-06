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

        //Lấy tất cả  thông tin đăng tuyển 
        public DataTable GetAllTTDT()
        {
            DataTable data = new DataTable();
            try
            {
                // Kết nối đến cơ sở dữ liệu
                bool isConnected = DataAccess.Connect();

                if (isConnected)
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM THONGTINDANGTUYEN", DataAccess.Connection))
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
        public DataRow GetTTDTByID(string MaDT)
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
    }
}
