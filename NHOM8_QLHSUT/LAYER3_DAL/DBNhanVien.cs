using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM8_QLHSUT.LAYER3_DAL
{
    internal class DBNhanVien
    {
        //Lấy mật khẩu một nhân viên 
        public string getMatKhauNV(string username)
        {
            string password = null;
            try
            {
                // Kết nối đến cơ sở dữ liệu
                bool isConnected = DataAccess.Connect();

                if (isConnected)
                {
                    using (SqlCommand cmd = new SqlCommand("GET_MATKHAU_NHANVIEN", DataAccess.Connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@USERNAME", username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                password = reader["MatKhau"].ToString(); 
                            }
                            else
                            {
                                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Đăng nhập thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
            }
            return password;
        }

        //Lấy thông tin một nhân viên
        public DataRow getThongTinNV(string username)
        {
            DataRow employeeInfo = null;
            try
            {
                // Kết nối đến cơ sở dữ liệu
                bool isConnected = DataAccess.Connect();

                if (isConnected)
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM NHANVIEN WHERE MaNV = @USERNAME", DataAccess.Connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@USERNAME", username);

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
                                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Đăng nhập thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(ex.ToString());
            }
            return employeeInfo;
        }

    }
}
