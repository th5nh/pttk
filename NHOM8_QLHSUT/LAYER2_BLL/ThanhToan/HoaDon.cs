using NHOM8_QLHSUT.LAYER3_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM8_QLHSUT.LAYER2_BLL.ThanhToan
{
    internal class HoaDon
    {
        string maDT;
        int dot;
        DateTime ngayLap;
        int tienCanThanhToan;
        int tienDaThanhToan;
        int tienConLai;
        public HoaDon(string maDT, int dot, DateTime ngayLap)
        { 
            this.maDT = maDT;
            this.dot = ThanhToanDB_L3.LayDot(this.maDT) + 1;
            this.ngayLap = ngayLap;
        }

        public static int HienThiDot(string maDT)
        {
            int dot = ThanhToanDB_L3.LayDot(maDT) + 1;
            if (dot > 0 && dot < 3)
            {
                return dot;
            }
            return 1;
        }

        public int TinhTien(string voucher)
        {
            tienCanThanhToan = 100000;
            return tienCanThanhToan;
        }
















        public string MaDT { get => maDT; set => maDT = value; }
        public int Dot { get => dot; set => dot = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public int TienCanThanhToan { get => tienCanThanhToan; set => tienCanThanhToan = value; }
        public int TienDaThanhToan { get => tienDaThanhToan; set => tienDaThanhToan = value; }
        public int TienConLai { get => tienConLai; set => tienConLai = value; }
    }
}
