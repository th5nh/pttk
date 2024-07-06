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
    internal class ThanhToan_L2
    {
        
        public static DataTable LayDangTuyen(string maDT)
        {
            DataTable dt = ThanhToanDB_L3.LayTTDangTuyen(maDT);
            return dt;
        }
        public static List<Voucher> LayVoucher(string maDT)
        {
            List<Voucher> vouchers = ThanhToanDB_L3.LayVoucher(maDT);
            List<Voucher> newVouchers = new List<Voucher>();
            foreach (Voucher i in vouchers)
            {
                if(i.NgayBatDau <= DateTime.Now && i.NgayKetThuc >= DateTime.Now)
                {
                    newVouchers.Add(i);
                }
            }
            return newVouchers;

        }

    }

}
