using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHOM8_QLHSUT.LAYER3_DAL;

namespace NHOM8_QLHSUT.LAYER2_BLL.NopHoSo
{
    public class NopHoSo_L2
    {
        public static DataTable ThongTinDangTuyen()
        {
            DataTable dt = DataAccess.GetThongTinDangTuyen();
            return dt;
        }
    }
}
