using NHOM8_QLHSUT.LAYER1_GUI.ManHinhChinh;
using NHOM8_QLHSUT.LAYER2_BLL.NopHoSo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NHOM8_QLHSUT.LAYER1_GUI.NopHoSo
{
    public partial class GhiNhanPhieuUngTuyen_L1 : Form
    {
        public GhiNhanPhieuUngTuyen_L1()
        {
            InitializeComponent();
        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            TrangChu trangchu = new TrangChu();
            Hide();
            trangchu.ShowDialog();
            Close();
        }

        private void btn_ghinhan_Click(object sender, EventArgs e)
        {
            bool checkMAUV = !string.IsNullOrEmpty(cb_mauv.Text);
            bool checkMADT = !string.IsNullOrEmpty(cb_madt.Text);
            bool checkTinhTrang = !string.IsNullOrEmpty(cb_tinhtrang.Text);
            bool checkBangCap = !string.IsNullOrEmpty(txt_bangcap.Text);
            bool checkChungTu = !string.IsNullOrEmpty(txt_chungtu.Text);
            bool checkHoSo = !string.IsNullOrEmpty(txt_hoso.Text);

            if (checkMAUV && checkMADT && checkTinhTrang && checkBangCap && checkChungTu && checkHoSo)
            {
                string mauv = cb_mauv.Text;
                string madt = cb_madt.Text;
                string tinhtrang = cb_tinhtrang.Text;
                string bangcap = GhiNhanPhieuUngTuyen_L2.FilterMultiline(txt_bangcap.Text);
                string chungtu = GhiNhanPhieuUngTuyen_L2.FilterMultiline(txt_chungtu.Text);
                string hoso = GhiNhanPhieuUngTuyen_L2.FilterMultiline (txt_hoso.Text);

                if (GhiNhanPhieuUngTuyen_L2.ThemPhieuGhiNhanUngTuyen(mauv, madt, bangcap, tinhtrang, chungtu, hoso))
                {
                    MessageBox.Show("Ghi nhận phiếu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ghi nhận thất bại (Mã ứng viên và Mã đăng tuyển đã tồn tại).", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void GhiNhanPhieuUngTuyen_L1_Load(object sender, EventArgs e)
        {
            DataTable dtUV = GhiNhanPhieuUngTuyen_L2.ThongTinUngVien();
            cb_mauv.DataSource = dtUV;
            cb_mauv.DisplayMember = "MAUV";
            cb_mauv.ValueMember = "MAUV";

            DataTable dtDT = GhiNhanPhieuUngTuyen_L2.ThongTinDangTuyen();
            cb_madt.DataSource = dtDT;
            cb_madt.DisplayMember = "MADT";
            cb_madt.ValueMember = "MADT";

            btn_huy_Click(sender, e);
        }

        private void cb_mauv_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtUV = GhiNhanPhieuUngTuyen_L2.ThongTinUngVien();
            foreach (DataRow dr in dtUV.Rows)
            {
                if (dr["MAUV"].ToString() == cb_mauv.Text)
                {
                    txt_hoten.Text = dr["HOTEN"].ToString();
                    txt_ngaysinh.Text = Convert.ToDateTime(dr["NGAYSINH"]).ToString("dd/MM/yyyy");
                }
            }
        }

        private void cb_madt_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dtDT = GhiNhanPhieuUngTuyen_L2.ThongTinDangTuyen();
            foreach (DataRow dr in dtDT.Rows)
            {
                if (dr["MADT"].ToString() == cb_madt.Text)
                {
                    txt_vitri.Text = dr["ViTriTuyenDung"].ToString();
                    txt_madn.Text = dr["MADN"].ToString();
                }
            }
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            cb_mauv.SelectedIndex = -1;
            cb_madt.SelectedIndex = -1;
            cb_mauv.Text = string.Empty;
            cb_madt.Text = string.Empty;
            cb_tinhtrang.Text = string.Empty;
            txt_bangcap.Text = string.Empty;
            txt_chungtu.Text = string.Empty;
            txt_hoso.Text = string.Empty;
            txt_hoten.Text = string.Empty;
            txt_ngaysinh.Text = string.Empty;
            txt_vitri.Text = string.Empty;
            txt_madn.Text = string.Empty;
        }
    }
}
