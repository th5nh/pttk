using NHOM8_QLHSUT.LAYER1_GUI.ManHinhChinh;
using NHOM8_QLHSUT.LAYER2_BLL.NopHoSo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHOM8_QLHSUT
{
    public partial class XemTTDT_L1 : Form
    {
        public XemTTDT_L1()
        {
            InitializeComponent();
        }

        private void NopHoSo_L1_Load(object sender, EventArgs e)
        {
            DataTable dt = XemTTDT_L2.ThongTinDangTuyen();

            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr.ItemArray);
            }
        }


        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
