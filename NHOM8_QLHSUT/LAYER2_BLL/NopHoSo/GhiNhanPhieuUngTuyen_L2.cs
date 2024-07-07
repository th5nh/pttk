using NHOM8_QLHSUT.LAYER3_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NHOM8_QLHSUT.LAYER2_BLL.NopHoSo
{
    public class GhiNhanPhieuUngTuyen_L2
    {
        public static DataTable ThongTinUngVien()
        {
            DataTable dt = DataAccess.LayThongTinUngVien();
            return dt;
        }

        public static DataTable ThongTinDangTuyen()
        {
            DataTable dt = DataAccess.LayThongTinDangTuyen();
            return dt;
        }

        public static string FilterMultiline(string str)
        {
            str = str.Replace(System.Environment.NewLine, ", ");
            str = Regex.Replace(str, @"\s+", " ");
            str = Regex.Replace(str, @"(, )+", ", ");
            str = Regex.Replace(str, @"( ,)+", ",");
            return str;
        }

        public static bool ThemPhieuGhiNhanUngTuyen(string mauv, string madt, string bangcap, string tinhtrang, string chungtu, string hoso)
        {
            if (DataAccess.ThemPhieuGhiNhanUngTuyen(mauv, madt, bangcap, tinhtrang, chungtu, hoso))
                return true;
            return false;
        }
    }
}