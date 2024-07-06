using NHOM8_QLHSUT.LAYER2_BLL.ThanhToan;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NHOM8_QLHSUT.LAYER3_DAL
{
    internal class ThanhToanDB_L3
    {
        string query;
        static public DataTable LayTTDangTuyen(string maDT)
        {
            DataTable dataTable = new DataTable();
            string query;
            if(DataAccess.Connect())
            {
                query = "SELECT * FROM THONGTINDANGTUYEN" +
                    " WHERE MaDT = @MaDT";
                
                dataTable = DataAccess.LayDangTuyenSQL(query, maDT);
                return dataTable;
            }
            return dataTable;
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
        static public List<Voucher> LayVoucher(string maDT) 
        {
            string query;
            if (DataAccess.Connect())
            {
                query = "SELECT DISTINCT(CLUD.MaCL), CLUD.NgayBatDau, CLUD.NgayKetThuc, CLUD.DieuKien, CLUD.MoTa, CLUD.GiaTriUuDai " +
                    "FROM THONGTINDANGTUYEN TTDT, THANHVIEN TV, THONGTINCHIENLUOC TTCL, CHIENLUOCUUDAI CLUD " +
                    "WHERE CLUD.MaCL = TTCL.MaCL AND TTDT.MaDN = TV.MaDN AND TTCL.MaDN = TV.MaDN AND TTDT.MaDT = @maDT";

                return DataAccess.LayVoucher(query, maDT);
            }
            return null;
        }


    }
}
