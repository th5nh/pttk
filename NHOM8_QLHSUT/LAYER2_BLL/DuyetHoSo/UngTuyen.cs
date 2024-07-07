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
    public class UngTuyen
    {
        public string BangCap { get; set; }
        public string ChungTu { get; set; }
        public string HoSo { get; set; }
        public string TinhTrang { get; set; }
        public UngTuyen(string BangCap, string ChungTu, string HoSo, string TinhTrang)
        {
            this.BangCap = BangCap;
            this.ChungTu = ChungTu;
            this.HoSo = HoSo;
            this.TinhTrang = TinhTrang;
        }
        public static UngTuyen LayThongTinUngTuyen(string madt, string mauv)
        {
            return UngTuyenDB.LayThongTinUngTuyen(madt,mauv);
        }
        public static DataTable CapNhat(string tb_dangtuyen, string tb_ungvien, string cb_tinhtrang)
        {
            DataTable dt = UngTuyenDB.CapNhat(tb_dangtuyen, tb_ungvien, cb_tinhtrang);
            return dt;
        }
    }
}
