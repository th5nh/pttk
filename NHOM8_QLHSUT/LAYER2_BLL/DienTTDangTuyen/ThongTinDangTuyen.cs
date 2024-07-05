using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHOM8_QLHSUT.LAYER3_DAL;

namespace NHOM8_QLHSUT.LAYER2_BLL.DienTTDangTuyen
{
    public class ThongTinDangTuyen
    {
        DBThongTinDangTuyen db = new DBThongTinDangTuyen();

        public string MaDT { get; set; }
        public string ThongTinYeuCau { get; set; }
        public DateTime? NgayDB { get; set; }
        public DateTime? NgayKT { get; set; }
        public int SoLuongTuyenDung { get; set; }
        public string ViTriTuyenDung { get; set; }
        public string HinhThucDangTuyen { get; set; }
        public string MaDN { get; set; }

        // Constructor
        public ThongTinDangTuyen()
        {
            this.MaDT = null;
            this.ThongTinYeuCau = null;
            this.NgayDB = null;
            this.NgayKT = null;
            this.SoLuongTuyenDung = -1;
            this.ViTriTuyenDung = null;
            this.HinhThucDangTuyen = null;
            this.MaDN = null;
        }

        //Set data cho class 
        public void setThongTinDangTuyen(string maDT, string thongTinYeuCau, DateTime ngayDB, DateTime ngayKT,
                                int soLuongTuyenDung, string viTriTuyenDung, string hinhThucDangTuyen,
                                string maDN)
        {
            this.MaDT = maDT;
            this.ThongTinYeuCau = thongTinYeuCau;  
            this.NgayDB = ngayDB;
            this.NgayKT = ngayKT;
            this.SoLuongTuyenDung = soLuongTuyenDung;
            this.ViTriTuyenDung = viTriTuyenDung;
            this.HinhThucDangTuyen = hinhThucDangTuyen;
            this.MaDN = maDN;
        }

        public void ThemTTDangTuyen(ThongTinDangTuyen data)
        {
            db.InsertThongTinDangTuyen(data);
        }

        public string getAutoMaDangTuyen()
        {
            return db.GetMaThongTinDangTuyen();
        }
    }
}
