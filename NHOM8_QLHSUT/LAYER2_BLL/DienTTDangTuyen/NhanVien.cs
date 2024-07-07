using NHOM8_QLHSUT.LAYER3_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM8_QLHSUT.LAYER2_BLL.DienTTDangTuyen
{
    public class NhanVien
    {
        DBNhanVien db = new DBNhanVien();

        public string MaNV;
        public string HoTen;
        public string ChucVu;
        public DateTime? NgaySinh;
        public string DiaChi;
        public string SDT;
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

        public void setNhanVien(string MaNV, string HoTen, string ChucVu, DateTime NgaySinh, string DiaChi, string SDT, string MatKhau)
        {
            this.MaNV= MaNV;    
            this.HoTen= HoTen;
            this.ChucVu= ChucVu;
            this.NgaySinh= NgaySinh;
            this.DiaChi= DiaChi;
            this.SDT= SDT;
            this.MatKhau = MatKhau;
        }

        public bool KiemTraDangNhap()
        {
            if (this.MatKhau == db.getMatKhauNV(this.MaNV)) {
                MessageBox.Show("Đăng nhập thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        public void getEmpInfo()
        {
            DataRow dt = db.getThongTinNV(this.MaNV);
            this.MaNV = dt["MaNV"].ToString();
            this.HoTen = dt["HoTen"].ToString();
            this.ChucVu = dt["ChucVu"].ToString();
            this.DiaChi = dt["DiaChi"].ToString();
            this.SDT = dt["SoDienThoai"].ToString();
            this.NgaySinh = DateTime.Parse(dt["NgaySinh"].ToString());
        }
    }
}
