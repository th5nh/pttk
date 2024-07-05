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

namespace NHOM8_QLHSUT.LAYER1_GUI.DienTTDangTuyen
{
    public partial class fDienTTDangTuyen : Form
    {
        ThongTinDangTuyen data = new ThongTinDangTuyen();
        public fDienTTDangTuyen()
        {
            InitializeComponent();
        }

        private void fDienTTDangTuyen_Load(object sender, EventArgs e)
        {
            txtMaDN.Text = "Ma doanh nghiep";
            txtMaDN.Enabled = false;
            txtMaDT.Text = data.getAutoMaDangTuyen();
            txtMaDT.Enabled = false;    
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
             data.setThongTinDangTuyen(txtMaDT.Text, txtThongTinYC.Text, txtNgayBD.Value, txtNgayKT.Value, int.Parse(txtSoLuong.Text), txtViTri.Text, txtHinhThuc.Text, txtMaDN.Text);
             data.ThemTTDangTuyen(data);
        }
    }
}
