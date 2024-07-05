using NHOM8_QLHSUT.LAYER1_GUI.NopHoSo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NHOM8_QLHSUT.LAYER1_GUI.ManHinhChinh
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void btn_dkuv_Click(object sender, EventArgs e)
        {
            DangKyUngVien_L1 dkuv = new DangKyUngVien_L1();
            Hide();
            dkuv.ShowDialog();
            Close();
        }

        private void btn_xemttdt_Click(object sender, EventArgs e)
        {
            XemTTDT_L1 xemttdt = new XemTTDT_L1();
            Hide();
            xemttdt.ShowDialog();
            Close();
        }

        private void btn_phieudkut_Click(object sender, EventArgs e)
        {

        }
    }
}
