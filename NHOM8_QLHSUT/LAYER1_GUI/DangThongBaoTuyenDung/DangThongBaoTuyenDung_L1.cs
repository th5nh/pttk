using NHOM8_QLHSUT.LAYER1_GUI.ManHinhChinh;
using NHOM8_QLHSUT.LAYER2_BLL.DangThongBaoTuyenDung;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM8_QLHSUT.LAYER1_GUI.DangThongBaoTuyenDung
{
    public partial class DangThongBaoTuyenDung_L1 : Form
    {
        public DangThongBaoTuyenDung_L1()
        {
            InitializeComponent();
        }
    

        private void DangThongBao_L1_Load(object sender, EventArgs e)
        {
            DataTable dt = DangThongBaoTuyenDung_L2.ThongBaoDangTuyen();
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView.Rows.Add(dr.ItemArray);
            }
        }


        private void btc_vtc_Click(object sender, EventArgs e)
        {
            TrangChu trangchu = new TrangChu();
            Hide();
            trangchu.ShowDialog();
            Close();
        }
    }
}
