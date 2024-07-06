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

namespace NHOM8_QLHSUT.LAYER1_GUI.ThanhToan
{
    public partial class ThanhToan_L1 : Form
    {
        // Lay Thong Tin Dang Tuyen o use case truoc
        // Tam xai string, int de Test thay cho class DangTuyen
        string maDT = "DT0001";
        int dot = 0;
       
        DataTable dt;
        HoaDon hd;
        List<Voucher> vouchers = new List<Voucher>();
        public ThanhToan_L1()
        {
            InitializeComponent();
            dt = ThanhToan_L2.LayDangTuyen(maDT);
        }
        public ThanhToan_L1(string maDT) // Test thay cho class DangTuyen
        {
            InitializeComponent();
            this.maDT = maDT;
            dt = ThanhToan_L2.LayDangTuyen(maDT);
        }
        void HienThiVoucher()
        {
            cbbVoucher.Items.Add("");
            foreach (Voucher vc in vouchers) 
            {
                string code = (vc.MaCL);
                MessageBox.Show(code);
                cbbVoucher.Items.Add(code);
            }
        }
        void HienThiDangTuyen()
        {
            dtDangTuyen.DataSource = dt;
        }
        void HienThiDot()
        {
            dot = HoaDon.HienThiDot(maDT); // dot = hd.Dot
            if (dot > 1)
            {
                cbbHinhThucThanhToan.Text = cbbHinhThucThanhToan.Items[1].ToString();
                cbbHinhThucThanhToan.Enabled = false;
            }
            lbDot.Text = dot.ToString();
        }
        void HienThiTien(int tien)
        {
            lbTien.Text = tien.ToString();
        }
        private void ThanhToan_L1_Load(object sender, EventArgs e)
        {
            try
            {
                if (dt.Rows.Count == 0)
                {
                    throw new Exception("Khong co du lieu");
                }
                vouchers = ThanhToan_L2.LayVoucher(maDT);
                HienThiDangTuyen();
                HienThiDot(); 
                HienThiVoucher();
                hd = new HoaDon(maDT, dot, DateTime.Today);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.GetBaseException().ToString(), "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbbCachThucThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCachThucThanhToan.SelectedIndex == 0)
            {
                lbMaThe.Enabled = false;
                txtMaThe.Enabled = false;
            }
            else if (cbbCachThucThanhToan.SelectedIndex == 1)
            {
                lbMaThe.Enabled = true;
                txtMaThe.Enabled = true;
            }
        }

        private void cbbVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            string voucher = cbbVoucher.SelectedIndex.ToString();
            int tien = hd.TinhTien(voucher);
            HienThiTien(tien);
        }
    }
}
