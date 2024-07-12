using NHOM8_QLHSUT.LAYER2_BLL.DienTTDangTuyen;
using NHOM8_QLHSUT.LAYER2_BLL.ThanhToan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NHOM8_QLHSUT.LAYER1_GUI.ThanhToan
{
    public partial class MHThanhToan : Form
    {
        // Lay Thong Tin Dang Tuyen o use case truoc
        // Tam xai string, int de Test thay cho class DangTuyen
        ThongTinDangTuyen dangTuyen = new ThongTinDangTuyen();
        HoaDon hoaDon;
        int loaiThanhToan = -1;
        List<Voucher> vouchers = new List<Voucher>();
        public MHThanhToan()
        {
            InitializeComponent();
        }
        public MHThanhToan(ThongTinDangTuyen dangTuyen, int chucNang) // Test thay cho class DangTuyen
        {
            InitializeComponent();
            this.dangTuyen.CopyFrom(dangTuyen);
            this.loaiThanhToan = chucNang;
        }
        void HienThiVoucher()
        {
            if (LAYER2_BLL.ThanhToan.ThanhToan.checkDotHoaDon(hoaDon))
            {
                this.lbVoucher.Enabled = false;
                this.cbbVoucher.Enabled = false;
            }    
            this.cbbVoucher.Items.Add("");  
            foreach (Voucher vc in this.vouchers)
            {
                string code = (vc.MaCL);
                this.cbbVoucher.Items.Add(code);
            }
        }
        void HienThiDangTuyen()
        {
            this.dtDangTuyen.DataSource = new List<ThongTinDangTuyen>() { this.dangTuyen };
        }
        void HienThiDot()
        {
            if (LAYER2_BLL.ThanhToan.ThanhToan.checkDotHoaDon(hoaDon))
            {
                cbbHinhThucThanhToan.Text = cbbHinhThucThanhToan.Items[1].ToString();
                cbbHinhThucThanhToan.Enabled = false;
            }
            this.lbDot.Text = this.hoaDon.Dot.ToString();
        }
        void HienThiTien(int tien)
        {
            this.lbTien.Text = tien.ToString();
        }

        void HienThiHinhThuc()
        {
            TimeSpan span = this.dangTuyen.NgayKT - this.dangTuyen.NgayBD;
            if (span.Days < 30)
            {
                cbbHinhThucThanhToan.Text = "Thanh toán 1 đợt";
                hoaDon.HinhThucTT = "Thanh toán 1 đợt";
                lbHinhThucThanhToan.Enabled = false;
                cbbHinhThucThanhToan.Enabled = false;
            }    
        }
        private void ThanhToan_L1_Load(object sender, EventArgs e)
        {
            try
            {
                if (!LAYER2_BLL.ThanhToan.ThanhToan.checkDangTuyen(this.dangTuyen))
                {
                    MessageBox.Show("không có dữ liệu");
                    this.Dispose();
                }
                this.hoaDon = new HoaDon(this.dangTuyen, DateTime.Today);
                if (!LAYER2_BLL.ThanhToan.ThanhToan.checkThanhToan(hoaDon, dangTuyen)) this.Dispose();    
                this.vouchers = Voucher.LayListVoucher(this.dangTuyen);
                HienThiDangTuyen();
                HienThiHinhThuc();
                HienThiDot();
                HienThiVoucher();
                int tien = hoaDon.TinhTien(this.dangTuyen, null);
                HienThiTien(tien);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.GetBaseException().ToString(), "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbbCachThucThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbbCachThucThanhToan.SelectedIndex == 0)
            {
                this.lbMaThe.Enabled = false;
                this.txtMaThe.Enabled = false;
            }
            else if (cbbCachThucThanhToan.SelectedIndex == 1)
            {
                this.lbMaThe.Enabled = true;
                this.txtMaThe.Enabled = true;
            }
        }

        private void cbbVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            Voucher voucher = new Voucher();
            string maCL = cbbVoucher.Text;
            foreach (Voucher vc in vouchers)
            {
                if (vc.MaCL == maCL)
                {
                    voucher = vc;
                    break;
                }
                voucher = null;  
            }
            int tien = this.hoaDon.TinhTien(this.dangTuyen, voucher);
            this.hoaDon.Voucher = voucher;
            HienThiTien(tien);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.hoaDon.MaThe = txtMaThe.Text;
            if(loaiThanhToan == 0) 
            {
                dangTuyen.ThemTTDangTuyen(dangTuyen);
            }
            HoaDon.ThemHoaDon(hoaDon);
            this.Dispose();
        }

        private void cbbHinhThucThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.hoaDon.HinhThucTT = cbbHinhThucThanhToan.Text;
            Voucher voucher = new Voucher();
            string maCL = cbbVoucher.Text;
            foreach (Voucher vc in vouchers)
            {
                if (vc.MaCL == maCL)
                {
                    voucher = vc;
                    break;
                }
                voucher = null;
            }
            int tien = this.hoaDon.TinhTien(this.dangTuyen, voucher);
            this.hoaDon.Voucher = voucher;
            HienThiTien(tien);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
