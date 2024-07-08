using NHOM8_QLHSUT.LAYER1_GUI.DangThongBaoTuyenDung;
using NHOM8_QLHSUT.LAYER1_GUI.DienTTDangTuyen;
using NHOM8_QLHSUT.LAYER1_GUI.NopHoSo;
using NHOM8_QLHSUT.LAYER1_GUI.ThanhToan_Huy;
using NHOM8_QLHSUT.LAYER2_BLL.DienTTDangTuyen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM8_QLHSUT.LAYER1_GUI
{
    public partial class MHMenu : Form
    {
        NhanVien nv = new NhanVien();
        public MHMenu(string MaNV)
        {
            InitializeComponent();
            nv.setMaNV(MaNV);
        }

        public void setEmpInfo()
        {
            nv.getEmpInfo();
            txtMaNV.Text = nv.MaNV;
            txtHoTen.Text = nv.HoTen;
            txtDiaChi.Text = nv.DiaChi;
            txtNgaySinh.Text = nv.NgaySinh.ToString();
            txtSDT.Text = nv.SDT;
            txtChucVu.Text = nv.ChucVu;
            txtUsername.Text = nv.MaNV;                                                                                                                                                                                                                                                                  
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MHDienTTDangTuyen f = new MHDienTTDangTuyen();
            this.Hide();
            f.ShowDialog();

            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MHMenu_Load(object sender, EventArgs e)
        {
            setEmpInfo();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MHDSThanhToan f = new MHDSThanhToan();
            this.Hide();
            f.ShowDialog();

            this.Show();
        }

        private void ứngViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ManHinhDuyetHoSo f = new ManHinhDuyetHoSo();
            this.Hide();
            f.ShowDialog();

            this.Show();
        }

        private void đăngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangThongBaoTuyenDung_L1 f = new DangThongBaoTuyenDung_L1();
            this.Hide();
            f.ShowDialog();

            this.Show();
        }

        private void danhSáchVịTríToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemTTDT_L1 f = new XemTTDT_L1();
            this.Hide();
            f.ShowDialog();

            this.Show();
        }

        private void ứngViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKyUngVien_L1 f = new DangKyUngVien_L1();
            this.Hide();
            f.ShowDialog();

            this.Show();
        }

        private void ứngTuyểnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GhiNhanPhieuUngTuyen_L1 f = new GhiNhanPhieuUngTuyen_L1();
            this.Hide(); 
            f.ShowDialog();
            this.Show();
        }
    }
}
