using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHOM8_QLHSUT.LAYER3_DAL;

namespace NHOM8_QLHSUT.LAYER2_BLL.DienTTDangTuyen
{
    public class ThongTinDangTuyen
    {
        DBThongTinDangTuyen db = new DBThongTinDangTuyen();

        public string MaDT { get; set; }
        public string ThongTinYeuCau { get; set; }
        public DateTime? NgayBD { get; set; }
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
            this.NgayBD = null;
            this.NgayKT = null;
            this.SoLuongTuyenDung = -1;
            this.ViTriTuyenDung = null;
            this.HinhThucDangTuyen = null;
            this.MaDN = null;
        }

        //Set data cho class 
        public void setThongTinDangTuyen(string maDT, string thongTinYeuCau, DateTime ngayBD, DateTime ngayKT,
                                int soLuongTuyenDung, string viTriTuyenDung, string hinhThucDangTuyen,
                                string maDN)
        {
            this.MaDT = maDT;
            this.ThongTinYeuCau = thongTinYeuCau;  
            this.NgayBD = ngayBD;
            this.NgayKT = ngayKT;
            this.SoLuongTuyenDung = soLuongTuyenDung;
            this.ViTriTuyenDung = viTriTuyenDung;
            this.HinhThucDangTuyen = hinhThucDangTuyen;
            this.MaDN = maDN;
        }

        public void setMaDT(string MaDT)
        {
            this.MaDT = MaDT;
        }

        public void ThemTTDangTuyen(ThongTinDangTuyen data)
        {
            db.ThemThongTinDangTuyen(data);
        }

        public string getAutoMaDangTuyen()
        {
            return db.GetMaThongTinDangTuyen();
        }

        public DataTable getAllThongTinDangTuyen()
        {
            DataTable dt = new DataTable();
            dt = db.GetTTDTChuaHoanTatTT();
            return dt;
        }

        public void getThongTinDangTuyen()
        {
            DataRow dt = db.GetTTDTByID(this.MaDT);
            this.ThongTinYeuCau = dt["ThongTinYeuCau"].ToString();
            this.NgayBD = DateTime.Parse(dt["NgayBatDau"].ToString());
            this.NgayKT = DateTime.Parse(dt["NgayKetThuc"].ToString());
            this.SoLuongTuyenDung = Int32.Parse(dt["SLTuyenDung"].ToString());
            this.ViTriTuyenDung = dt["ViTriTuyenDung"].ToString();
            this.HinhThucDangTuyen = dt["HinhThucDangTuyen"].ToString();
            this.MaDN = dt["MaDN"].ToString();

        }

        public void CopyFrom(ThongTinDangTuyen other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            MaDT = other.MaDT;
            ThongTinYeuCau = other.ThongTinYeuCau;
            NgayBD = other.NgayBD;
            NgayKT = other.NgayKT;
            SoLuongTuyenDung = other.SoLuongTuyenDung;
            ViTriTuyenDung = other.ViTriTuyenDung;
            HinhThucDangTuyen = other.HinhThucDangTuyen;
            MaDN = other.MaDN;
        }

        public bool EmptyFieldCheck()
        {
            return this.MaDT == null ||
                   this.ThongTinYeuCau == null ||
                   this.NgayBD == null ||
                   this.NgayKT == null ||
                   this.ViTriTuyenDung == null ||
                   this.HinhThucDangTuyen == null ||
                   this.MaDN == null;
        }

        public string getViTri()
        {
            return ViTriTuyenDung;
        }
    }
}
