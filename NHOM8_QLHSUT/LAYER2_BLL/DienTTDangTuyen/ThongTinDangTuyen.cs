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
        public DateTime NgayBD { get; set; }
        public DateTime NgayKT { get; set; }
        public int SoLuongTuyenDung { get; set; }
        public string ViTriTuyenDung { get; set; }
        public string HinhThucDangTuyen { get; set; }
        public string MaDN { get; set; }

        public int Tien { get; set; }

        // Constructor
        public ThongTinDangTuyen()
        {
            this.MaDT = null;
            this.ThongTinYeuCau = null;
            this.SoLuongTuyenDung = -1;
            this.ViTriTuyenDung = null;
            this.NgayBD = DateTime.MinValue;
            this.NgayKT = DateTime.MinValue;
            this.HinhThucDangTuyen = null;
            this.MaDN = null;
            this.Tien = 0;
        }

        //Kiểm tra xem cac thong tin co dung quy dinh khong
        public bool kiemTraTT(DateTime ngayyBD, DateTime ngayKT, string SoLuong)
        {
              if(ngayyBD >= ngayKT) {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                return false;
              }
              else if (!SoLuong.All(char.IsDigit))
              {
                MessageBox.Show("Số lượng không hợp lệ");
                return false;
              }
            return true;
        }

        //Kiểm tra có thông tin nào vbij null không
        public bool isNull()
        {
            bool check = false;
            if(this.MaDT == null || this.ThongTinYeuCau == null || this.ViTriTuyenDung == null || this.NgayBD == DateTime.MinValue || this.NgayKT == DateTime.MinValue || this.HinhThucDangTuyen == null || this.MaDN == null || this.Tien == 0)
            {
                check = true;
            }
            return check;
        }

        // Tính tiền
        public int tinhTien()
        {
            if (this.NgayBD == null || this.NgayKT == null || this.HinhThucDangTuyen == null)
            {
                MessageBox.Show("Không đủ thông tin để tính tiền");
                return -1;
            }
            else
            {
                int giaTien = 0;
                switch (this.HinhThucDangTuyen)
                {
                    //Mỗi ngày 30 000 đối với báo giấy
                    case "Đăng tuyển trên báo giấy":
                        giaTien = (this.NgayKT - this.NgayBD).Days * 30000;
                        break;
                    //Mỗi ngày 40 000 đối với banner quảng cáo
                    case "Đăng banner quảng cáo":
                        giaTien = (this.NgayKT - this.NgayBD).Days * 40000;
                        break;
                    //Mỗi ngày 25 000 đối với đăng trên các trang mạng
                    case "Đăng trên các trang mạng":
                        giaTien = (this.NgayKT - this.NgayBD).Days * 25000;
                        break;
                    default:
                        return -1;
                }
                return giaTien;
            }
        }

        //Set data cho class 
        public bool setThongTinDangTuyen(string maDT, string thongTinYeuCau, DateTime ngayBD, DateTime ngayKT,
                                string soLuongTuyenDung, string viTriTuyenDung, string hinhThucDangTuyen,
                                string maDN)
        {
            if(string.IsNullOrEmpty(maDT) || string.IsNullOrEmpty(thongTinYeuCau) || string.IsNullOrEmpty(viTriTuyenDung) || ngayBD == DateTime.MinValue || ngayKT == DateTime.MinValue || string.IsNullOrEmpty(hinhThucDangTuyen) || string.IsNullOrEmpty(maDN) || string.IsNullOrEmpty(soLuongTuyenDung))
            {
                MessageBox.Show("Không đủ thông tin");
                return false;
            } 
            if(!kiemTraTT(ngayBD, ngayKT, soLuongTuyenDung))
            {
                return false;
            }
            this.MaDT = maDT;
            this.ThongTinYeuCau = thongTinYeuCau;  
            this.NgayBD = ngayBD;
            this.NgayKT = ngayKT;
            this.SoLuongTuyenDung = Int32.Parse(soLuongTuyenDung);
            this.ViTriTuyenDung = viTriTuyenDung;
            this.HinhThucDangTuyen = hinhThucDangTuyen;
            this.MaDN = maDN;
            this.Tien = Int32.Parse(tinhTien().ToString());
            return true;
        }

        public ThongTinDangTuyen(string MaDT, string ThongTinYeuCau, int SLTuyenDung, string VitriTuyenDung)
        {
            this.MaDT = MaDT;
            this.SoLuongTuyenDung = SLTuyenDung;
            this.ThongTinYeuCau = ThongTinYeuCau;
            this.ViTriTuyenDung = VitriTuyenDung;
        }

        public static ThongTinDangTuyen LayThongTinDangTuyen(string madt)
        {
            return DBThongTinDangTuyen.LayThongTinDangTuyen(madt);
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
            DataRow dt = db.GetTTDTByID_DataRow(this.MaDT);
            this.ThongTinYeuCau = dt["ThongTinYeuCau"].ToString();
            this.NgayBD = DateTime.Parse(dt["NgayBatDau"].ToString());
            this.NgayKT = DateTime.Parse(dt["NgayKetThuc"].ToString());
            this.SoLuongTuyenDung = Int32.Parse(dt["SLTuyenDung"].ToString());
            this.ViTriTuyenDung = dt["ViTriTuyenDung"].ToString();
            this.HinhThucDangTuyen = dt["HinhThucDangTuyen"].ToString();
            this.MaDN = dt["MaDN"].ToString();
            this.Tien = Int32.Parse(dt["GiaTien"].ToString()) ;
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
            Tien = other.Tien;
        }


        public string getViTri()
        {
            return ViTriTuyenDung;
        }

        public void updateTrangThaiTTDT(string[] maDTArray)
        {
            db.UpdateTrangThai(maDTArray);
        }

        public DataTable LayTTDTChuaDuocDang()
        {
            return db.GetTTDTChuaDuocDang();
        }
    }
}
