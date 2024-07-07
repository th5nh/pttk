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
    public class UngTuyenDB
    {
        public static UngTuyen LayThongTinUngTuyen(string tb_dangtuyen, string tb_Ungvien)
        {
            string bangcap = null;
            string chungtu = null;
            string hoso = null;
            string tinhtrang = null;
            if (DataAccess.Connect())
            {
                DataTable dt = new DataTable();
                string query = "SELECT BangCap, ChungTu, HoSo, TinhTrang FROM UNGTUYEN WHERE MaUV = '" + tb_Ungvien + "' AND MaDT= '" + tb_dangtuyen + "'";
                SqlCommand command = new SqlCommand(query, DataAccess.Connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {

                    while (reader.Read())
                    {

                        bangcap = reader.GetString(0);
                        chungtu = reader.GetString(1);
                        hoso = reader.GetString(2);
                        tinhtrang = reader.GetString(3);

                    }
                }
            }
                


            UngTuyen ttut = new UngTuyen(bangcap, chungtu, hoso, tinhtrang);
            return ttut;
        }
        public static DataTable CapNhat(string tb_dangtuyen, string tb_Ungvien, string cb_tinhtrang)
        {
            try
            {
                if (DataAccess.Connect())
                {
                    DataTable dt = new DataTable();
                    string query = "Update UNGTUYEN SET TinhTrang= N'" + cb_tinhtrang + "'" + " WHERE MaUV = '" + tb_Ungvien + "' AND MaDT= '" + tb_dangtuyen + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, DataAccess.Connection);
                    sda.Fill(dt);
                    MessageBox.Show("Cập nhật thành công");
                    return dt;
                }
                else
                {
                    MessageBox.Show("Không thể kết nối tới Database");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
                MessageBox.Show(ex.ToString());
            }
            
            return null;
        }
    }
}
