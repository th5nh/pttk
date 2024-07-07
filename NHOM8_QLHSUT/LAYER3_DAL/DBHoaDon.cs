using NHOM8_QLHSUT.LAYER2_BLL.ThanhToan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM8_QLHSUT.LAYER3_DAL
{
    public class DBHoaDon
    {
        public static HoaDon LayHoaDon(ThongTinDangTuyen dangTuyen, int dot)
        {
            string query;
            if (DataAccess.Connect())
            {
                query = "SELECT * " +
                    "FROM HOADONTHANHTOAN " +
                    "WHERE MaDT = @maDT AND DotThanhToan = @dot";

                return DataAccess.LayHoaDon(query, dangTuyen.MaDT, dot);
            }
            return null;
        }

        public static HoaDon ThemHoaDon(HoaDon hoaDon)
        {
            string query;
            if (DataAccess.Connect())
            {
                query = "INSERT INTO HOADONTHANHTOAN(MaDT, DotThanhToan, NgayLap, SoTienCanThanhToan, " +
                    "SoTienDaThanhToan, SoTienConLai, MaCL, MaThe, HinhThucThanhToan) " +
                    "VALUES (@maDT, @dot, @ngayLap, " +
                    "@tienCanThanhToan, " +
                    "@tienDahanhToan, " +
                    "@tienConLai, " +
                    "@maCL, @maThe, @hinhThucThanhToan)";

                return DataAccess.ThemHoaDon(query, hoaDon);
            }
            return null;
        }
    }
}
