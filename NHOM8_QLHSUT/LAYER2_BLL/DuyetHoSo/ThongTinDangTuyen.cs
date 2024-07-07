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
    public class ThongTinDangTuyen
    {
        public string MaDT { get; set; }
        public int SLTuyenDung { get; set; }
        public string ThongTinYeuCau { get; set; }
        public string VitriTuyenDung { get; set; }
        public ThongTinDangTuyen(string MaDT, string ThongTinYeuCau,int SLTuyenDung, string VitriTuyenDung)
        {
            this.MaDT = MaDT;
            this.SLTuyenDung = SLTuyenDung;
            this.ThongTinYeuCau = ThongTinYeuCau;
            this.VitriTuyenDung = VitriTuyenDung;
        }
        public static ThongTinDangTuyen LayThongTinDangTuyen(string madt)
        {
           return ThongTinDangTuyenDB.LayThongTinDangTuyen(madt);
        }
       
    }
}
