using NHOM8_QLHSUT.LAYER1_GUI.ManHinhChinh;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Console.WriteLine(txt_bangcap.Text);
        }
    }
}
