using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using NHOM8_QLHSUT.LAYER2_BLL.DuyetHoSo;

namespace NHOM8_QLHSUT.LAYER3_DAL
{
    class UngVienDB
    {
        public static UngVien LayThongTinUngVien(string tb_Ungvien)
        {
            string diachi = null;
            string hoten = null;
            string ngaysinh = null;
            string sodienthoai = null;
            if(DataAccess.Connect())
            {
                string query = "SELECT HoTen, NgaySinh, SoDienThoai, DiaChi FROM UNGVIEN WHERE MaUV = '" + tb_Ungvien + "'";
                SqlCommand command = new SqlCommand(query, DataAccess.Connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        hoten = reader.GetString(0);
                        ngaysinh = reader.GetDateTime(1).ToString("dd/MM/yyyy");
                        sodienthoai = reader.GetString(2);
                        diachi = reader.GetString(3);

                    }
                }
            }
            
            UngVien ttdt = new UngVien(diachi, hoten, ngaysinh, sodienthoai);
            return ttdt;
        }
    }
}
