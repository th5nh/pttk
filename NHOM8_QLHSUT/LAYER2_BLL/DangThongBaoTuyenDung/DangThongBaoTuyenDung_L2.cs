using NHOM8_QLHSUT.LAYER3_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;



namespace NHOM8_QLHSUT.LAYER2_BLL.DangThongBaoTuyenDung
{ 
    public class DangThongBaoTuyenDung_L2
    {
        public static DataTable ThongBaoDangTuyen()
        {
            DataTable dt = DataAccess.LayThongBaoDangTuyen();        
            return dt;
        }
    }
}
