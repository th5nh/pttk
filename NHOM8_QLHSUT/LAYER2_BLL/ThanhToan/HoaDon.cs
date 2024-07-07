using NHOM8_QLHSUT.LAYER3_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM8_QLHSUT.LAYER2_BLL.ThanhToan
{
    public class HoaDon
    {
        ThongTinDangTuyen dangTuyen;
        int dot;
        string hinhThucTT;
        DateTime ngayLap;
        int tienCanThanhToan;
        int tienDaThanhToan;
        int tienConLai;
        string maThe;
        Voucher voucher;
        public HoaDon(ThongTinDangTuyen dangTuyen, DateTime ngayLap)
        { 
            this.dangTuyen = dangTuyen;
            this.dot = HoaDon.LayDot(dangTuyen.MaDT) + 1;
            this.ngayLap = ngayLap;
        }

        public HoaDon()
        {
            this.dangTuyen = null;
            this.dot = 0;
            this.hinhThucTT = null;
            this.ngayLap = DateTime.Now;
            this.tienCanThanhToan = 0;
            this.TienDaThanhToan = 0;
            this.tienConLai = 0;
            this.maThe = null;
            this.voucher = null;
        }

        /*public static int HienThiDot(ThongTinDangTuyen dangTuyen)
        {
            int dot = ThanhToanDB_L3.LayDot(maDT) + 1;
            if (dot > 0 && dot < 3)
            {
                return dot;
            }
            return 1;
        }*/

        public int TinhTien(ThongTinDangTuyen dangTuyen, Voucher voucher)
        {
            // Tinh theo dot
            int tien = dangTuyen.Tien;
            if (this.hinhThucTT == "1 Đợt")
            {
                if (voucher == null)
                {
                    this.tienCanThanhToan = tien;
                    this.tienDaThanhToan = this.tienCanThanhToan;

                }
                else
                {
                    //this.tienCanThanhToan = LayHoaDon(this.dangTuyen, this.dot - 1).tienConLai;
                    this.TienCanThanhToan = tien * (100 - voucher.GiaTriUuDai) / 100;
                    this.tienDaThanhToan = this.tienCanThanhToan;
                }
                this.tienConLai = this.tienCanThanhToan - this.tienDaThanhToan;
                return this.tienDaThanhToan;
            }
            else
            {
                if (this.dot > 1)
                {
                    this.tienCanThanhToan = LayHoaDon(this.dangTuyen, this.dot - 1).tienConLai; // thay tien = dangTuyen.TienConLai

                    if (this.dot == 3)
                    {
                        this.tienDaThanhToan = this.tienCanThanhToan;
                    }
                    else
                    {
                        this.tienDaThanhToan = LayHoaDon(this.dangTuyen, 1).tienCanThanhToan * 30 / 100;
                    }
                    this.tienConLai = this.tienCanThanhToan - this.tienDaThanhToan;
                    return this.tienDaThanhToan;
                }
                else
                {
                    if (voucher == null)
                    {
                        this.tienCanThanhToan = tien;
                    }
                    else
                    {
                        this.TienCanThanhToan = tien * (100 - voucher.GiaTriUuDai) / 100;
                    }
                    this.tienDaThanhToan = this.tienCanThanhToan * 30 / 100;
                    this.tienConLai = this.tienCanThanhToan - this.tienDaThanhToan;
                    return this.tienDaThanhToan;
                }
            }
        }

        public static HoaDon LayHoaDon(ThongTinDangTuyen dangTuyen, int dot)
        {
            return DBHoaDon.LayHoaDon(dangTuyen, dot);
        }

        public static HoaDon ThemHoaDon(HoaDon hoaDon)
        {
            if (hoaDon == null)
            {
                return null;
            }       
            return DBHoaDon.ThemHoaDon(hoaDon);
        }

        static public int LayDot(string maDT)
        {
            string query;
            if (DataAccess.Connect())
            {
                query = "SELECT COUNT(*) FROM HOADONTHANHTOAN" +
                    " WHERE MaDT = @maDT";

                return DataAccess.LayDot(query, maDT);
            }
            return 0;
        }










        public ThongTinDangTuyen DangTuyen { get => dangTuyen; set => dangTuyen = value; }
        public int Dot { get => dot; set => dot = value; }
        public DateTime NgayLap { get => ngayLap; set => ngayLap = value; }
        public int TienCanThanhToan { get => tienCanThanhToan; set => tienCanThanhToan = value; }
        public int TienDaThanhToan { get => tienDaThanhToan; set => tienDaThanhToan = value; }
        public int TienConLai { get => tienConLai; set => tienConLai = value; }
        public string MaThe { get => maThe; set => maThe = value; }
        public Voucher Voucher { get => voucher; set => voucher = value; }
        public string HinhThucTT { get => hinhThucTT; set => hinhThucTT = value; }
    }
}
