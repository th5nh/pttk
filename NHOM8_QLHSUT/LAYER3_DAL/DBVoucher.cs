using NHOM8_QLHSUT.LAYER2_BLL.ThanhToan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM8_QLHSUT.LAYER3_DAL
{
    public class DBVoucher
    {
        static public Voucher LayVoucher(string maCL)
        {
            string query;
            if (DataAccess.Connect())
            {
                query = "SELECT * " +
                    "FROM CHIENLUOCUUDAI " +
                    "WHERE MaCL = @maCL";

                return DataAccess.LayVoucher(query, maCL);
            }
            return null;
        }

        static public List<Voucher> LayListVoucher(ThongTinDangTuyen dangTuyen)
        {
            string query;
            if (DataAccess.Connect())
            {
                query = "SELECT DISTINCT(CLUD.MaCL), CLUD.NgayBatDau, CLUD.NgayKetThuc, CLUD.DieuKien, CLUD.MoTa, CLUD.GiaTriUuDai " +
                    "FROM THONGTINDANGTUYEN TTDT, THANHVIEN TV, THONGTINCHIENLUOC TTCL, CHIENLUOCUUDAI CLUD " +
                    "WHERE CLUD.MaCL = TTCL.MaCL AND TTDT.MaDN = TV.MaDN AND TTCL.MaDN = TV.MaDN AND TTDT.MaDT = @maDT";

                return DataAccess.LayListVoucher(query, dangTuyen);
            }
            return null;
        }
    }
}
