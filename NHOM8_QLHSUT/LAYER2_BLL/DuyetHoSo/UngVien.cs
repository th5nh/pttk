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
    class UngVien
    {
        public string DiaChi { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public UngVien(string DiaChi, string HoTen, string NgaySinh, string SoDienThoai)
        {
            this.DiaChi = DiaChi;
            this.HoTen = HoTen;
            this.NgaySinh = NgaySinh;
            this.SoDienThoai = SoDienThoai;
        }
        public static UngVien LayThongTinUngVien(string tb_ungvien)
        {
            return UngVienDB.LayThongTinUngVien(tb_ungvien);
        }
    }
}
