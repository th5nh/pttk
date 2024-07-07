using NHOM8_QLHSUT.LAYER3_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM8_QLHSUT.LAYER2_BLL.ThanhToan
{
    public class Voucher
    {
        string maCL;
        DateTime ngayBatDau;
        DateTime ngayKetThuc;
        string dieuKien;
        string moTa;
        int giaTriUuDai;

        public static Voucher LayVoucher(string maCL)
        {
            return DBVoucher.LayVoucher(maCL);
        }

        public static List<Voucher> LayListVoucher(ThongTinDangTuyen dangTuyen)
        {
            List<Voucher> vouchers = DBVoucher.LayListVoucher(dangTuyen);
            List<Voucher> newVouchers = new List<Voucher>();
            foreach (Voucher i in vouchers)
            {
                if (i.NgayBatDau <= DateTime.Now && i.NgayKetThuc >= DateTime.Now)
                {
                    newVouchers.Add(i);
                }
            }
            return newVouchers;
        }







        public string MaCL { get => maCL; set => maCL = value; }
        public DateTime NgayBatDau { get => ngayBatDau; set => ngayBatDau = value; }
        public DateTime NgayKetThuc { get => ngayKetThuc; set => ngayKetThuc = value; }
        public string DieuKien { get => dieuKien; set => dieuKien = value; }
        public string MoTa { get => moTa; set => moTa = value; }
        public int GiaTriUuDai { get => giaTriUuDai; set => giaTriUuDai = value; }
    }
}
