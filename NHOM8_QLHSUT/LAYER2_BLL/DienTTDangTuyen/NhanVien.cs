using NHOM8_QLHSUT.LAYER3_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHOM8_QLHSUT.LAYER2_BLL.DienTTDangTuyen
{
    public class NhanVien
    {
        DBNhanVien db = new DBNhanVien();

        string MaNV;
        string HoTen;
        string ChucVu;
        string NgaySinh;
        string DiaChi;
        string SDT;
        string MatKhau;

        //Constructor
        public NhanVien()
        {
            this.MaNV = null;
            this.HoTen = null;
            this.ChucVu = null;
            this.NgaySinh = null;
            this.DiaChi = null;
            this.SDT = null;
            this.MatKhau = null;
        }

        public void setMaNV(string MaNV)
        {
            this.MaNV = MaNV;
        }

        public void setMatKhau(string MatKhau)
        {
            this.MatKhau= MatKhau;
        }

        public void setNhanVien(string MaNV, string HoTen, string ChucVu, string NgaySinh, string DiaChi, string SDT)
        {
            this.MaNV= MaNV;    
            this.HoTen= HoTen;
            this.ChucVu= ChucVu;
            this.NgaySinh= NgaySinh;
            this.DiaChi= DiaChi;
            this.SDT= SDT;
        }

        public bool loginCheck()
        {
            if (this.MatKhau == db.GetEmpPassword(this.MaNV)) {
                return true;
            }
            return false;
        }

    }
}
