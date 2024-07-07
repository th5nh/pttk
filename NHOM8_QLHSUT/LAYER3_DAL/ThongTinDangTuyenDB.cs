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
    public class ThongTinDangTuyenDB
    {
 
        public static ThongTinDangTuyen LayThongTinDangTuyen(string tb_dangtuyen)
        {
            string madt=null;
            string ThongTinYeuCau= null;
            int SLTuyenDung= 0;
            string ViTriTuyenDung= null;
            if(DataAccess.Connect())
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
    }
}
