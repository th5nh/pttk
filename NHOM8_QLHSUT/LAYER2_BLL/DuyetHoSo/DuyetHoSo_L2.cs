using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHOM8_QLHSUT.LAYER3_DAL;

namespace NHOM8_QLHSUT.LAYER2_BLL.DuyetHoSo
{
    public class DuyetHoSo_L2
    {
        public static DataTable LayThongTinDangTuyen(string tb_dangtuyen)
        {
            DataTable dt = DataAccess.LayThongTinDangTuyen(tb_dangtuyen);
            return dt;
        }

        public static DataTable LayThongTinUngVien(string tb_ungvien)
        {
            DataTable dt = DataAccess.LayThongTinUngVien(tb_ungvien);
            return dt;
        }
        public static DataTable LayThongTinUngTuyen(string tb_dangtuyen, string tb_ungvien)
        {
            DataTable dt = DataAccess.LayThongTinUngTuyen(tb_dangtuyen, tb_ungvien);
            return dt;
        }
        public static DataTable CapNhat(string tb_dangtuyen, string tb_ungvien, string cb_tinhtrang)
        {
            DataTable dt = DataAccess.CapNhat(tb_dangtuyen, tb_ungvien, cb_tinhtrang);
            return dt;
        }

    }
}
