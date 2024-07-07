using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHOM8_QLHSUT.LAYER3_DAL;

namespace NHOM8_QLHSUT.LAYER2_BLL.ThanhToan
{
    public class ThanhToan
    {
       
        
        public static bool checkThanhToan(HoaDon hoaDon, ThongTinDangTuyen dangTuyen)
        {
            if (!checkDotHoaDon(hoaDon)) return true;
            if (DBHoaDon.LayHoaDon(dangTuyen, hoaDon.Dot - 1).TienConLai <= 0)
            {
                MessageBox.Show("Đã thanh toán hết");
                return false;
            }
            return true;
        }

        public static bool checkDangTuyen(ThongTinDangTuyen dangTuyen)
        {

            if (dangTuyen.MaDN == null || dangTuyen == null)
            {
                MessageBox.Show("Đã thanh toán hết");
                return false;
            }
            return true;
        }
        public static bool checkDotHoaDon(HoaDon hoaDon)
        {
            return hoaDon.Dot > 1;
        }


    }

}
